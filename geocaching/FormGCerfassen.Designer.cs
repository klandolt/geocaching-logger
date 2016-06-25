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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxDirectoryOrFile = new System.Windows.Forms.GroupBox();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonDirectory = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBemerkung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dateTimePickerGefunden = new System.Windows.Forms.DateTimePicker();
            this.textBoxGCCode = new System.Windows.Forms.TextBox();
            this.textBoxBemerkung = new System.Windows.Forms.TextBox();
            this.tab1Labelpfad = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxOpenNotepad = new System.Windows.Forms.CheckBox();
            this.tab2Labelpfad = new System.Windows.Forms.Label();
            this.buttonChooseDirectory = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxDirectoryOrFile.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Log Ablage Verzeichnis wählen:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 347);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxDirectoryOrFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelBemerkung);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.buttonReset);
            this.tabPage1.Controls.Add(this.dateTimePickerGefunden);
            this.tabPage1.Controls.Add(this.textBoxGCCode);
            this.tabPage1.Controls.Add(this.textBoxBemerkung);
            this.tabPage1.Controls.Add(this.tab1Labelpfad);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geocache erfassen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxDirectoryOrFile
            // 
            this.groupBoxDirectoryOrFile.Controls.Add(this.radioButtonFile);
            this.groupBoxDirectoryOrFile.Controls.Add(this.radioButtonDirectory);
            this.groupBoxDirectoryOrFile.Location = new System.Drawing.Point(306, 38);
            this.groupBoxDirectoryOrFile.Name = "groupBoxDirectoryOrFile";
            this.groupBoxDirectoryOrFile.Size = new System.Drawing.Size(325, 41);
            this.groupBoxDirectoryOrFile.TabIndex = 25;
            this.groupBoxDirectoryOrFile.TabStop = false;
            this.groupBoxDirectoryOrFile.Text = "Wähle";
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(156, 18);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "GC-Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBemerkung
            // 
            this.labelBemerkung.AutoSize = true;
            this.labelBemerkung.Location = new System.Drawing.Point(19, 94);
            this.labelBemerkung.Name = "labelBemerkung";
            this.labelBemerkung.Size = new System.Drawing.Size(64, 13);
            this.labelBemerkung.TabIndex = 23;
            this.labelBemerkung.Text = "Bemerkung:";
            this.labelBemerkung.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(317, 253);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(206, 38);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(91, 253);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(206, 38);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dateTimePickerGefunden
            // 
            this.dateTimePickerGefunden.Location = new System.Drawing.Point(317, 211);
            this.dateTimePickerGefunden.Name = "dateTimePickerGefunden";
            this.dateTimePickerGefunden.Size = new System.Drawing.Size(314, 20);
            this.dateTimePickerGefunden.TabIndex = 19;
            this.dateTimePickerGefunden.Value = new System.DateTime(2015, 4, 12, 1, 10, 13, 0);
            // 
            // textBoxGCCode
            // 
            this.textBoxGCCode.Location = new System.Drawing.Point(89, 211);
            this.textBoxGCCode.Name = "textBoxGCCode";
            this.textBoxGCCode.Size = new System.Drawing.Size(209, 20);
            this.textBoxGCCode.TabIndex = 18;
            // 
            // textBoxBemerkung
            // 
            this.textBoxBemerkung.Location = new System.Drawing.Point(89, 94);
            this.textBoxBemerkung.Multiline = true;
            this.textBoxBemerkung.Name = "textBoxBemerkung";
            this.textBoxBemerkung.Size = new System.Drawing.Size(542, 100);
            this.textBoxBemerkung.TabIndex = 17;
            // 
            // tab1Labelpfad
            // 
            this.tab1Labelpfad.AutoSize = true;
            this.tab1Labelpfad.Location = new System.Drawing.Point(88, 22);
            this.tab1Labelpfad.Name = "tab1Labelpfad";
            this.tab1Labelpfad.Size = new System.Drawing.Size(88, 13);
            this.tab1Labelpfad.TabIndex = 16;
            this.tab1Labelpfad.Text = "default Pfad Text";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(89, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(209, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxOpenNotepad);
            this.tabPage2.Controls.Add(this.tab2Labelpfad);
            this.tabPage2.Controls.Add(this.buttonChooseDirectory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Einstellungen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpenNotepad
            // 
            this.checkBoxOpenNotepad.AutoSize = true;
            this.checkBoxOpenNotepad.Checked = true;
            this.checkBoxOpenNotepad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpenNotepad.Location = new System.Drawing.Point(62, 101);
            this.checkBoxOpenNotepad.Name = "checkBoxOpenNotepad";
            this.checkBoxOpenNotepad.Size = new System.Drawing.Size(108, 17);
            this.checkBoxOpenNotepad.TabIndex = 19;
            this.checkBoxOpenNotepad.Text = "Open Notepad++";
            this.checkBoxOpenNotepad.UseVisualStyleBackColor = true;
            this.checkBoxOpenNotepad.CheckedChanged += new System.EventHandler(this.checkBoxOpenNotepad_CheckedChanged);
            // 
            // tab2Labelpfad
            // 
            this.tab2Labelpfad.AutoSize = true;
            this.tab2Labelpfad.Location = new System.Drawing.Point(312, 52);
            this.tab2Labelpfad.Name = "tab2Labelpfad";
            this.tab2Labelpfad.Size = new System.Drawing.Size(88, 13);
            this.tab2Labelpfad.TabIndex = 17;
            this.tab2Labelpfad.Text = "default Pfad Text";
            // 
            // buttonChooseDirectory
            // 
            this.buttonChooseDirectory.Location = new System.Drawing.Point(62, 38);
            this.buttonChooseDirectory.Name = "buttonChooseDirectory";
            this.buttonChooseDirectory.Size = new System.Drawing.Size(209, 41);
            this.buttonChooseDirectory.TabIndex = 16;
            this.buttonChooseDirectory.Text = "Verzeichnis wählen";
            this.buttonChooseDirectory.UseVisualStyleBackColor = true;
            this.buttonChooseDirectory.Click += new System.EventHandler(this.buttonChooseDirectory_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // FormGCerfassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 406);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormGCerfassen";
            this.Text = "Geocache Logger";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxDirectoryOrFile.ResumeLayout(false);
            this.groupBoxDirectoryOrFile.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tab2Labelpfad;
        private System.Windows.Forms.Button buttonChooseDirectory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label tab1Labelpfad;
        private System.Windows.Forms.TextBox textBoxBemerkung;
        private System.Windows.Forms.TextBox textBoxGCCode;
        private System.Windows.Forms.DateTimePicker dateTimePickerGefunden;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBemerkung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonDirectory;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.GroupBox groupBoxDirectoryOrFile;
        private System.Windows.Forms.CheckBox checkBoxOpenNotepad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

