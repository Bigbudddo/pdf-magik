using Roarshin.QPDF;
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

namespace PdfMagik.Views {
    
    public partial class PropertyWindow : Form {

        private enum PagingOptions {
            All,
            Select
        };

        private string _sourceFilePath = string.Empty;
        private string _destinationFilePath = string.Empty;
        private string _tempFolderPath = Path.GetTempPath();
        private PagingOptions _pagingOption = PagingOptions.All;
        private QPDFEncryptionMethodOption _encryptionOption = QPDFEncryptionMethodOption.none;
        private QPDFEncryptionModifyOption _encryptionModifyOption = QPDFEncryptionModifyOption.none;
        private QPDFEncryptionPrintOption _encryptionPrintOption = QPDFEncryptionPrintOption.full;

        public string QPDFLocation { get; set; }

        public PropertyWindow(string sourceFilePath, string destinationFilePath, bool isTempFile = false) {
            InitializeComponent();
            // setup the destination
            if (String.IsNullOrWhiteSpace(destinationFilePath)) {
                _destinationFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), string.Format("{0}.pdf", Guid.NewGuid()));
            }
            else {
                _destinationFilePath = destinationFilePath;  
            }
            
            // setup the source/temp file
            if (!isTempFile) {
                this.WriteTempFile(sourceFilePath);
            }
            else {
                _sourceFilePath = sourceFilePath;
            }

