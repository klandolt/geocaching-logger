namespace geocaching
{
    partial class FormGCerfassen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonChooseDirectory = new System.Windows.Forms.Button();
            this.labelpfad = new System.Windows.Forms.Label();
            this.textBoxBemerkung = new System.Windows.Forms.TextBox();
            this.textBoxGCCode = new System.Windows.Forms.TextBox();
            this.dateTimePickerGefunden = new System.Windows.Forms.DateTimePicker();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBemerkung = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDirectoryOrFile = new System.Windows.Forms.GroupBox();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonDirectory = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDirectoryOrFile.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(209, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Log Ablage Verzeichnis wählen:";
            // 
            // buttonChooseDirectory
            // 
            this.buttonChooseDirectory.Location = new System.Drawing.Point(79, 53);
            this.buttonChooseDirectory.Name = "buttonChooseDirectory";
            this.buttonChooseDirectory.Size = new System.Drawing.Size(209, 41);
            this.buttonChooseDirectory.TabIndex = 1;
            this.buttonChooseDirectory.Text = "Verzeichnis wählen";
            this.buttonChooseDirectory.UseVisualStyleBackColor = true;
            this.buttonChooseDirectory.Click += new System.EventHandler(this.buttonChooseDirectory_Click);
            // 
            // labelpfad
            // 
            this.labelpfad.AutoSize = true;
            this.labelpfad.Location = new System.Drawing.Point(304, 53);
            this.labelpfad.Name = "labelpfad";
            this.labelpfad.Size = new System.Drawing.Size(88, 13);
            this.labelpfad.TabIndex = 2;
            this.labelpfad.Text = "default Pfad Text";
            // 
            // textBoxBemerkung
            // 
            this.textBoxBemerkung.Location = new System.Drawing.Point(79, 139);
            this.textBoxBemerkung.Multiline = true;
            this.textBoxBemerkung.Name = "textBoxBemerkung";
            this.textBoxBemerkung.Size = new System.Drawing.Size(542, 100);
            this.textBoxBemerkung.TabIndex = 3;
            // 
            // textBoxGCCode
            // 
            this.textBoxGCCode.Location = new System.Drawing.Point(79, 256);
            this.textBoxGCCode.Name = "textBoxGCCode";
            this.textBoxGCCode.Size = new System.Drawing.Size(209, 20);
            this.textBoxGCCode.TabIndex = 4;
            // 
            // dateTimePickerGefunden
            // 
            this.dateTimePickerGefunden.Location = new System.Drawing.Point(307, 256);
            this.dateTimePickerGefunden.Name = "dateTimePickerGefunden";
            this.dateTimePickerGefunden.Size = new System.Drawing.Size(314, 20);
            this.dateTimePickerGefunden.TabIndex = 5;
            this.dateTimePickerGefunden.Value = new System.DateTime(2015, 4, 12, 1, 10, 13, 0);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(81, 298);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(206, 38);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(307, 298);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(206, 38);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBemerkung
            // 
            this.labelBemerkung.AutoSize = true;
            this.labelBemerkung.Location = new System.Drawing.Point(9, 139);
            this.labelBemerkung.Name = "labelBemerkung";
            this.labelBemerkung.Size = new System.Drawing.Size(64, 13);
            this.labelBemerkung.TabIndex = 9;
            this.labelBemerkung.Text = "Bemerkung:";
            this.labelBemerkung.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "GC-Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxDirectoryOrFile
            // 
            this.groupBoxDirectoryOrFile.Controls.Add(this.radioButtonFile);
            this.groupBoxDirectoryOrFile.Controls.Add(this.radioButtonDirectory);
            this.groupBoxDirectoryOrFile.Location = new System.Drawing.Point(296, 83);
            this.groupBoxDirectoryOrFile.Name = "groupBoxDirectoryOrFile";
            this.groupBoxDirectoryOrFile.Size = new System.Drawing.Size(325, 41);
            this.groupBoxDirectoryOrFile.TabIndex = 13;
            this.groupBoxDirectoryOrFile.TabStop = false;
            this.groupBoxDirectoryOrFile.Text = "Wähle";
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(156, 15);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(41, 17);
            this.radioButtonFile.TabIndex = 1;
            this.radioButtonFile.Text = "File";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonDirectory
            // 
            this.radioButtonDirectory.AutoSize = true;
            this.radioButtonDirectory.Checked = true;
            this.radioButtonDirectory.Location = new System.Drawing.Point(6, 18);
            this.radioButtonDirectory.Name = "radioButtonDirectory";
            this.radioButtonDirectory.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDirectory.TabIndex = 0;
            this.radioButtonDirectory.TabStop = true;
            this.radioButtonDirectory.Text = "Verzeichnis";
            this.radioButtonDirectory.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infosToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // infosToolStripMenuItem
            // 
            this.infosToolStripMenuItem.Name = "infosToolStripMenuItem";
            this.infosToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.infosToolStripMenuItem.Text = "Infos";
            this.infosToolStripMenuItem.Click += new System.EventHandler(this.infosToolStripMenuItem_Click);
            // 
            // FormGCerfassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 352);
            this.Controls.Add(this.groupBoxDirectoryOrFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBemerkung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dateTimePickerGefunden);
            this.Controls.Add(this.textBoxGCCode);
            this.Controls.Add(this.textBoxBemerkung);
            this.Controls.Add(this.labelpfad);
            this.Controls.Add(this.buttonChooseDirectory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGCerfassen";
            this.Text = "Geocache Verwaltung";
            this.groupBoxDirectoryOrFile.ResumeLayout(false);
            this.groupBoxDirectoryOrFile.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonChooseDirectory;
        private System.Windows.Forms.Label labelpfad;
        private System.Windows.Forms.TextBox textBoxBemerkung;
        private System.Windows.Forms.TextBox textBoxGCCode;
        private System.Windows.Forms.DateTimePicker dateTimePickerGefunden;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBemerkung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDirectoryOrFile;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonDirectory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosToolStripMenuItem;


        
    }
}

