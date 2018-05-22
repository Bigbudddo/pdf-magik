using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roarshin.QPDF;

namespace PdfMagikLITE.Views {
    public partial class EncryptPDFWindow : Form {

        private bool _createCopy = false;
        private bool _showPassword = false;

        private string _selectedFilePath = string.Empty;
        private string _destinationFilePath = string.Empty;
        private string _encryptedPassword = string.Empty;

        public EncryptPDFWindow(string destinationFilePath, string selectedFilePath) {
            InitializeComponent();

            _selectedFilePath = selectedFilePath;
            _destinationFilePath = destinationFilePath;

            txtBoxSelectedFile.Text = selectedFilePath;
            txtBoxDestinationFile.Text = destinationFilePath;
        }

        private string CreateCopyFileName(string path) {
            string[] aPath = path.Split('.');
            aPath[aPath.Length - 2] += " (copy)";

            return string.Join(".", aPath);
        }

        private void EncryptPDF() {
            byte[] copiedFile = File.ReadAllBytes(_selectedFilePath);
            using (Stream ms = new MemoryStream()) {

                var document = new QPDFDocument {
                    InputFileBytes = copiedFile,
                    EncryptionPassword = _encryptedPassword
                };

                var output = new QPDFOutput {
                    OutputFilePath = _destinationFilePath
                };

                QPDF.EncryptPDF(document, output);
            }

            // Spit the copied file in memory back out..?
            if (_createCopy && copiedFile != null && _destinationFilePath == _selectedFilePath) {
                // NOTE: only use the copy feature IF the new 
                // encrypted PDF will have the same name and path
                // write the copy back into a file now the encryption has completed
                string fileName = this.CreateCopyFileName(_selectedFilePath);
                File.WriteAllBytes(fileName, copiedFile);
            }

            // message the user as the process/task/encryption has been completed
            MessageBox.Show("Your PDF has now been protected with the assigned password.", "PDFMagikLITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Events

        private void chkCreateCopy_CheckedChanged(object sender, EventArgs e) {
            _createCopy = chkCreateCopy.Checked;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e) {
            _showPassword = chkShowPassword.Checked;
            txtboxPassword.PasswordChar = (chkShowPassword.Checked) ? '\0' : '*';
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            this.EncryptPDF();
            // Trying to keep long logic out of event listeners,
            // don't know if that's a good idea? We'll see
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        
    }
}
