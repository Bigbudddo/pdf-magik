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
/// NOTE: this version here was modified to work with PDFMagik application...
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

    public enum QPDFEncryptionMethodOption {
        none,
        decrypt,
        decryptEncrypt
    }

    public enum QPDFEncryptionModifyOption {
        all,
        annotate,
        form,
        assembly,
        none
    }

    public enum QPDFEncryptionPrintOption {
        full,
        lowresolution,
        disallow
    }


    public class QPDFException : Exception {

        public QPDFException(string msg) : base(msg) { }
    }

    public class QPDFNoDataEception : QPDFException {

        public QPDFNoDataEception() : base("QPDF conversion cannot begin as the source file cannot be found.") { }
    }

    public class QPDFTimeoutException : QPDFException {

        public QPDFTimeoutException() : base("QPDF conversion process has not finished in the given period.") { }
    }


    public class QPDFDocument {

        private string _inputFilePath = string.Empty;
        private byte[] _inputFileBytes = null;

        public bool IsTemporarySourceFile { get; set; }
        public QPDFDocumentEncryption Encryption { get; set; }
        public QPDFDocumentPaging Paging { get; set; }

        public string InputFilePath { get { return _inputFilePath; } set { _inputFilePath = value; } }
        public byte[] InputFileBytes { get { return _inputFileBytes; } }

        public QPDFDocument(string inputFilePath) {
            IsTemporarySourceFile = false;
            _inputFilePath = inputFilePath;
        }

        public QPDFDocument(byte[] inputFileBytes) {
            IsTemporarySourceFile = true;
            _inputFileBytes = inputFileBytes;
        }
    }

    public class QPDFDocumentEncryption {

        private bool _accessibilityFeatures = true;
        private bool _textGraphicExtraction = false;
        private int _encryptionKeyLength = 128;
        private QPDFEncryptionMethodOption _method = QPDFEncryptionMethodOption.none;
        private QPDFEncryptionModifyOption _modify = QPDFEncryptionModifyOption.none;
        private QPDFEncryptionPrintOption _print = QPDFEncryptionPrintOption.full;

        public string DecryptPassword { get; set; }
        public string EncryptPassword { get; set; }

        public bool AccessibilityFeatures { get { return _accessibilityFeatures; } set { _accessibilityFeatures = value; } }
        public bool TextGraphicExtraction { get { return _textGraphicExtraction; } set { _textGraphicExtraction = value; } }
        public int EncryptionKeyLength { get { return _encryptionKeyLength; } set { _encryptionKeyLength = value; } }
        public QPDFEncryptionMethodOption EncryptionMethod { get { return _method; } set { _method = value; } }
        public QPDFEncryptionModifyOption ModificationMethod { get { return _modify; } set { _modify = value; } }
        public QPDFEncryptionPrintOption PrintMethod { get { return _print; } set { _print = value; } }

        public QPDFDocumentEncryption(QPDFEncryptionMethodOption option) {
            _method = option;
        }
    }

    public class QPDFDocumentPaging {

        public bool SelectAllPages { get; set; }
        public int PageStart { get; set; }
        public int PageEnd { get; set; }

        public QPDFDocumentPaging() {
            SelectAllPages = true;
        }

        public QPDFDocumentPaging(int start, int end) {
            SelectAllPages = false;
            PageStart = start;
            PageEnd = end;
        }
    }


    public class QPDFEnvironment {

        public int Timeout { get; set; }
        public string QPDFPath { get; set; }
        public string TempFolderPath { get; set; }
    }

    public class QPDFOutput {

        public string OutputFilePath { get; set; }
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

        private static string GetDocumentArguments(ref QPDFDocument document, string outputFilePath) {
            var paramsBuilder = new StringBuilder();

            // check for a password
            if (document.Encryption != null && !String.IsNullOrWhiteSpace(document.Encryption.DecryptPassword)) {
                paramsBuilder.AppendFormat("--password={0} ", document.Encryption.DecryptPassword);
            }

            // handle encryption options
            if (document.Encryption != null && document.Encryption.EncryptionMethod == QPDFEncryptionMethodOption.decrypt) {
                paramsBuilder.Append("--decrypt ");
            }
            else if (document.Encryption != null && document.Encryption.EncryptionMethod == QPDFEncryptionMethodOption.decryptEncrypt) {
                paramsBuilder.AppendFormat("--encrypt {0} {0} {1} ", document.Encryption.EncryptPassword, document.Encryption.EncryptionKeyLength);

                paramsBuilder.AppendFormat("--accessibility={0} ", (document.Encryption.AccessibilityFeatures) ? "y" : "n");
                paramsBuilder.AppendFormat("--extract={0} ", (document.Encryption.TextGraphicExtraction) ? "y" : "n");

                string printOption = string.Empty;
                switch (document.Encryption.PrintMethod) {
                    case QPDFEncryptionPrintOption.full:
                        printOption = "full";
                        break;
                    case QPDFEncryptionPrintOption.lowresolution:
                        printOption = "low";
                        break;
                    case QPDFEncryptionPrintOption.disallow:
                        printOption = "none";
                        break;
                }

                if (!String.IsNullOrWhiteSpace(printOption)) {
                    paramsBuilder.AppendFormat("--print={0} ", printOption);
                }

                string modifyOption = string.Empty;
                switch (document.Encryption.ModificationMethod) {
                    case QPDFEncryptionModifyOption.all:
                        modifyOption = "all";
                        break;
                    case QPDFEncryptionModifyOption.annotate:
                        modifyOption = "annotate";
                        break;
                    case QPDFEncryptionModifyOption.form:
                        modifyOption = "form";
                        break;
                    case QPDFEncryptionModifyOption.assembly:
                        modifyOption = "assembly";
                        break;
                    case QPDFEncryptionModifyOption.none:
                        modifyOption = "none";
                        break;
                }

                if (!String.IsNullOrWhiteSpace(modifyOption)) {
                    paramsBuilder.AppendFormat("--modify={0} ", modifyOption);
                }

                paramsBuilder.Append("-- ");
            }

            // handle paging
            if (document.Paging == null || document.Paging.SelectAllPages) {
                paramsBuilder.AppendFormat("\"{0}\" \"{1}\"", document.InputFilePath, outputFilePath);
            }
            else {
                paramsBuilder.AppendFormat("\"{0}\" --pages \"{0}\" {1}-{2} -- \"{3}\"", document.InputFilePath, document.Paging.PageStart, document.Paging.PageEnd, outputFilePath);
            }

            return paramsBuilder.ToString();
        }

        private static string GetOuputFile(ref QPDFOutput output, out bool delete, string tempFolderPath) {
            if (!String.IsNullOrWhiteSpace(output.OutputFilePath)) {
                delete = false;
                return output.OutputFilePath;
            }
            else {
                delete = true;
                output.OutputFilePath = Path.Combine(tempFolderPath, string.Format("{0}.pdf", Guid.NewGuid()));

                return output.OutputFilePath;
            }
        }

        private static string GetSourceFile(ref QPDFDocument document, out bool delete, string tempFolderPath) {
            if (!String.IsNullOrWhiteSpace(document.InputFilePath) && File.Exists(document.InputFilePath)) {
                delete = false;
                return document.InputFilePath;
            }
            else if (document.InputFileBytes != null) {
                // write the bytes into a temp folder
                document.InputFilePath = Path.Combine(tempFolderPath, string.Format("{0}.pdf", Guid.NewGuid()));
                File.WriteAllBytes(document.InputFilePath, document.InputFileBytes);

                delete = true;
                return document.InputFilePath;
            }
            else {
                throw new QPDFNoDataEception();
            }
        }


        public static void ModifyPDF(QPDFDocument document, QPDFOutput output) {
            ModifyPDF(document, null, output); 
        }

        public static void ModifyPDF(QPDFDocument document, QPDFEnvironment environment, QPDFOutput qoutput) {
            if (environment == null) {
                environment = Environment;
            }

            // check if QPDF is installed!
            if (!File.Exists(environment.QPDFPath)) {
                throw new QPDFException(String.Format("File '{0}' not found. Check if QPDF application is installed.", environment.QPDFPath));
            }

            bool deleteInput = false;
            string inputFilePath = GetSourceFile(ref document, out deleteInput, environment.TempFolderPath);
            if (!File.Exists(inputFilePath)) {
                // check if the PDF supplied is valid
                throw new QPDFException(String.Format("File '{0}' not found.", inputFilePath));
            }

            // setup our output
            bool deleteOutput = false;
            string outputFilePath = GetOuputFile(ref qoutput, out deleteOutput, environment.TempFolderPath);
            
            // setup our arguments
            string arguments = GetDocumentArguments(ref document, outputFilePath);
            try {
                var output = new StringBuilder();
                var error = new StringBuilder();

                using (Process process = new Process()) {
                    process.StartInfo.FileName = environment.QPDFPath;
                    process.StartInfo.Arguments = arguments;
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

                // setup our output callback!
                if (qoutput.OutputCallback != null) {
                    byte[] pdfFileBytes = File.ReadAllBytes(outputFilePath);
                    qoutput.OutputCallback(document, pdfFileBytes);
                }
            }
            finally {
                // delete the output file if we have specified too
                if (deleteOutput && File.Exists(outputFilePath)) {
                    File.Delete(outputFilePath);
                }

                // now check the input
                if (deleteInput && File.Exists(document.InputFilePath)) {
                    File.Delete(document.InputFilePath);
                }
            }
        }
    }
}
