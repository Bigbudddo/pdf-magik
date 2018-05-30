namespace PdfMagik.Views {
    partial class PropertyWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyWindow));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpPaging = new System.Windows.Forms.GroupBox();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.lblNumEnd = new System.Windows.Forms.Label();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.lblNumStart = new System.Windows.Forms.Label();
            this.rdoPagB = new System.Windows.Forms.RadioButton();
            this.rdoPagA = new System.Windows.Forms.RadioButton();
            this.chkViewPDF = new System.Windows.Forms.CheckBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.chkCreateCopy = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpOutputDirectory = new System.Windows.Forms.GroupBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtbOutputDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEncryptionOptions = new System.Windows.Forms.GroupBox();
            this.rdoEncC = new System.Windows.Forms.RadioButton();
            this.rdoEncB = new System.Windows.Forms.RadioButton();
            this.rdoEncA = new System.Windows.Forms.RadioButton();
            this.grpAdditionalSettings = new System.Windows.Forms.GroupBox();
            this.chkGraphicExtraction = new System.Windows.Forms.CheckBox();
            this.chkAccessibility = new System.Windows.Forms.CheckBox();
            this.grpModifyOptions = new System.Windows.Forms.GroupBox();
            this.rdoModE = new System.Windows.Forms.RadioButton();
            this.rdoModD = new System.Windows.Forms.RadioButton();
            this.rdoModC = new System.Windows.Forms.RadioButton();
            this.rdoModB = new System.Windows.Forms.RadioButton();
            this.rdoModA = new System.Windows.Forms.RadioButton();
            this.grpPrintOptions = new System.Windows.Forms.GroupBox();
            this.rdoPrnC = new System.Windows.Forms.RadioButton();
            this.rdoPrnB = new System.Windows.Forms.RadioButton();
            this.rdoPrnA = new System.Windows.Forms.RadioButton();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.chkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtbNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtbCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpPaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpOutputDirectory.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEncryptionOptions.SuspendLayout();
            this.grpAdditionalSettings.SuspendLayout();
            this.grpModifyOptions.SuspendLayout();
            this.grpPrintOptions.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(447, 566);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkay.Location = new System.Drawing.Point(366, 566);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 1;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 548);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpPaging);
            this.tabPage1.Controls.Add(this.chkViewPDF);
            this.tabPage1.Controls.Add(this.lblWelcome);
            this.tabPage1.Controls.Add(this.chkCreateCopy);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.grpOutputDirectory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpPaging
            // 
            this.grpPaging.Controls.Add(this.numEnd);
            this.grpPaging.Controls.Add(this.lblNumEnd);
            this.grpPaging.Controls.Add(this.numStart);
            this.grpPaging.Controls.Add(this.lblNumStart);
            this.grpPaging.Controls.Add(this.rdoPagB);
            this.grpPaging.Controls.Add(this.rdoPagA);
            this.grpPaging.Location = new System.Drawing.Point(6, 179);
            this.grpPaging.Name = "grpPaging";
            this.grpPaging.Size = new System.Drawing.Size(490, 104);
            this.grpPaging.TabIndex = 5;
            this.grpPaging.TabStop = false;
            this.grpPaging.Text = "Paging Options";
            // 
            // numEnd
            // 
            this.numEnd.Enabled = false;
            this.numEnd.Location = new System.Drawing.Point(134, 69);
            this.numEnd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(52, 20);
            this.numEnd.TabIndex = 5;
            // 
            // lblNumEnd
            // 
            this.lblNumEnd.AutoSize = true;
            this.lblNumEnd.Location = new System.Drawing.Point(112, 71);
            this.lblNumEnd.Name = "lblNumEnd";
            this.lblNumEnd.Size = new System.Drawing.Size(16, 13);
            this.lblNumEnd.TabIndex = 4;
            this.lblNumEnd.Text = "to";
            // 
            // numStart
            // 
            this.numStart.Enabled = false;
            this.numStart.Location = new System.Drawing.Point(54, 69);
            this.numStart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(52, 20);
            this.numStart.TabIndex = 3;
            // 
            // lblNumStart
            // 
            this.lblNumStart.AutoSize = true;
            this.lblNumStart.Location = new System.Drawing.Point(13, 71);
            this.lblNumStart.Name = "lblNumStart";
            this.lblNumStart.Size = new System.Drawing.Size(35, 13);
            this.lblNumStart.TabIndex = 2;
            this.lblNumStart.Text = "Page:";
            // 
            // rdoPagB
            // 
            this.rdoPagB.Location = new System.Drawing.Point(9, 42);
            this.rdoPagB.Name = "rdoPagB";
            this.rdoPagB.Size = new System.Drawing.Size(475, 17);
            this.rdoPagB.TabIndex = 1;
            this.rdoPagB.Text = "Select Pages";
            this.rdoPagB.UseVisualStyleBackColor = true;
            this.rdoPagB.CheckedChanged += new System.EventHandler(this.rdoPagingOptions_CheckedChanged);
            // 
            // rdoPagA
            // 
            this.rdoPagA.Checked = true;
            this.rdoPagA.Location = new System.Drawing.Point(9, 19);
            this.rdoPagA.Name = "rdoPagA";
            this.rdoPagA.Size = new System.Drawing.Size(475, 17);
            this.rdoPagA.TabIndex = 0;
            this.rdoPagA.TabStop = true;
            this.rdoPagA.Text = "All Pages";
            this.rdoPagA.UseVisualStyleBackColor = true;
            this.rdoPagA.CheckedChanged += new System.EventHandler(this.rdoPagingOptions_CheckedChanged);
            // 
            // chkViewPDF
            // 
            this.chkViewPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkViewPDF.AutoSize = true;
            this.chkViewPDF.Location = new System.Drawing.Point(363, 499);
            this.chkViewPDF.Name = "chkViewPDF";
            this.chkViewPDF.Size = new System.Drawing.Size(133, 17);
            this.chkViewPDF.TabIndex = 4;
            this.chkViewPDF.Text = "View PDF after Saving";
            this.chkViewPDF.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Location = new System.Drawing.Point(104, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(392, 92);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = resources.GetString("lblWelcome.Text");
            // 
            // chkCreateCopy
            // 
            this.chkCreateCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCreateCopy.AutoSize = true;
            this.chkCreateCopy.Location = new System.Drawing.Point(273, 499);
            this.chkCreateCopy.Name = "chkCreateCopy";
            this.chkCreateCopy.Size = new System.Drawing.Size(84, 17);
            this.chkCreateCopy.TabIndex = 3;
            this.chkCreateCopy.Text = "Create Copy";
            this.chkCreateCopy.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PdfMagik.Properties.Resources.app_icon_large;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 92);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // grpOutputDirectory
            // 
            this.grpOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutputDirectory.Controls.Add(this.btnBrowseOutput);
            this.grpOutputDirectory.Controls.Add(this.txtbOutputDirectory);
            this.grpOutputDirectory.Controls.Add(this.label2);
            this.grpOutputDirectory.Location = new System.Drawing.Point(6, 101);
            this.grpOutputDirectory.Name = "grpOutputDirectory";
            this.grpOutputDirectory.Size = new System.Drawing.Size(490, 72);
            this.grpOutputDirectory.TabIndex = 0;
            this.grpOutputDirectory.TabStop = false;
            this.grpOutputDirectory.Text = "Output Directory";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(409, 30);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 2;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtbOutputDirectory
            // 
            this.txtbOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbOutputDirectory.Location = new System.Drawing.Point(9, 32);
            this.txtbOutputDirectory.Name = "txtbOutputDirectory";
            this.txtbOutputDirectory.Size = new System.Drawing.Size(394, 20);
            this.txtbOutputDirectory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.grpEncryptionOptions);
            this.tabPage2.Controls.Add(this.grpAdditionalSettings);
            this.tabPage2.Controls.Add(this.grpModifyOptions);
            this.tabPage2.Controls.Add(this.grpPrintOptions);
            this.tabPage2.Controls.Add(this.grpPassword);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encryption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PdfMagik.Properties.Resources.icon_lock_64_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 87);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // grpEncryptionOptions
            // 
            this.grpEncryptionOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncryptionOptions.Controls.Add(this.rdoEncC);
            this.grpEncryptionOptions.Controls.Add(this.rdoEncB);
            this.grpEncryptionOptions.Controls.Add(this.rdoEncA);
            this.grpEncryptionOptions.Location = new System.Drawing.Point(99, 6);
            this.grpEncryptionOptions.Name = "grpEncryptionOptions";
            this.grpEncryptionOptions.Size = new System.Drawing.Size(397, 87);
            this.grpEncryptionOptions.TabIndex = 12;
            this.grpEncryptionOptions.TabStop = false;
            this.grpEncryptionOptions.Text = "Encryption Options";
            // 
            // rdoEncC
            // 
            this.rdoEncC.Location = new System.Drawing.Point(9, 65);
            this.rdoEncC.Name = "rdoEncC";
            this.rdoEncC.Size = new System.Drawing.Size(382, 17);
            this.rdoEncC.TabIndex = 2;
            this.rdoEncC.Text = "Decrypt and Encrypt";
            this.rdoEncC.UseVisualStyleBackColor = true;
            this.rdoEncC.CheckedChanged += new System.EventHandler(this.rdoEncryptionOptions_CheckedChanged);
            // 
            // rdoEncB
            // 
            this.rdoEncB.Location = new System.Drawing.Point(9, 42);
            this.rdoEncB.Name = "rdoEncB";
            this.rdoEncB.Size = new System.Drawing.Size(382, 17);
            this.rdoEncB.TabIndex = 1;
            this.rdoEncB.Text = "Decrypt Only";
            this.rdoEncB.UseVisualStyleBackColor = true;
            this.rdoEncB.CheckedChanged += new System.EventHandler(this.rdoEncryptionOptions_CheckedChanged);
            // 
            // rdoEncA
            // 
            this.rdoEncA.Checked = true;
            this.rdoEncA.Location = new System.Drawing.Point(9, 19);
            this.rdoEncA.Name = "rdoEncA";
            this.rdoEncA.Size = new System.Drawing.Size(382, 17);
            this.rdoEncA.TabIndex = 0;
            this.rdoEncA.TabStop = true;
            this.rdoEncA.Text = "None";
            this.rdoEncA.UseVisualStyleBackColor = true;
            this.rdoEncA.CheckedChanged += new System.EventHandler(this.rdoEncryptionOptions_CheckedChanged);
            // 
            // grpAdditionalSettings
            // 
            this.grpAdditionalSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAdditionalSettings.Controls.Add(this.chkGraphicExtraction);
            this.grpAdditionalSettings.Controls.Add(this.chkAccessibility);
            this.grpAdditionalSettings.Enabled = false;
            this.grpAdditionalSettings.Location = new System.Drawing.Point(264, 425);
            this.grpAdditionalSettings.Name = "grpAdditionalSettings";
            this.grpAdditionalSettings.Size = new System.Drawing.Size(232, 91);
            this.grpAdditionalSettings.TabIndex = 11;
            this.grpAdditionalSettings.TabStop = false;
            this.grpAdditionalSettings.Text = "Additional Settings";
            // 
            // chkGraphicExtraction
            // 
            this.chkGraphicExtraction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGraphicExtraction.Location = new System.Drawing.Point(6, 42);
            this.chkGraphicExtraction.Name = "chkGraphicExtraction";
            this.chkGraphicExtraction.Size = new System.Drawing.Size(220, 17);
            this.chkGraphicExtraction.TabIndex = 1;
            this.chkGraphicExtraction.Text = "Allow text/graphic extraction";
            this.chkGraphicExtraction.UseVisualStyleBackColor = true;
            // 
            // chkAccessibility
            // 
            this.chkAccessibility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAccessibility.Checked = true;
            this.chkAccessibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAccessibility.Location = new System.Drawing.Point(6, 19);
            this.chkAccessibility.Name = "chkAccessibility";
            this.chkAccessibility.Size = new System.Drawing.Size(220, 17);
            this.chkAccessibility.TabIndex = 0;
            this.chkAccessibility.Text = "Allow accessibility features";
            this.chkAccessibility.UseVisualStyleBackColor = true;
            // 
            // grpModifyOptions
            // 
            this.grpModifyOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpModifyOptions.Controls.Add(this.rdoModE);
            this.grpModifyOptions.Controls.Add(this.rdoModD);
            this.grpModifyOptions.Controls.Add(this.rdoModC);
            this.grpModifyOptions.Controls.Add(this.rdoModB);
            this.grpModifyOptions.Controls.Add(this.rdoModA);
            this.grpModifyOptions.Enabled = false;
            this.grpModifyOptions.Location = new System.Drawing.Point(6, 283);
            this.grpModifyOptions.Name = "grpModifyOptions";
            this.grpModifyOptions.Size = new System.Drawing.Size(490, 136);
            this.grpModifyOptions.TabIndex = 10;
            this.grpModifyOptions.TabStop = false;
            this.grpModifyOptions.Text = "Modify Options";
            // 
            // rdoModE
            // 
            this.rdoModE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoModE.Checked = true;
            this.rdoModE.Location = new System.Drawing.Point(6, 111);
            this.rdoModE.Name = "rdoModE";
            this.rdoModE.Size = new System.Drawing.Size(478, 17);
            this.rdoModE.TabIndex = 4;
            this.rdoModE.TabStop = true;
            this.rdoModE.Text = "Disallow Modifications";
            this.rdoModE.UseVisualStyleBackColor = true;
            this.rdoModE.CheckedChanged += new System.EventHandler(this.rdoModifyOptions_CheckedChanged);
            // 
            // rdoModD
            // 
            this.rdoModD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoModD.Location = new System.Drawing.Point(6, 88);
            this.rdoModD.Name = "rdoModD";
            this.rdoModD.Size = new System.Drawing.Size(478, 17);
            this.rdoModD.TabIndex = 3;
            this.rdoModD.Text = "Allow document assembly only";
            this.rdoModD.UseVisualStyleBackColor = true;
            this.rdoModD.CheckedChanged += new System.EventHandler(this.rdoModifyOptions_CheckedChanged);
            // 
            // rdoModC
            // 
            this.rdoModC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoModC.Location = new System.Drawing.Point(6, 65);
            this.rdoModC.Name = "rdoModC";
            this.rdoModC.Size = new System.Drawing.Size(478, 17);
            this.rdoModC.TabIndex = 2;
            this.rdoModC.Text = "Allow form field fill-in and signing";
            this.rdoModC.UseVisualStyleBackColor = true;
            this.rdoModC.CheckedChanged += new System.EventHandler(this.rdoModifyOptions_CheckedChanged);
            // 
            // rdoModB
            // 
            this.rdoModB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoModB.Location = new System.Drawing.Point(6, 42);
            this.rdoModB.Name = "rdoModB";
            this.rdoModB.Size = new System.Drawing.Size(478, 17);
            this.rdoModB.TabIndex = 1;
            this.rdoModB.Text = "Allow comment authoring and form operations";
            this.rdoModB.UseVisualStyleBackColor = true;
            this.rdoModB.CheckedChanged += new System.EventHandler(this.rdoModifyOptions_CheckedChanged);
            // 
            // rdoModA
            // 
            this.rdoModA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoModA.Location = new System.Drawing.Point(6, 19);
            this.rdoModA.Name = "rdoModA";
            this.rdoModA.Size = new System.Drawing.Size(478, 17);
            this.rdoModA.TabIndex = 0;
            this.rdoModA.Text = "Allow full document modification";
            this.rdoModA.UseVisualStyleBackColor = true;
            this.rdoModA.CheckedChanged += new System.EventHandler(this.rdoModifyOptions_CheckedChanged);
            // 
            // grpPrintOptions
            // 
            this.grpPrintOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPrintOptions.Controls.Add(this.rdoPrnC);
            this.grpPrintOptions.Controls.Add(this.rdoPrnB);
            this.grpPrintOptions.Controls.Add(this.rdoPrnA);
            this.grpPrintOptions.Enabled = false;
            this.grpPrintOptions.Location = new System.Drawing.Point(6, 425);
            this.grpPrintOptions.Name = "grpPrintOptions";
            this.grpPrintOptions.Size = new System.Drawing.Size(252, 91);
            this.grpPrintOptions.TabIndex = 9;
            this.grpPrintOptions.TabStop = false;
            this.grpPrintOptions.Text = "Print Options";
            // 
            // rdoPrnC
            // 
            this.rdoPrnC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoPrnC.Location = new System.Drawing.Point(6, 65);
            this.rdoPrnC.Name = "rdoPrnC";
            this.rdoPrnC.Size = new System.Drawing.Size(240, 17);
            this.rdoPrnC.TabIndex = 2;
            this.rdoPrnC.Text = "Disallow Printing";
            this.rdoPrnC.UseVisualStyleBackColor = true;
            this.rdoPrnC.CheckedChanged += new System.EventHandler(this.rdoPrintOptions_CheckedChanged);
            // 
            // rdoPrnB
            // 
            this.rdoPrnB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoPrnB.Location = new System.Drawing.Point(6, 42);
            this.rdoPrnB.Name = "rdoPrnB";
            this.rdoPrnB.Size = new System.Drawing.Size(240, 17);
            this.rdoPrnB.TabIndex = 1;
            this.rdoPrnB.Text = "Allow low-resolution printing only";
            this.rdoPrnB.UseVisualStyleBackColor = true;
            this.rdoPrnB.CheckedChanged += new System.EventHandler(this.rdoPrintOptions_CheckedChanged);
            // 
            // rdoPrnA
            // 
            this.rdoPrnA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoPrnA.Checked = true;
            this.rdoPrnA.Location = new System.Drawing.Point(6, 19);
            this.rdoPrnA.Name = "rdoPrnA";
            this.rdoPrnA.Size = new System.Drawing.Size(240, 17);
            this.rdoPrnA.TabIndex = 0;
            this.rdoPrnA.TabStop = true;
            this.rdoPrnA.Text = "Allow full Printing";
            this.rdoPrnA.UseVisualStyleBackColor = true;
            this.rdoPrnA.CheckedChanged += new System.EventHandler(this.rdoPrintOptions_CheckedChanged);
            // 
            // grpPassword
            // 
            this.grpPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPassword.Controls.Add(this.chkBoxShowPassword);
            this.grpPassword.Controls.Add(this.txtbNewPassword);
            this.grpPassword.Controls.Add(this.lblNewPassword);
            this.grpPassword.Controls.Add(this.txtbCurrentPassword);
            this.grpPassword.Controls.Add(this.lblCurrentPassword);
            this.grpPassword.Controls.Add(this.lblPasswordInfo);
            this.grpPassword.Location = new System.Drawing.Point(6, 99);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(490, 178);
            this.grpPassword.TabIndex = 8;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Encryption Password";
            // 
            // chkBoxShowPassword
            // 
            this.chkBoxShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxShowPassword.AutoSize = true;
            this.chkBoxShowPassword.Location = new System.Drawing.Point(382, 151);
            this.chkBoxShowPassword.Name = "chkBoxShowPassword";
            this.chkBoxShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkBoxShowPassword.TabIndex = 6;
            this.chkBoxShowPassword.Text = "Show Password";
            this.chkBoxShowPassword.UseVisualStyleBackColor = true;
            this.chkBoxShowPassword.CheckedChanged += new System.EventHandler(this.chkBoxShowPassword_CheckedChanged);
            // 
            // txtbNewPassword
            // 
            this.txtbNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNewPassword.Enabled = false;
            this.txtbNewPassword.Location = new System.Drawing.Point(6, 125);
            this.txtbNewPassword.MaxLength = 128;
            this.txtbNewPassword.Name = "txtbNewPassword";
            this.txtbNewPassword.PasswordChar = '*';
            this.txtbNewPassword.Size = new System.Drawing.Size(478, 20);
            this.txtbNewPassword.TabIndex = 5;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(6, 109);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtbCurrentPassword
            // 
            this.txtbCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbCurrentPassword.Location = new System.Drawing.Point(6, 86);
            this.txtbCurrentPassword.MaxLength = 128;
            this.txtbCurrentPassword.Name = "txtbCurrentPassword";
            this.txtbCurrentPassword.PasswordChar = '*';
            this.txtbCurrentPassword.Size = new System.Drawing.Size(478, 20);
            this.txtbCurrentPassword.TabIndex = 3;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(6, 70);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(90, 13);
            this.lblCurrentPassword.TabIndex = 2;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPasswordInfo.Location = new System.Drawing.Point(6, 19);
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            this.lblPasswordInfo.Size = new System.Drawing.Size(478, 51);
            this.lblPasswordInfo.TabIndex = 1;
            this.lblPasswordInfo.Text = "Set a password for the PDF here. If the PDF does currently not have a password th" +
    "en leave the original password field blank. Then specify the new password in the" +
    " new password field provided.";
            // 
            // PropertyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 601);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertyWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Magik - PDF Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PropertyWindow_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpPaging.ResumeLayout(false);
            this.grpPaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpOutputDirectory.ResumeLayout(false);
            this.grpOutputDirectory.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEncryptionOptions.ResumeLayout(false);
            this.grpAdditionalSettings.ResumeLayout(false);
            this.grpModifyOptions.ResumeLayout(false);
            this.grpPrintOptions.ResumeLayout(false);
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpAdditionalSettings;
        private System.Windows.Forms.CheckBox chkGraphicExtraction;
        private System.Windows.Forms.CheckBox chkAccessibility;
        private System.Windows.Forms.GroupBox grpModifyOptions;
        private System.Windows.Forms.RadioButton rdoModE;
        private System.Windows.Forms.RadioButton rdoModD;
        private System.Windows.Forms.RadioButton rdoModC;
        private System.Windows.Forms.RadioButton rdoModB;
        private System.Windows.Forms.RadioButton rdoModA;
        private System.Windows.Forms.GroupBox grpPrintOptions;
        private System.Windows.Forms.RadioButton rdoPrnC;
        private System.Windows.Forms.RadioButton rdoPrnB;
        private System.Windows.Forms.RadioButton rdoPrnA;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.CheckBox chkBoxShowPassword;
        private System.Windows.Forms.TextBox txtbNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtbCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblPasswordInfo;
        private System.Windows.Forms.GroupBox grpEncryptionOptions;
        private System.Windows.Forms.RadioButton rdoEncC;
        private System.Windows.Forms.RadioButton rdoEncB;
        private System.Windows.Forms.RadioButton rdoEncA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpOutputDirectory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtbOutputDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.CheckBox chkViewPDF;
        private System.Windows.Forms.CheckBox chkCreateCopy;
        private System.Windows.Forms.GroupBox grpPaging;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.Label lblNumEnd;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Label lblNumStart;
        private System.Windows.Forms.RadioButton rdoPagB;
        private System.Windows.Forms.RadioButton rdoPagA;
    }
}