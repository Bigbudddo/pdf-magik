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

namespace PdfMagikTestUI {
    
    public partial class mainWindow : Form {

        private readonly string _tempFilePath = "Content/qpdf-manual.pdf";
        private readonly string _tempFileEncryptedPath = "Content/qpdf-manual-encrypted.pdf";
        private readonly string _tempFolderPath = Path.GetTempPath();

        public mainWindow() {
            InitializeComponent();
        }

        private void OpenPropertyWindow(string source) {
            // NOTE: we shouldn't need to delete the temp file because our
            // property window SHOULD do that for us

            if (!File.Exists(source)) {
                MessageBox.Show("Could not locate PDF.", "PDF Magik - TestUI:error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // create a temporary file out of the "simulated selected pdf"
            byte[] fileContent = File.ReadAllBytes(source);
            string tempFileName = Path.Combine(_tempFolderPath, string.Format("{0}.pdf", Guid.NewGuid()));

            // write the temp file
            File.WriteAllBytes(tempFileName, fileContent);

            // now pass this file to our property window
            var window = new PdfMagik.Views.PropertyWindow(tempFileName, "", true);
            DialogResult result = window.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK) {
                MessageBox.Show("property window completed", "PDF Magik - TestUI:okay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == System.Windows.Forms.DialogResult.Cancel) {

            }
            else {
                MessageBox.Show("property window failed!", "PDF Magik - TestUI:error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOpenPropertyWindow_Click(object sender, EventArgs e) {
            this.OpenPropertyWindow(_tempFilePath);
        }

        private void btnOpenPropertyWindowEncrypted_Click(object sender, EventArgs e) {
            this.OpenPropertyWindow(_tempFileEncryptedPath);
        }
    }
}
