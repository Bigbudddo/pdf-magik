using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using PdfMagikLITE.Views;

namespace PdfMagikLITE {
    
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class PDF : SharpContextMenu {

        private ContextMenuStrip _menu = new ContextMenuStrip();

        protected override bool CanShowMenu() {
            if (base.SelectedItemPaths.Count() > 1) {
                return false; // only allow 1 single PDF to be selected at a time
            }
            else if (!this.IsAllSelectedItemsPDFs()) {
                return false;
            }
            else {
                this.UpdateMenu();
                return true;
            }
        }

        protected override ContextMenuStrip CreateMenu() {
            _menu.Items.Clear();

            var menuItem = new ToolStripMenuItem {
                Text = "Encrypt PDF",
                Image = Properties.Resources.app_icon_small,
                ToolTipText = "Password protect your PDF file"
            };

            menuItem.Click += (sender, args) => EncryptPDF();
            _menu.Items.Add(menuItem);

            return _menu;
        }

        private bool IsAllSelectedItemsPDFs() {
            foreach (var item in base.SelectedItemPaths) {
                string[] aItem = item.Split('.');
                string itemExtension = aItem.Last();

                if (itemExtension.ToLower() != "pdf") {
                    return false;
                }
            }

            return true;
        }

        private void UpdateMenu() {
            _menu.Dispose();
            _menu = CreateMenu();
        }

        private void EncryptPDF() {
            try {
                if (base.SelectedItemPaths.Count() == 0 || base.SelectedItemPaths.Count() > 1) {
                    MessageBox.Show("Invalid selection has occured.", "PDFMagikLITE: error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string selectedPDFPath = base.SelectedItemPaths.First();
                string coreDestinationPath = base.SelectedItemPaths.First();

                var window = new EncryptPDFWindow(coreDestinationPath, selectedPDFPath);
                window.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "PDFMagikLITE: error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
