namespace MossGradingSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Language = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baseCodeFiles = new System.Windows.Forms.ListBox();
            this.foldersOfCode = new System.Windows.Forms.ListBox();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.anonymize = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sensitivity = new System.Windows.Forms.NumericUpDown();
            this.baseCodeBox = new System.Windows.Forms.GroupBox();
            this.removeSelectedFile = new System.Windows.Forms.Button();
            this.addFile = new System.Windows.Forms.Button();
            this.foldersCodeBox = new System.Windows.Forms.GroupBox();
            this.removeSelectedFolder = new System.Windows.Forms.Button();
            this.addFolder = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity)).BeginInit();
            this.baseCodeBox.SuspendLayout();
            this.foldersCodeBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Language
            // 
            this.Language.AllowDrop = true;
            this.Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Language.FormattingEnabled = true;
            this.Language.Items.AddRange(new object[] {
            resources.GetString("Language.Items"),
            resources.GetString("Language.Items1"),
            resources.GetString("Language.Items2"),
            resources.GetString("Language.Items3"),
            resources.GetString("Language.Items4")});
            resources.ApplyResources(this.Language, "Language");
            this.Language.Name = "Language";
            this.Language.SelectedIndexChanged += new System.EventHandler(this.Language_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // baseCodeFiles
            // 
            this.baseCodeFiles.AllowDrop = true;
            this.baseCodeFiles.FormattingEnabled = true;
            resources.ApplyResources(this.baseCodeFiles, "baseCodeFiles");
            this.baseCodeFiles.Name = "baseCodeFiles";
            this.baseCodeFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.baseCodeFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.baseCodeFiles_DragDrop);
            this.baseCodeFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.baseCodeFiles_DragEnter);
            this.baseCodeFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.baseCodeFiles_KeyUp);
            // 
            // foldersOfCode
            // 
            this.foldersOfCode.AllowDrop = true;
            this.foldersOfCode.FormattingEnabled = true;
            resources.ApplyResources(this.foldersOfCode, "foldersOfCode");
            this.foldersOfCode.Name = "foldersOfCode";
            this.foldersOfCode.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.foldersOfCode.DragDrop += new System.Windows.Forms.DragEventHandler(this.folderBox_DragDrop);
            this.foldersOfCode.DragEnter += new System.Windows.Forms.DragEventHandler(this.folderBox_DragEnter);
            this.foldersOfCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.foldersOfCode_KeyUp);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.anonymize);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.sensitivity);
            this.settingsBox.Controls.Add(this.Language);
            this.settingsBox.Controls.Add(this.label1);
            resources.ApplyResources(this.settingsBox, "settingsBox");
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.TabStop = false;
            // 
            // anonymize
            // 
            resources.ApplyResources(this.anonymize, "anonymize");
            this.anonymize.Name = "anonymize";
            this.anonymize.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // sensitivity
            // 
            resources.ApplyResources(this.sensitivity, "sensitivity");
            this.sensitivity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sensitivity.Name = "sensitivity";
            this.sensitivity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // baseCodeBox
            // 
            this.baseCodeBox.Controls.Add(this.removeSelectedFile);
            this.baseCodeBox.Controls.Add(this.addFile);
            this.baseCodeBox.Controls.Add(this.baseCodeFiles);
            resources.ApplyResources(this.baseCodeBox, "baseCodeBox");
            this.baseCodeBox.Name = "baseCodeBox";
            this.baseCodeBox.TabStop = false;
            // 
            // removeSelectedFile
            // 
            resources.ApplyResources(this.removeSelectedFile, "removeSelectedFile");
            this.removeSelectedFile.Name = "removeSelectedFile";
            this.removeSelectedFile.UseVisualStyleBackColor = true;
            this.removeSelectedFile.Click += new System.EventHandler(this.removeSelectedFile_Click);
            // 
            // addFile
            // 
            resources.ApplyResources(this.addFile, "addFile");
            this.addFile.Name = "addFile";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // foldersCodeBox
            // 
            this.foldersCodeBox.Controls.Add(this.removeSelectedFolder);
            this.foldersCodeBox.Controls.Add(this.addFolder);
            this.foldersCodeBox.Controls.Add(this.foldersOfCode);
            resources.ApplyResources(this.foldersCodeBox, "foldersCodeBox");
            this.foldersCodeBox.Name = "foldersCodeBox";
            this.foldersCodeBox.TabStop = false;
            // 
            // removeSelectedFolder
            // 
            resources.ApplyResources(this.removeSelectedFolder, "removeSelectedFolder");
            this.removeSelectedFolder.Name = "removeSelectedFolder";
            this.removeSelectedFolder.UseVisualStyleBackColor = true;
            this.removeSelectedFolder.Click += new System.EventHandler(this.removeSelectedFolder_Click);
            // 
            // addFolder
            // 
            resources.ApplyResources(this.addFolder, "addFolder");
            this.addFolder.Name = "addFolder";
            this.addFolder.UseVisualStyleBackColor = true;
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // upload
            // 
            resources.ApplyResources(this.upload, "upload");
            this.upload.Name = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            resources.ApplyResources(this.changeUserToolStripMenuItem, "changeUserToolStripMenuItem");
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.foldersCodeBox);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.baseCodeBox);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity)).EndInit();
            this.baseCodeBox.ResumeLayout(false);
            this.foldersCodeBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Language;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox baseCodeFiles;
        private System.Windows.Forms.ListBox foldersOfCode;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.GroupBox baseCodeBox;
        private System.Windows.Forms.GroupBox foldersCodeBox;
        private System.Windows.Forms.NumericUpDown sensitivity;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox anonymize;
        private System.Windows.Forms.Button removeSelectedFile;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.Button removeSelectedFolder;
        private System.Windows.Forms.Button addFolder;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

