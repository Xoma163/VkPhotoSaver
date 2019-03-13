namespace VkPhotoSaver
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbLinks = new System.Windows.Forms.RichTextBox();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPrintGoodLinks = new System.Windows.Forms.CheckBox();
            this.checkBoxPrintBadLinks = new System.Windows.Forms.CheckBox();
            this.checkBoxPrintLogs = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSelectImagesDir = new System.Windows.Forms.Button();
            this.buttonSelectHTMLDir = new System.Windows.Forms.Button();
            this.labelExcludes = new System.Windows.Forms.Label();
            this.textBoxExcludes = new System.Windows.Forms.TextBox();
            this.labelIncludes = new System.Windows.Forms.Label();
            this.textBoxIncludes = new System.Windows.Forms.TextBox();
            this.labelImagesDir = new System.Windows.Forms.Label();
            this.textBoxImagesDir = new System.Windows.Forms.TextBox();
            this.labelHTMLDir = new System.Windows.Forms.Label();
            this.textBoxHtmlDir = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLinks
            // 
            this.rtbLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLinks.Location = new System.Drawing.Point(12, 12);
            this.rtbLinks.Name = "rtbLinks";
            this.rtbLinks.Size = new System.Drawing.Size(439, 287);
            this.rtbLinks.TabIndex = 1;
            this.rtbLinks.Text = "";
            this.rtbLinks.WordWrap = false;
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyToClipboard.Enabled = false;
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(575, 247);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(97, 23);
            this.buttonCopyToClipboard.TabIndex = 4;
            this.buttonCopyToClipboard.Text = "Copy to clipboard";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.ButtonCopyToClipboard_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveToFile.Enabled = false;
            this.buttonSaveToFile.Location = new System.Drawing.Point(455, 247);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(97, 23);
            this.buttonSaveToFile.TabIndex = 5;
            this.buttonSaveToFile.Text = "Save to file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.ButtonSaveToFile_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(455, 276);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(217, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Settings";
            // 
            // checkBoxPrintGoodLinks
            // 
            this.checkBoxPrintGoodLinks.AutoSize = true;
            this.checkBoxPrintGoodLinks.Location = new System.Drawing.Point(7, 32);
            this.checkBoxPrintGoodLinks.Name = "checkBoxPrintGoodLinks";
            this.checkBoxPrintGoodLinks.Size = new System.Drawing.Size(98, 17);
            this.checkBoxPrintGoodLinks.TabIndex = 8;
            this.checkBoxPrintGoodLinks.Text = "Print good links";
            this.checkBoxPrintGoodLinks.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintBadLinks
            // 
            this.checkBoxPrintBadLinks.AutoSize = true;
            this.checkBoxPrintBadLinks.Location = new System.Drawing.Point(7, 55);
            this.checkBoxPrintBadLinks.Name = "checkBoxPrintBadLinks";
            this.checkBoxPrintBadLinks.Size = new System.Drawing.Size(92, 17);
            this.checkBoxPrintBadLinks.TabIndex = 9;
            this.checkBoxPrintBadLinks.Text = "Print bad links";
            this.checkBoxPrintBadLinks.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintLogs
            // 
            this.checkBoxPrintLogs.AutoSize = true;
            this.checkBoxPrintLogs.Location = new System.Drawing.Point(7, 78);
            this.checkBoxPrintLogs.Name = "checkBoxPrintLogs";
            this.checkBoxPrintLogs.Size = new System.Drawing.Size(69, 17);
            this.checkBoxPrintLogs.TabIndex = 10;
            this.checkBoxPrintLogs.Text = "Print logs";
            this.checkBoxPrintLogs.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonSelectImagesDir);
            this.panel1.Controls.Add(this.buttonSelectHTMLDir);
            this.panel1.Controls.Add(this.labelExcludes);
            this.panel1.Controls.Add(this.textBoxExcludes);
            this.panel1.Controls.Add(this.labelIncludes);
            this.panel1.Controls.Add(this.textBoxIncludes);
            this.panel1.Controls.Add(this.labelImagesDir);
            this.panel1.Controls.Add(this.textBoxImagesDir);
            this.panel1.Controls.Add(this.labelHTMLDir);
            this.panel1.Controls.Add(this.textBoxHtmlDir);
            this.panel1.Controls.Add(this.checkBoxPrintLogs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxPrintBadLinks);
            this.panel1.Controls.Add(this.checkBoxPrintGoodLinks);
            this.panel1.Location = new System.Drawing.Point(457, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 210);
            this.panel1.TabIndex = 11;
            // 
            // buttonSelectImagesDir
            // 
            this.buttonSelectImagesDir.Location = new System.Drawing.Point(192, 126);
            this.buttonSelectImagesDir.Name = "buttonSelectImagesDir";
            this.buttonSelectImagesDir.Size = new System.Drawing.Size(20, 20);
            this.buttonSelectImagesDir.TabIndex = 20;
            this.buttonSelectImagesDir.Text = "...";
            this.buttonSelectImagesDir.UseVisualStyleBackColor = true;
            this.buttonSelectImagesDir.Click += new System.EventHandler(this.ButtonSelectImagesDir_Click);
            // 
            // buttonSelectHTMLDir
            // 
            this.buttonSelectHTMLDir.Location = new System.Drawing.Point(192, 101);
            this.buttonSelectHTMLDir.Name = "buttonSelectHTMLDir";
            this.buttonSelectHTMLDir.Size = new System.Drawing.Size(20, 20);
            this.buttonSelectHTMLDir.TabIndex = 19;
            this.buttonSelectHTMLDir.Text = "...";
            this.buttonSelectHTMLDir.UseVisualStyleBackColor = true;
            this.buttonSelectHTMLDir.Click += new System.EventHandler(this.ButtonSelectHTMLDir_Click);
            // 
            // labelExcludes
            // 
            this.labelExcludes.AutoSize = true;
            this.labelExcludes.Location = new System.Drawing.Point(4, 182);
            this.labelExcludes.Name = "labelExcludes";
            this.labelExcludes.Size = new System.Drawing.Size(50, 13);
            this.labelExcludes.TabIndex = 18;
            this.labelExcludes.Text = "Excludes";
            // 
            // textBoxExcludes
            // 
            this.textBoxExcludes.Location = new System.Drawing.Point(60, 179);
            this.textBoxExcludes.Name = "textBoxExcludes";
            this.textBoxExcludes.Size = new System.Drawing.Size(152, 20);
            this.textBoxExcludes.TabIndex = 17;
            // 
            // labelIncludes
            // 
            this.labelIncludes.AutoSize = true;
            this.labelIncludes.Location = new System.Drawing.Point(4, 156);
            this.labelIncludes.Name = "labelIncludes";
            this.labelIncludes.Size = new System.Drawing.Size(47, 13);
            this.labelIncludes.TabIndex = 16;
            this.labelIncludes.Text = "Includes";
            // 
            // textBoxIncludes
            // 
            this.textBoxIncludes.Location = new System.Drawing.Point(60, 153);
            this.textBoxIncludes.Name = "textBoxIncludes";
            this.textBoxIncludes.Size = new System.Drawing.Size(152, 20);
            this.textBoxIncludes.TabIndex = 15;
            // 
            // labelImagesDir
            // 
            this.labelImagesDir.AutoSize = true;
            this.labelImagesDir.Location = new System.Drawing.Point(4, 130);
            this.labelImagesDir.Name = "labelImagesDir";
            this.labelImagesDir.Size = new System.Drawing.Size(55, 13);
            this.labelImagesDir.TabIndex = 14;
            this.labelImagesDir.Text = "Images dir";
            // 
            // textBoxImagesDir
            // 
            this.textBoxImagesDir.Location = new System.Drawing.Point(60, 127);
            this.textBoxImagesDir.Name = "textBoxImagesDir";
            this.textBoxImagesDir.Size = new System.Drawing.Size(126, 20);
            this.textBoxImagesDir.TabIndex = 13;
            // 
            // labelHTMLDir
            // 
            this.labelHTMLDir.AutoSize = true;
            this.labelHTMLDir.Location = new System.Drawing.Point(4, 104);
            this.labelHTMLDir.Name = "labelHTMLDir";
            this.labelHTMLDir.Size = new System.Drawing.Size(51, 13);
            this.labelHTMLDir.TabIndex = 12;
            this.labelHTMLDir.Text = "HTML dir";
            // 
            // textBoxHtmlDir
            // 
            this.textBoxHtmlDir.Location = new System.Drawing.Point(60, 101);
            this.textBoxHtmlDir.Name = "textBoxHtmlDir";
            this.textBoxHtmlDir.Size = new System.Drawing.Size(126, 20);
            this.textBoxHtmlDir.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.rtbLinks);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.Text = "VkPhotoSaver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbLinks;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPrintGoodLinks;
        private System.Windows.Forms.CheckBox checkBoxPrintBadLinks;
        private System.Windows.Forms.CheckBox checkBoxPrintLogs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelImagesDir;
        private System.Windows.Forms.TextBox textBoxImagesDir;
        private System.Windows.Forms.Label labelHTMLDir;
        private System.Windows.Forms.TextBox textBoxHtmlDir;
        private System.Windows.Forms.Button buttonSelectImagesDir;
        private System.Windows.Forms.Button buttonSelectHTMLDir;
        private System.Windows.Forms.Label labelExcludes;
        private System.Windows.Forms.TextBox textBoxExcludes;
        private System.Windows.Forms.Label labelIncludes;
        private System.Windows.Forms.TextBox textBoxIncludes;
    }
}

