namespace IndexedBitmapTool {
    partial class MainForm {
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
            this.bmpPreview = new System.Windows.Forms.PictureBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.btnPalletteUp = new System.Windows.Forms.Button();
            this.btnPalletteDown = new System.Windows.Forms.Button();
            this.btnPalletteEdit = new System.Windows.Forms.Button();
            this.yesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeFormat = new System.Windows.Forms.Button();
            this.persistentColorsChk = new System.Windows.Forms.CheckBox();
            this.palletteListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportColorPalletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warnAboutQualityLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bmpPreview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmpPreview
            // 
            this.bmpPreview.Location = new System.Drawing.Point(31, 49);
            this.bmpPreview.Name = "bmpPreview";
            this.bmpPreview.Size = new System.Drawing.Size(313, 225);
            this.bmpPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bmpPreview.TabIndex = 3;
            this.bmpPreview.TabStop = false;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(6, 6);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(332, 173);
            this.outputBox.TabIndex = 4;
            this.outputBox.Text = "";
            // 
            // btnPalletteUp
            // 
            this.btnPalletteUp.Enabled = false;
            this.btnPalletteUp.Location = new System.Drawing.Point(344, 51);
            this.btnPalletteUp.Name = "btnPalletteUp";
            this.btnPalletteUp.Size = new System.Drawing.Size(75, 23);
            this.btnPalletteUp.TabIndex = 6;
            this.btnPalletteUp.Text = "Move Up";
            this.btnPalletteUp.UseVisualStyleBackColor = true;
            this.btnPalletteUp.Click += new System.EventHandler(this.btnPalletteUp_Click);
            // 
            // btnPalletteDown
            // 
            this.btnPalletteDown.Enabled = false;
            this.btnPalletteDown.Location = new System.Drawing.Point(344, 109);
            this.btnPalletteDown.Name = "btnPalletteDown";
            this.btnPalletteDown.Size = new System.Drawing.Size(75, 23);
            this.btnPalletteDown.TabIndex = 7;
            this.btnPalletteDown.Text = "Move Down";
            this.btnPalletteDown.UseVisualStyleBackColor = true;
            this.btnPalletteDown.Click += new System.EventHandler(this.btnPalletteDown_Click);
            // 
            // btnPalletteEdit
            // 
            this.btnPalletteEdit.Enabled = false;
            this.btnPalletteEdit.Location = new System.Drawing.Point(344, 80);
            this.btnPalletteEdit.Name = "btnPalletteEdit";
            this.btnPalletteEdit.Size = new System.Drawing.Size(75, 23);
            this.btnPalletteEdit.TabIndex = 8;
            this.btnPalletteEdit.Text = "Edit";
            this.btnPalletteEdit.UseVisualStyleBackColor = true;
            this.btnPalletteEdit.Click += new System.EventHandler(this.btnPalletteEdit_Click);
            // 
            // yesToolStripMenuItem
            // 
            this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            this.yesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // yesToolStripMenuItem1
            // 
            this.yesToolStripMenuItem1.Name = "yesToolStripMenuItem1";
            this.yesToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // btnChangeFormat
            // 
            this.btnChangeFormat.Enabled = false;
            this.btnChangeFormat.Location = new System.Drawing.Point(233, 185);
            this.btnChangeFormat.Name = "btnChangeFormat";
            this.btnChangeFormat.Size = new System.Drawing.Size(105, 23);
            this.btnChangeFormat.TabIndex = 11;
            this.btnChangeFormat.Text = "Change Format";
            this.btnChangeFormat.UseVisualStyleBackColor = true;
            this.btnChangeFormat.Click += new System.EventHandler(this.btnChangeFormat_Click);
            // 
            // persistentColorsChk
            // 
            this.persistentColorsChk.AutoSize = true;
            this.persistentColorsChk.Location = new System.Drawing.Point(344, 138);
            this.persistentColorsChk.Name = "persistentColorsChk";
            this.persistentColorsChk.Size = new System.Drawing.Size(103, 17);
            this.persistentColorsChk.TabIndex = 12;
            this.persistentColorsChk.Text = "Maintain colours";
            this.persistentColorsChk.UseVisualStyleBackColor = true;
            // 
            // palletteListBox
            // 
            this.palletteListBox.FormattingEnabled = true;
            this.palletteListBox.Location = new System.Drawing.Point(6, 6);
            this.palletteListBox.Name = "palletteListBox";
            this.palletteListBox.Size = new System.Drawing.Size(332, 186);
            this.palletteListBox.TabIndex = 5;
            this.palletteListBox.SelectedIndexChanged += new System.EventHandler(this.palletteListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fielToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fielToolStripMenuItem
            // 
            this.fielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fielToolStripMenuItem.Name = "fielToolStripMenuItem";
            this.fielToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fielToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportColorPalletteToolStripMenuItem,
            this.warnAboutQualityLossToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // exportColorPalletteToolStripMenuItem
            // 
            this.exportColorPalletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.exportColorPalletteToolStripMenuItem.Name = "exportColorPalletteToolStripMenuItem";
            this.exportColorPalletteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportColorPalletteToolStripMenuItem.Text = "Color Pallette";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // warnAboutQualityLossToolStripMenuItem
            // 
            this.warnAboutQualityLossToolStripMenuItem.Checked = true;
            this.warnAboutQualityLossToolStripMenuItem.CheckOnClick = true;
            this.warnAboutQualityLossToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warnAboutQualityLossToolStripMenuItem.Name = "warnAboutQualityLossToolStripMenuItem";
            this.warnAboutQualityLossToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.warnAboutQualityLossToolStripMenuItem.Text = "Warn About Quality Loss";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(370, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(501, 344);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.outputBox);
            this.tabPage1.Controls.Add(this.btnChangeFormat);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Format";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 185);
            this.comboBox1.MaxDropDownItems = 99;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.palletteListBox);
            this.tabPage2.Controls.Add(this.persistentColorsChk);
            this.tabPage2.Controls.Add(this.btnPalletteUp);
            this.tabPage2.Controls.Add(this.btnPalletteDown);
            this.tabPage2.Controls.Add(this.btnPalletteEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pallette";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bmpPreview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Indexed Bitmap Tool";
            ((System.ComponentModel.ISupportInitialize)(this.bmpPreview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bmpPreview;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button btnPalletteUp;
        private System.Windows.Forms.Button btnPalletteDown;
        private System.Windows.Forms.Button btnPalletteEdit;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem1;
        private System.Windows.Forms.Button btnChangeFormat;
        private System.Windows.Forms.CheckBox persistentColorsChk;
        private System.Windows.Forms.ListBox palletteListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportColorPalletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warnAboutQualityLossToolStripMenuItem;
    }
}

