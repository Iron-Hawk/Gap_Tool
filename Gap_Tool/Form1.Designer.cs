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
            this.open_file_button = new System.Windows.Forms.Button();
            this.number_of_gaps = new System.Windows.Forms.Label();
            this.save_file_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gap = new System.Windows.Forms.ListBox();
            this.gap_pos_value = new System.Windows.Forms.NumericUpDown();
            this.label_gap_pos = new System.Windows.Forms.Label();
            this.label_gap_score = new System.Windows.Forms.Label();
            this.gap_sv = new System.Windows.Forms.NumericUpDown();
            this.label_gap_name = new System.Windows.Forms.Label();
            this.gap_name = new System.Windows.Forms.TextBox();
            this.update_gap = new System.Windows.Forms.Button();
            this.remove_gap = new System.Windows.Forms.Button();
            this.add_gap = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.export_to_text = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gap_pos_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gap_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // open_file_button
            // 
            this.open_file_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_file_button.Location = new System.Drawing.Point(12, 12);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(185, 34);
            this.open_file_button.TabIndex = 0;
            this.open_file_button.Text = "Open and Read File";
            this.open_file_button.UseVisualStyleBackColor = true;
            this.open_file_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // number_of_gaps
            // 
            this.number_of_gaps.AutoSize = true;
            this.number_of_gaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_gaps.Location = new System.Drawing.Point(46, 49);
            this.number_of_gaps.Name = "number_of_gaps";
            this.number_of_gaps.Size = new System.Drawing.Size(121, 16);
            this.number_of_gaps.TabIndex = 1;
            this.number_of_gaps.Text = "Number Of Gaps: 0";
            this.number_of_gaps.Click += new System.EventHandler(this.label1_Click);
            // 
            // save_file_button
            // 
            this.save_file_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_file_button.Location = new System.Drawing.Point(12, 463);
            this.save_file_button.Name = "save_file_button";
            this.save_file_button.Size = new System.Drawing.Size(185, 34);
            this.save_file_button.TabIndex = 6;
            this.save_file_button.Text = "Save File";
            this.save_file_button.UseVisualStyleBackColor = true;
            this.save_file_button.Click += new System.EventHandler(this.save_file_button_Click);
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
            this.gap.SelectedIndexChanged += new System.EventHandler(this.gap_SelectedIndexChanged);
            // 
            // gap_pos_value
            // 
            this.gap_pos_value.Location = new System.Drawing.Point(47, 101);
            this.gap_pos_value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gap_pos_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gap_pos_value.Name = "gap_pos_value";
            this.gap_pos_value.Size = new System.Drawing.Size(120, 20);
            this.gap_pos_value.TabIndex = 8;
            this.gap_pos_value.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_gap_pos
            // 
            this.label_gap_pos.AutoSize = true;
            this.label_gap_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gap_pos.Location = new System.Drawing.Point(46, 82);
            this.label_gap_pos.Name = "label_gap_pos";
            this.label_gap_pos.Size = new System.Drawing.Size(121, 16);
            this.label_gap_pos.TabIndex = 9;
            this.label_gap_pos.Text = "Gap Position In List";
            // 
            // label_gap_score
            // 
            this.label_gap_score.AutoSize = true;
            this.label_gap_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gap_score.Location = new System.Drawing.Point(46, 137);
            this.label_gap_score.Name = "label_gap_score";
            this.label_gap_score.Size = new System.Drawing.Size(114, 16);
            this.label_gap_score.TabIndex = 10;
            this.label_gap_score.Text = "Gap Score Value ";
            // 
            // gap_sv
            // 
            this.gap_sv.Location = new System.Drawing.Point(47, 156);
            this.gap_sv.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.gap_sv.Name = "gap_sv";
            this.gap_sv.Size = new System.Drawing.Size(120, 20);
            this.gap_sv.TabIndex = 11;
            // 
            // label_gap_name
            // 
            this.label_gap_name.AutoSize = true;
            this.label_gap_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gap_name.Location = new System.Drawing.Point(46, 191);
            this.label_gap_name.Name = "label_gap_name";
            this.label_gap_name.Size = new System.Drawing.Size(74, 16);
            this.label_gap_name.TabIndex = 12;
            this.label_gap_name.Text = "Gap Name";
            // 
            // gap_name
            // 
            this.gap_name.Location = new System.Drawing.Point(49, 210);
            this.gap_name.Name = "gap_name";
            this.gap_name.Size = new System.Drawing.Size(118, 20);
            this.gap_name.TabIndex = 13;
            // 
            // update_gap
            // 
            this.update_gap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_gap.Location = new System.Drawing.Point(12, 258);
            this.update_gap.Name = "update_gap";
            this.update_gap.Size = new System.Drawing.Size(185, 34);
            this.update_gap.TabIndex = 14;
            this.update_gap.Text = "Update Gap";
            this.update_gap.UseVisualStyleBackColor = true;
            this.update_gap.Click += new System.EventHandler(this.update_gap_Click);
            // 
            // remove_gap
            // 
            this.remove_gap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_gap.Location = new System.Drawing.Point(12, 298);
            this.remove_gap.Name = "remove_gap";
            this.remove_gap.Size = new System.Drawing.Size(185, 34);
            this.remove_gap.TabIndex = 15;
            this.remove_gap.Text = "Remove Gap";
            this.remove_gap.UseVisualStyleBackColor = true;
            this.remove_gap.Click += new System.EventHandler(this.remove_gap_Click);
            // 
            // add_gap
            // 
            this.add_gap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_gap.Location = new System.Drawing.Point(12, 338);
            this.add_gap.Name = "add_gap";
            this.add_gap.Size = new System.Drawing.Size(185, 34);
            this.add_gap.TabIndex = 16;
            this.add_gap.Text = "Add Gap";
            this.add_gap.UseVisualStyleBackColor = true;
            this.add_gap.Click += new System.EventHandler(this.add_gap_Click);
            // 
            // clear_all
            // 
            this.clear_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all.Location = new System.Drawing.Point(12, 378);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(185, 34);
            this.clear_all.TabIndex = 17;
            this.clear_all.Text = "Clear All Gaps";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // export_to_text
            // 
            this.export_to_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_to_text.Location = new System.Drawing.Point(12, 503);
            this.export_to_text.Name = "export_to_text";
            this.export_to_text.Size = new System.Drawing.Size(185, 34);
            this.export_to_text.TabIndex = 18;
            this.export_to_text.Text = "Export List To .txt File";
            this.export_to_text.UseVisualStyleBackColor = true;
            this.export_to_text.Click += new System.EventHandler(this.export_to_text_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tool Made By Iron Hawk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.export_to_text);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.add_gap);
            this.Controls.Add(this.remove_gap);
            this.Controls.Add(this.update_gap);
            this.Controls.Add(this.gap_name);
            this.Controls.Add(this.label_gap_name);
            this.Controls.Add(this.gap_sv);
            this.Controls.Add(this.label_gap_score);
            this.Controls.Add(this.label_gap_pos);
            this.Controls.Add(this.gap_pos_value);
            this.Controls.Add(this.gap);
            this.Controls.Add(this.save_file_button);
            this.Controls.Add(this.number_of_gaps);
            this.Controls.Add(this.open_file_button);
            this.Name = "Form1";
            this.Text = "THAW Engine .gap Viewer/Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gap_pos_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gap_sv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.Label number_of_gaps;
        private System.Windows.Forms.Button save_file_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ListBox gap;
        private System.Windows.Forms.NumericUpDown gap_pos_value;
        private System.Windows.Forms.Label label_gap_pos;
        private System.Windows.Forms.Label label_gap_score;
        private System.Windows.Forms.NumericUpDown gap_sv;
        private System.Windows.Forms.Label label_gap_name;
        private System.Windows.Forms.TextBox gap_name;
        private System.Windows.Forms.Button update_gap;
        private System.Windows.Forms.Button remove_gap;
        private System.Windows.Forms.Button add_gap;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button export_to_text;
        private System.Windows.Forms.Label label1;
    }
}

