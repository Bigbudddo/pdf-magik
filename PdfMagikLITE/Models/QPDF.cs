/// QPDF.cs
/// Author: Stuart Harrison
/// Email: email@stuart-harrison.com
/// Version: 1.0
/// 
/// Description: A small wrapper inspired by WkHtmlToPDF C# wrapper that allows you to implement PDF encryption service to your applications.
/// Note: You will need to install the QPDF application on the host machine running your application/using this class
/// More Info: http://qpdf.sourceforge.net/
/// 
/// Please feel free to modify to your needs =]
/// Modified to work with PDFMagikLITE application...
/// 

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Roarshin.QPDF {

    public enum QPDFEncryptionModifyOption {
        all,
        annotate,
        form,
        assembly,
        none
    }

    public class QPDFException : Exception {

        public QPDFException(string msg) : base(msg) { }
    }

    public class QPDFTimeoutException : QPDFException {

        public QPDFTimeoutException() : base("QPDF conversion process has not finished in the given period.") { }
    }

    public class QPDFDocument {

        private int _keyLength = 128;
        private QPDFEncryptionModifyOption _modifyOption = QPDFEncryptionModifyOption.none;

        public string InputFilePath { get; set; }
        public Stream InputStream { get; set; }
        public byte[] InputFileBytes { get; set; }

        public string Password { get; set; }
        public string EncryptionPassword { get; set; }

        public int KeyLength { get { return _keyLength; } set { _keyLength = value; } }
        public QPDFEncryptionModifyOption EncryptionModifyOption { get { return _modifyOption; } set { _modifyOption = value; } }
    }

    public class QPDFEnvironment {

        public int Timeout { get; set; }
        public string QPDFPath { get; set; }
        public string TempFolderPath { get; set; }
    }

    public class QPDFOutput {

        public string OutputFilePath { get; set; }
        public Stream OutputStream { get; set; }
        public Action<QPDFDocument, byte[]> OutputCallback { get; set; }
    }

    public class QPDF {

        static QPDFEnvironment _e;

        public static QPDFEnvironment Environment {
            get {
                if (_e == null) {
                    _e = new QPDFEnvironment() {
                        Timeout = 60000,
                        QPDFPath = GetQPDFExeLocation(),
                        TempFolderPath = Path.GetTempPath()
                    };
                }

                return _e;
            }
        }

        private static string GetQPDFExeLocation() {
            // NOTE: I've modified this function in this version
            // Unmodified Version: https://gist.github.com/Bigbudddo/63e38c9192588a55c9b8810fd9191b8c
            
            string applicationDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return Path.Combine(applicationDirectory, @"qpdf-8.0.2\qpdf.exe");
        }

        private static void CopyStream(Stream input, Stream output) {
            byte[] buffer = new byte[8 * 1024];
            int len;
            
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0) {
                output.Write(buffer, 0, len);
            }  
        }

        public static void EncryptPDF(QPDFDocument document, QPDFOutput output) {
            EncryptPDF(document, null, output); 
        }

        public static void EncryptPDF(QPDFDocument document, QPDFEnvironment environment, QPDFOutput qoutput) {
            if (environment == null) {
                environment = Environment;
            }

            // check if QPDF is installed!
            if (!File.Exists(environment.QPDFPath)) {
                throw new QPDFException(String.Format("File '{0}' not found. Check if QPDF application is installed.", environment.QPDFPath));
            }

            // handle checking if we have supplied an actual PDF file location, or just given it a stream of data
            bool deleteTempInputFile = false;
            if (String.IsNullOrWhiteSpace(document.InputFilePath)) {
                // setup the temporary filepath/name for the input file
                document.InputFilePath = Path.Combine(environment.TempFolderPath, string.Format("{0}.pdf", Guid.NewGuid()));
                
                // write into a temporary file
                if (document.InputFileBytes != null) {
                    // convert byte[] into a temp file
                    File.WriteAllBytes(document.InputFilePath, document.InputFileBytes);
                    deleteTempInputFile = true;
                }
                else if (document.InputStream != null) {
                    // convert the input stream into a temp file
                    using (Stream tempWriteFile = File.Create(document.InputFilePath)) {
                        CopyStream(document.InputStream, tempWriteFile);
                    }
                    deleteTempInputFile = true;
                }
                else {
                    throw new QPDFException("unable to find byte array or input stream contained PDF data");
                }
            }

            // check if the PDF supplied is valid
            // NOTE: this will work in tandem with the above to convert byte[] into a file we can supply to QPDF
            if (!File.Exists(document.InputFilePath)) {
                throw new QPDFException(String.Format("File '{0}' not found.", document.InputFilePath));
            }

            // setup our output
            bool delete = false;
            string outputFilePath = string.Empty;
            if (!String.IsNullOrWhiteSpace(qoutput.OutputFilePath)) {
                outputFilePath = qoutput.OutputFilePath;
                delete = false;
            }
            else {
                outputFilePath = Path.Combine(environment.TempFolderPath, string.Format("{0}.pdf", Guid.NewGuid()));
                delete = true;
            }

            // setup our options to supply QPDF
            // TODO: add additional options at a later point/when they are required
            var paramsBuilder = new StringBuilder();
            
            // document password is for any existing password the one we are going to access may have
            if (!String.IsNullOrWhiteSpace(document.Password)) {
                paramsBuilder.AppendFormat("--password={0} ", document.Password);
            }

            // this one is for encrypting the output PDF (the important one really =])
            if (!String.IsNullOrWhiteSpace(document.EncryptionPassword)) {
                paramsBuilder.AppendFormat("--encrypt {0} {0} {1} -- ", document.EncryptionPassword, document.KeyLength);
            }

            // append the file paths to the end of our parameters
            paramsBuilder.AppendFormat("\"{0}\" \"{1}\"", document.InputFilePath, outputFilePath);

            try {
                var output = new StringBuilder();
                var error = new StringBuilder();

                using (Process process = new Process()) {
                    process.StartInfo.FileName = environment.QPDFPath;
                    process.StartInfo.Arguments = paramsBuilder.ToString();
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.RedirectStandardInput = true;

                    using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                    using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false)) {
                        DataReceivedEventHandler outputHandler = (sender, e) => {
                            if (e.Data == null) {
                                outputWaitHandle.Set();
                            }
                            else {
                                output.AppendLine(e.Data);
                            }
                        };

                        DataReceivedEventHandler errorHandler = (sender, e) => {
                            if (e.Data == null) {
                                errorWaitHandle.Set();
                            }
                            else {
                                error.AppendLine(e.Data);
                            }
                        };

                        process.OutputDataReceived += outputHandler;
                        process.ErrorDataReceived += errorHandler;

                        try {
                            process.Start();

                            process.BeginOutputReadLine();
                            process.BeginErrorReadLine();

                            if (process.WaitForExit(environment.Timeout) && outputWaitHandle.WaitOne(environment.Timeout) && errorWaitHandle.WaitOne(environment.Timeout)) {
                                if (process.ExitCode != 0 && !File.Exists(outputFilePath)) {
                                    throw new QPDFException(String.Format("QPDF conversion of '{0}' failed. QPDF output: \r\n{1}", document.InputFilePath, error));
                                }
                            }
                            else {
                                if (!process.HasExited) {
                                    process.Kill();
                                }

                                throw new QPDFTimeoutException();
                            }
                        }
                        finally {
                            process.OutputDataReceived -= outputHandler;
                            process.ErrorDataReceived -= errorHandler;
                        }
                    }
                }

                // once the process is finished we can setup our return
                if (qoutput.OutputStream != null) {
                    using (Stream fs = new FileStream(outputFilePath, FileMode.Open)) {
                        byte[] buffer = new byte[32 * 1024];
                        int read;

                        while ((read = fs.Read(buffer, 0, buffer.Length)) > 0) {
                            qoutput.OutputStream.Write(buffer, 0, read);
                        }
                    }
                }

                if (qoutput.OutputCallback != null) {
                    byte[] pdfFileBytes = File.ReadAllBytes(outputFilePath);
                    qoutput.OutputCallback(document, pdfFileBytes);
                }
            }
            finally {
                // delete the file if we have specified too
                if (delete && File.Exists(outputFilePath)) {
                    File.Delete(outputFilePath);
                }

                if (deleteTempInputFile && File.Exists(document.InputFilePath)) {
                    File.Delete(document.InputFilePath);
                }
            }
        }
    }
}
