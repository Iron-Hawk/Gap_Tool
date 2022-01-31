namespace Gap_Tool
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
            this.numberOfGapsText = new System.Windows.Forms.Label();
            this.curEditGapPositionInListText = new System.Windows.Forms.Label();
            this.curEditGapScoreText = new System.Windows.Forms.Label();
            this.curEditGapNameText = new System.Windows.Forms.Label();
            this.openAndReadFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gap = new System.Windows.Forms.ListBox();
            this.curEditGapPositionInListValueText = new System.Windows.Forms.NumericUpDown();
            this.curEditGapScoreValueText = new System.Windows.Forms.NumericUpDown();
            this.curEditGapNameValueText = new System.Windows.Forms.TextBox();
            this.updateGapButton = new System.Windows.Forms.Button();
            this.removeGapButton = new System.Windows.Forms.Button();
            this.addGapButton = new System.Windows.Forms.Button();
            this.clearAllGapsButton = new System.Windows.Forms.Button();
            this.exportListToTextFileButton = new System.Windows.Forms.Button();
            this.creatorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.curEditGapPositionInListValueText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curEditGapScoreValueText)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfGapsText
            // 
            this.numberOfGapsText.AutoSize = true;
            this.numberOfGapsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfGapsText.Location = new System.Drawing.Point(46, 49);
            this.numberOfGapsText.Name = "numberOfGapsText";
            this.numberOfGapsText.Size = new System.Drawing.Size(121, 16);
            this.numberOfGapsText.TabIndex = 1;
            this.numberOfGapsText.Text = "Number Of Gaps: 0";
            // 
            // curEditGapPositionInListText
            // 
            this.curEditGapPositionInListText.AutoSize = true;
            this.curEditGapPositionInListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curEditGapPositionInListText.Location = new System.Drawing.Point(46, 82);
            this.curEditGapPositionInListText.Name = "curEditGapPositionInListText";
            this.curEditGapPositionInListText.Size = new System.Drawing.Size(121, 16);
            this.curEditGapPositionInListText.TabIndex = 9;
            this.curEditGapPositionInListText.Text = "Gap Position In List";
            // 
            // curEditGapScoreText
            // 
            this.curEditGapScoreText.AutoSize = true;
            this.curEditGapScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curEditGapScoreText.Location = new System.Drawing.Point(46, 137);
            this.curEditGapScoreText.Name = "curEditGapScoreText";
            this.curEditGapScoreText.Size = new System.Drawing.Size(76, 16);
            this.curEditGapScoreText.TabIndex = 10;
            this.curEditGapScoreText.Text = "Gap Score ";
            // 
            // curEditGapNameText
            // 
            this.curEditGapNameText.AutoSize = true;
            this.curEditGapNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curEditGapNameText.Location = new System.Drawing.Point(46, 191);
            this.curEditGapNameText.Name = "curEditGapNameText";
            this.curEditGapNameText.Size = new System.Drawing.Size(74, 16);
            this.curEditGapNameText.TabIndex = 12;
            this.curEditGapNameText.Text = "Gap Name";
            // 
            // openAndReadFileButton
            // 
            this.openAndReadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAndReadFileButton.Location = new System.Drawing.Point(12, 12);
            this.openAndReadFileButton.Name = "openAndReadFileButton";
            this.openAndReadFileButton.Size = new System.Drawing.Size(185, 34);
            this.openAndReadFileButton.TabIndex = 0;
            this.openAndReadFileButton.Text = "Open and Read File";
            this.openAndReadFileButton.UseVisualStyleBackColor = true;
            this.openAndReadFileButton.Click += new System.EventHandler(this.openAndReadFile);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileButton.Location = new System.Drawing.Point(12, 463);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(185, 34);
            this.saveFileButton.TabIndex = 6;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.SaveFile);
            // 
            // gap
            // 
            this.gap.FormattingEnabled = true;
            this.gap.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gap.Location = new System.Drawing.Point(203, 12);
            this.gap.Name = "gap";
            this.gap.ScrollAlwaysVisible = true;
            this.gap.Size = new System.Drawing.Size(585, 524);
            this.gap.TabIndex = 7;
            this.gap.SelectedIndexChanged += new System.EventHandler(this.curEditGapPositionInListUpdate);
            // 
            // curEditGapPositionInListValueText
            // 
            this.curEditGapPositionInListValueText.Location = new System.Drawing.Point(47, 101);
            this.curEditGapPositionInListValueText.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.curEditGapPositionInListValueText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.curEditGapPositionInListValueText.Name = "curEditGapPositionInListValueText";
            this.curEditGapPositionInListValueText.Size = new System.Drawing.Size(120, 20);
            this.curEditGapPositionInListValueText.TabIndex = 8;
            this.curEditGapPositionInListValueText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // curEditGapScoreValueText
            // 
            this.curEditGapScoreValueText.Location = new System.Drawing.Point(47, 156);
            this.curEditGapScoreValueText.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.curEditGapScoreValueText.Name = "curEditGapScoreValueText";
            this.curEditGapScoreValueText.Size = new System.Drawing.Size(120, 20);
            this.curEditGapScoreValueText.TabIndex = 11;
            // 
            // curEditGapNameValueText
            // 
            this.curEditGapNameValueText.Location = new System.Drawing.Point(49, 210);
            this.curEditGapNameValueText.Name = "curEditGapNameValueText";
            this.curEditGapNameValueText.Size = new System.Drawing.Size(118, 20);
            this.curEditGapNameValueText.TabIndex = 13;
            // 
            // updateGapButton
            // 
            this.updateGapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGapButton.Location = new System.Drawing.Point(12, 298);
            this.updateGapButton.Name = "updateGapButton";
            this.updateGapButton.Size = new System.Drawing.Size(185, 34);
            this.updateGapButton.TabIndex = 14;
            this.updateGapButton.Text = "Update Gap";
            this.updateGapButton.UseVisualStyleBackColor = true;
            this.updateGapButton.Click += new System.EventHandler(this.UpdateGap);
            // 
            // removeGapButton
            // 
            this.removeGapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGapButton.Location = new System.Drawing.Point(12, 338);
            this.removeGapButton.Name = "removeGapButton";
            this.removeGapButton.Size = new System.Drawing.Size(185, 34);
            this.removeGapButton.TabIndex = 15;
            this.removeGapButton.Text = "Remove Gap";
            this.removeGapButton.UseVisualStyleBackColor = true;
            this.removeGapButton.Click += new System.EventHandler(this.RemoveGap);
            // 
            // addGapButton
            // 
            this.addGapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGapButton.Location = new System.Drawing.Point(12, 258);
            this.addGapButton.Name = "addGapButton";
            this.addGapButton.Size = new System.Drawing.Size(185, 34);
            this.addGapButton.TabIndex = 16;
            this.addGapButton.Text = "Add Gap";
            this.addGapButton.UseVisualStyleBackColor = true;
            this.addGapButton.Click += new System.EventHandler(this.AddGap);
            // 
            // clearAllGapsButton
            // 
            this.clearAllGapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllGapsButton.Location = new System.Drawing.Point(12, 402);
            this.clearAllGapsButton.Name = "clearAllGapsButton";
            this.clearAllGapsButton.Size = new System.Drawing.Size(185, 34);
            this.clearAllGapsButton.TabIndex = 17;
            this.clearAllGapsButton.Text = "Clear All Gaps";
            this.clearAllGapsButton.UseVisualStyleBackColor = true;
            this.clearAllGapsButton.Click += new System.EventHandler(this.ClearAllGaps);
            // 
            // exportListToTextFileButton
            // 
            this.exportListToTextFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportListToTextFileButton.Location = new System.Drawing.Point(12, 503);
            this.exportListToTextFileButton.Name = "exportListToTextFileButton";
            this.exportListToTextFileButton.Size = new System.Drawing.Size(185, 34);
            this.exportListToTextFileButton.TabIndex = 18;
            this.exportListToTextFileButton.Text = "Export List To .txt File";
            this.exportListToTextFileButton.UseVisualStyleBackColor = true;
            this.exportListToTextFileButton.Click += new System.EventHandler(this.ExportListToTxtFile);
            // 
            // creatorText
            // 
            this.creatorText.AutoSize = true;
            this.creatorText.Location = new System.Drawing.Point(663, 542);
            this.creatorText.Name = "creatorText";
            this.creatorText.Size = new System.Drawing.Size(125, 13);
            this.creatorText.TabIndex = 19;
            this.creatorText.Text = "Tool Made By Iron Hawk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.creatorText);
            this.Controls.Add(this.exportListToTextFileButton);
            this.Controls.Add(this.clearAllGapsButton);
            this.Controls.Add(this.addGapButton);
            this.Controls.Add(this.removeGapButton);
            this.Controls.Add(this.updateGapButton);
            this.Controls.Add(this.curEditGapNameValueText);
            this.Controls.Add(this.curEditGapNameText);
            this.Controls.Add(this.curEditGapScoreValueText);
            this.Controls.Add(this.curEditGapScoreText);
            this.Controls.Add(this.curEditGapPositionInListText);
            this.Controls.Add(this.curEditGapPositionInListValueText);
            this.Controls.Add(this.gap);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.numberOfGapsText);
            this.Controls.Add(this.openAndReadFileButton);
            this.Name = "Form1";
            this.Text = "THAW Engine .gap Viewer/Editor";
            ((System.ComponentModel.ISupportInitialize)(this.curEditGapPositionInListValueText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curEditGapScoreValueText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openAndReadFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ListBox gap;
        private System.Windows.Forms.NumericUpDown curEditGapPositionInListValueText;
        private System.Windows.Forms.NumericUpDown curEditGapScoreValueText;
        private System.Windows.Forms.TextBox curEditGapNameValueText;
        private System.Windows.Forms.Button updateGapButton;
        private System.Windows.Forms.Button removeGapButton;
        private System.Windows.Forms.Button addGapButton;
        private System.Windows.Forms.Button clearAllGapsButton;
        private System.Windows.Forms.Button exportListToTextFileButton;
        private System.Windows.Forms.Label creatorText;
        private System.Windows.Forms.Label numberOfGapsText;
        private System.Windows.Forms.Label curEditGapPositionInListText;
        private System.Windows.Forms.Label curEditGapScoreText;
        private System.Windows.Forms.Label curEditGapNameText;
    }
}

