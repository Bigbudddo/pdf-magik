namespace PdfMagikLITE.Views {
    partial class EncryptPDFWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptPDFWindow));
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtBoxSelectedFile = new System.Windows.Forms.TextBox();
            this.txtBoxDestinationFile = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.chkCreateCopy = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.progBarEncrypt = new System.Windows.Forms.ProgressBar();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpBoxSettings = new System.Windows.Forms.GroupBox();
            this.grpBoxPassword = new System.Windows.Forms.GroupBox();
            this.lblSelectedFiles = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpBoxSettings.SuspendLayout();
            this.grpBoxPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Location = new System.Drawing.Point(131, 21);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(301, 89);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Enter the password you would like to encrypt this PDF with. Please ensure that it" +
    " is both memorable and secure before continuing.";
            // 
            // txtBoxSelectedFile
            // 
            this.txtBoxSelectedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSelectedFile.Location = new System.Drawing.Point(11, 41);
            this.txtBoxSelectedFile.Name = "txtBoxSelectedFile";
            this.txtBoxSelectedFile.Size = new System.Drawing.Size(321, 20);
            this.txtBoxSelectedFile.TabIndex = 1;
            // 
            // txtBoxDestinationFile
            // 
            this.txtBoxDestinationFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDestinationFile.Location = new System.Drawing.Point(11, 80);
            this.txtBoxDestinationFile.Name = "txtBoxDestinationFile";
            this.txtBoxDestinationFile.Size = new System.Drawing.Size(321, 20);
            this.txtBoxDestinationFile.TabIndex = 2;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPassword.Location = new System.Drawing.Point(11, 24);
            this.txtboxPassword.MaxLength = 16;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(401, 20);
            this.txtboxPassword.TabIndex = 3;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(11, 50);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkShowPassword.TabIndex = 4;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // chkCreateCopy
            // 
            this.chkCreateCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCreateCopy.AutoSize = true;
            this.chkCreateCopy.Location = new System.Drawing.Point(11, 111);
            this.chkCreateCopy.Name = "chkCreateCopy";
            this.chkCreateCopy.Size = new System.Drawing.Size(143, 17);
            this.chkCreateCopy.TabIndex = 5;
            this.chkCreateCopy.Text = "Create unprotected copy";
            this.chkCreateCopy.UseVisualStyleBackColor = true;
            this.chkCreateCopy.CheckedChanged += new System.EventHandler(this.chkCreateCopy_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(357, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkay.Location = new System.Drawing.Point(276, 366);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 7;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // progBarEncrypt
            // 
            this.progBarEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progBarEncrypt.Location = new System.Drawing.Point(12, 337);
            this.progBarEncrypt.Name = "progBarEncrypt";
            this.progBarEncrypt.Size = new System.Drawing.Size(420, 23);
            this.progBarEncrypt.TabIndex = 8;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::PdfMagikLITE.Properties.Resources.app_icon_large;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.InitialImage = global::PdfMagikLITE.Properties.Resources.app_icon_large;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(113, 101);
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // grpBoxSettings
            // 
            this.grpBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSettings.Controls.Add(this.button2);
            this.grpBoxSettings.Controls.Add(this.label2);
            this.grpBoxSettings.Controls.Add(this.button1);
            this.grpBoxSettings.Controls.Add(this.lblSelectedFiles);
            this.grpBoxSettings.Controls.Add(this.txtBoxSelectedFile);
            this.grpBoxSettings.Controls.Add(this.txtBoxDestinationFile);
            this.grpBoxSettings.Controls.Add(this.chkCreateCopy);
            this.grpBoxSettings.Location = new System.Drawing.Point(12, 119);
            this.grpBoxSettings.Name = "grpBoxSettings";
            this.grpBoxSettings.Size = new System.Drawing.Size(421, 134);
            this.grpBoxSettings.TabIndex = 10;
            this.grpBoxSettings.TabStop = false;
            this.grpBoxSettings.Text = "File Settings";
            // 
            // grpBoxPassword
            // 
            this.grpBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxPassword.Controls.Add(this.txtboxPassword);
            this.grpBoxPassword.Controls.Add(this.chkShowPassword);
            this.grpBoxPassword.Location = new System.Drawing.Point(12, 258);
            this.grpBoxPassword.Name = "grpBoxPassword";
            this.grpBoxPassword.Size = new System.Drawing.Size(420, 73);
            this.grpBoxPassword.TabIndex = 11;
            this.grpBoxPassword.TabStop = false;
            this.grpBoxPassword.Text = "Password Settings";
            // 
            // lblSelectedFiles
            // 
            this.lblSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedFiles.AutoSize = true;
            this.lblSelectedFiles.Location = new System.Drawing.Point(15, 25);
            this.lblSelectedFiles.Name = "lblSelectedFiles";
            this.lblSelectedFiles.Size = new System.Drawing.Size(68, 13);
            this.lblSelectedFiles.TabIndex = 2;
            this.lblSelectedFiles.Text = "Selected File";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(338, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Destination:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(338, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EncryptPDFWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 401);
            this.Controls.Add(this.grpBoxPassword);
            this.Controls.Add(this.grpBoxSettings);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.progBarEncrypt);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptPDFWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFMagikLITE: Encrypt PDF";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpBoxSettings.ResumeLayout(false);
            this.grpBoxSettings.PerformLayout();
            this.grpBoxPassword.ResumeLayout(false);
            this.grpBoxPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtBoxSelectedFile;
        private System.Windows.Forms.TextBox txtBoxDestinationFile;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.CheckBox chkCreateCopy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.ProgressBar progBarEncrypt;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpBoxSettings;
        private System.Windows.Forms.GroupBox grpBoxPassword;
        private System.Windows.Forms.Label lblSelectedFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}