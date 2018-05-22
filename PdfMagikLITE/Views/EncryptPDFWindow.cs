using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roarshin.QPDF;

namespace PdfMagikLITE.Views {
    public partial class EncryptPDFWindow : Form {

        private bool _createCopy = false;
        private bool _runProgress = false;
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

        private void EnableViewWindow() {
            txtBoxSelectedFile.Enabled = !txtBoxSelectedFile.Enabled;
            txtBoxDestinationFile.Enabled = !txtBoxDestinationFile.Enabled;
            txtboxPassword.Enabled = !txtboxPassword.Enabled;

            chkCreateCopy.Enabled = !chkCreateCopy.Enabled;
            chkShowPassword.Enabled = !chkShowPassword.Enabled;

            btnBrowseSelected.Enabled = !btnBrowseSelected.Enabled;
            btnBrowseDestination.Enabled = !btnBrowseDestination.Enabled;

            btnOkay.Enabled = !btnOkay.Enabled;
            btnCancel.Enabled = !btnCancel.Enabled;
        }

        private void EncryptPDF() {
            this.EnableViewWindow();
            LoadValuesFromView();

            _runProgress = true;
            //bckGroundProgress.RunWorkerAsync();
            
            byte[] copiedFile = File.ReadAllBytes(_selectedFilePath);
            byte[] encryptedFile = null;
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
            
            this.EnableViewWindow();
            _runProgress = false;
            //bckGroundProgress.CancelAsync();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadValuesFromView() {
            _selectedFilePath = txtBoxSelectedFile.Text;
            _destinationFilePath = txtBoxDestinationFile.Text;
            _encryptedPassword = txtboxPassword.Text;
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

        private void btnBrowseSelected_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog();
            dialog.Filter = "PDF|*.pdf";
            dialog.Title = "Select a PDF to Encrypt";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                if (!String.IsNullOrWhiteSpace(dialog.FileName) && File.Exists(dialog.FileName)) {
                    _selectedFilePath = dialog.FileName;
                    txtBoxSelectedFile.Text = _selectedFilePath;
                }
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e) {
            var dialog = new SaveFileDialog();
            dialog.Filter = "PDF|*.pdf";
            dialog.Title = "PDF Destination";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                if (!String.IsNullOrWhiteSpace(dialog.FileName)) {
                    _destinationFilePath = dialog.FileName;
                    txtBoxDestinationFile.Text = _destinationFilePath;
                }
            }
        }

        private void bckGroundProgress_DoWork(object sender, DoWorkEventArgs e) {
            int counter = 1;

            do {
                bckGroundProgress.ReportProgress(counter);
                Thread.Sleep(100);

                counter++;
                if (counter > 100) {
                    counter = 1;
                }
            } while (_runProgress);
        }

        private void bckGroundProgress_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progBarEncrypt.Value = e.ProgressPercentage;
        }

        #endregion
    }
}