            // setup the UI
            txtbOutputDirectory.Text = _destinationFilePath;
        }

        private DialogResult Execute() {
            // this is the main logic
            // check if we have a file, do we overwrite it
            bool overwrite = false;
            if (File.Exists(_destinationFilePath)) {
                DialogResult confirmResult = MessageBox.Show("File exists! Would you like to overwrite the current file?", "PDF Magik - PDF Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                overwrite = (confirmResult == System.Windows.Forms.DialogResult.Yes);
            }

            if (File.Exists(_destinationFilePath) && !overwrite) {
                return System.Windows.Forms.DialogResult.Abort;
            }

            // we can continue from here!
            try {
                // does the source file still exist?
                if (!File.Exists(_sourceFilePath)) {
                    MessageBox.Show("Source file cannot be found! Unable to continue.", "PDF Magik - File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return System.Windows.Forms.DialogResult.Cancel;
                }

                // check if we want to write a copy out
                if (chkCreateCopy.Checked) {
                    this.WriteCopyFile(_sourceFilePath, _destinationFilePath);
                }

                var document = new QPDFDocument(_sourceFilePath);
                
                // setup paging
                if (_pagingOption == PagingOptions.All) {
                    document.Paging = new QPDFDocumentPaging();
                }
                else {
                    document.Paging = new QPDFDocumentPaging(int.Parse(numStart.Value.ToString()), int.Parse(numEnd.Value.ToString()));
                }

                // setup encryption
                document.Encryption = new QPDFDocumentEncryption(_encryptionOption);
                document.Encryption.DecryptPassword = txtbCurrentPassword.Text;
                document.Encryption.EncryptPassword = txtbNewPassword.Text;
                document.Encryption.AccessibilityFeatures = chkAccessibility.Checked;
                document.Encryption.TextGraphicExtraction = chkGraphicExtraction.Checked;
                document.Encryption.ModificationMethod = _encryptionModifyOption;
                document.Encryption.PrintMethod = _encryptionPrintOption;

                // setup environment
                // we are going to overoad here and allow custom QPDFPath
                QPDFEnvironment environment = null;
                if (!String.IsNullOrWhiteSpace(this.QPDFLocation)) {
                    environment = QPDF.Environment;
                    environment.QPDFPath = this.QPDFLocation;
                }

                // setup output
                var output = new QPDFOutput() {
                    OutputFilePath = _destinationFilePath
                };

                QPDF.ModifyPDF(document, environment, output);
                MessageBox.Show("Process completed.", "PDF Magik - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "PDF Magik - Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void WriteCopyFile(string source, string destination) {
            try {
                byte[] fileData = File.ReadAllBytes(source);

                // build destination file path
                string[] aDestination = destination.Split('.');
                aDestination[aDestination.Length - 2] += " (copy)";

                destination = string.Join(".", aDestination);
                File.WriteAllBytes(destination, fileData);
            }
            catch { }
        }

        private void WriteTempFile(string source) {
            if (File.Exists(source)) {
                try {
                    // create a temporary file from the source file path file!
                    byte[] fileContent = File.ReadAllBytes(source);
                    string tempFilePath = Path.Combine(_tempFolderPath, string.Format("{0}.pdf", Guid.NewGuid()));

                    File.WriteAllBytes(tempFilePath, fileContent);
                    _sourceFilePath = tempFilePath; // !Important
                }
                catch {
                    DialogResult = System.Windows.Forms.DialogResult.No;
                    this.Close();
                }
            }
            else {
                DialogResult = System.Windows.Forms.DialogResult.No;
                this.Close();
            }
        }

        #region Main Window Events

        private void PropertyWindow_FormClosing(object sender, FormClosingEventArgs e) {
            // delete the temp file
            if (File.Exists(_sourceFilePath)) {
                File.Delete(_sourceFilePath);
            }
        }

        private void btnOkay_Click(object sender, EventArgs e) {
            DialogResult result = this.Execute();
            if (result == System.Windows.Forms.DialogResult.Abort) {
                return;
            }

            DialogResult = result;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region TAB - Output

        private void btnBrowseOutput_Click(object sender, EventArgs e) {
            // setup basic file dialog for saving
            var dialog = new SaveFileDialog();
            dialog.Filter = "PDF|*.pdf";
            dialog.Title = "PDF Magik - Output PDF";

            // setup the default directory for the save dialog
            string[] aFilePath = _destinationFilePath.Split('\\');

            dialog.InitialDirectory = string.Join("\\", aFilePath.Take(aFilePath.Length - 1));
            dialog.FileName = aFilePath[aFilePath.Length - 1];

            // show the dialog and get the result
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !String.IsNullOrWhiteSpace(dialog.FileName)) {
                _destinationFilePath = dialog.FileName;
                txtbOutputDirectory.Text = _destinationFilePath;
            }
        }

        private void rdoPagingOptions_CheckedChanged(object sender, EventArgs e) {
            foreach (Control control in this.grpPaging.Controls) {
                if (control is RadioButton) {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked) {
                        switch (radio.Name) {
                            case "rdoPagA":
                                _pagingOption = PagingOptions.All;
                                break;
                            case "rdoPagB":
                                _pagingOption = PagingOptions.Select;
                                break;
                            default:
                                _pagingOption = PagingOptions.All;
                                break;
                        }
                    }
                }
            }

            numStart.Value = 1;
            numEnd.Value = 1;

            numStart.Enabled = false;
            numEnd.Enabled = false;

            if (_pagingOption == PagingOptions.Select) {
                numStart.Enabled = true;
                numEnd.Enabled = true;
            }
        }

        #endregion

        #region TAB - Encryption

        private void rdoEncryptionOptions_CheckedChanged(object sender, EventArgs e) {
            foreach (Control control in this.grpEncryptionOptions.Controls) {
                if (control is RadioButton) {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked) {
                        switch (radio.Name) {
                            case "rdoEncA":
                                _encryptionOption = QPDFEncryptionMethodOption.none;
                                break;
                            case "rdoEncB":
                                _encryptionOption = QPDFEncryptionMethodOption.decrypt;
                                break;
                            case "rdoEncC":
                                _encryptionOption = QPDFEncryptionMethodOption.decryptEncrypt;
                                break;
                            default:
                                _encryptionOption = QPDFEncryptionMethodOption.none;
                                break;
                        }
                    }
                }
            }
            
            // reset basic settings
            txtbNewPassword.Enabled = false;
            txtbCurrentPassword.Enabled = true;
            
            txtbCurrentPassword.Text = "";
            txtbNewPassword.Text = "";
            chkBoxShowPassword.Checked = false;

            grpPrintOptions.Enabled = false;
            grpModifyOptions.Enabled = false;
            grpAdditionalSettings.Enabled = false;

            if (_encryptionOption == QPDFEncryptionMethodOption.decryptEncrypt) {
                txtbNewPassword.Enabled = true;
                grpPrintOptions.Enabled = true;
                grpModifyOptions.Enabled = true;
                grpAdditionalSettings.Enabled = true;
            }
        }

        private void rdoModifyOptions_CheckedChanged(object sender, EventArgs e) {
            foreach (Control control in this.grpModifyOptions.Controls) {
                if (control is RadioButton) {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked) {
                        switch (radio.Name) {
                            case "rdoModA":
                                _encryptionModifyOption = QPDFEncryptionModifyOption.all;
                                break;
                            case "rdoModB":
                                _encryptionModifyOption = QPDFEncryptionModifyOption.annotate;
                                break;
                            case "rdoModC":
                                _encryptionModifyOption = QPDFEncryptionModifyOption.form;
                                break;
                            case "rdoModD":
                                _encryptionModifyOption = QPDFEncryptionModifyOption.assembly;
                                break;
                            case "rdoModE":
                            default:
                                _encryptionModifyOption = QPDFEncryptionModifyOption.none;
                                break;
                        }
                    }
                }
            }
        }

        private void rdoPrintOptions_CheckedChanged(object sender, EventArgs e) {
            foreach (Control control in this.grpModifyOptions.Controls) {
                if (control is RadioButton) {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked) {
                        switch (radio.Name) {
                            case "rdoPrnA":
                                _encryptionPrintOption = QPDFEncryptionPrintOption.full;
                                break;
                            case "rdoPrnB":
                                _encryptionPrintOption = QPDFEncryptionPrintOption.lowresolution;
                                break;
                            case "rdoPrnC":
                                _encryptionPrintOption = QPDFEncryptionPrintOption.disallow;
                                break;
                            default:
                                _encryptionPrintOption = QPDFEncryptionPrintOption.full;
                                break;
                        }
                    }
                }
            }
        }

        private void chkBoxShowPassword_CheckedChanged(object sender, EventArgs e) {
            txtbCurrentPassword.PasswordChar = (chkBoxShowPassword.Checked) ? '\0' : '*';
            txtbNewPassword.PasswordChar = (chkBoxShowPassword.Checked) ? '\0' : '*';
        }

        #endregion
    }
}
