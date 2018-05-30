namespace PdfMagikTestUI {
    partial class mainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnOpenPropertyWindow = new System.Windows.Forms.Button();
            this.btnOpenPropertyWindowEncrypted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenPropertyWindow
            // 
            this.btnOpenPropertyWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPropertyWindow.AutoSize = true;
            this.btnOpenPropertyWindow.Location = new System.Drawing.Point(12, 12);
            this.btnOpenPropertyWindow.Name = "btnOpenPropertyWindow";
            this.btnOpenPropertyWindow.Size = new System.Drawing.Size(260, 23);
            this.btnOpenPropertyWindow.TabIndex = 0;
            this.btnOpenPropertyWindow.Text = "Open Property Window";
            this.btnOpenPropertyWindow.UseVisualStyleBackColor = true;
            this.btnOpenPropertyWindow.Click += new System.EventHandler(this.btnOpenPropertyWindow_Click);
            // 
            // btnOpenPropertyWindowEncrypted
            // 
            this.btnOpenPropertyWindowEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPropertyWindowEncrypted.AutoSize = true;
            this.btnOpenPropertyWindowEncrypted.Location = new System.Drawing.Point(12, 41);
            this.btnOpenPropertyWindowEncrypted.Name = "btnOpenPropertyWindowEncrypted";
            this.btnOpenPropertyWindowEncrypted.Size = new System.Drawing.Size(260, 23);
            this.btnOpenPropertyWindowEncrypted.TabIndex = 1;
            this.btnOpenPropertyWindowEncrypted.Text = "Open Property Window w/Encrypted";
            this.btnOpenPropertyWindowEncrypted.UseVisualStyleBackColor = true;
            this.btnOpenPropertyWindowEncrypted.Click += new System.EventHandler(this.btnOpenPropertyWindowEncrypted_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOpenPropertyWindowEncrypted);
            this.Controls.Add(this.btnOpenPropertyWindow);
            this.Name = "mainWindow";
            this.Text = "PDF Magik - Test UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPropertyWindow;
        private System.Windows.Forms.Button btnOpenPropertyWindowEncrypted;
    }
}

