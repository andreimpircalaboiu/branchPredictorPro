namespace BranchPredictorPro.Presentation
{
    partial class MainForm
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
            this.BranchPredictor = new System.Windows.Forms.Button();
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TraceFileTextbox = new System.Windows.Forms.TextBox();
            this.DirectMappingRadioButton = new System.Windows.Forms.RadioButton();
            this.CacheEntriesCountTextbox = new System.Windows.Forms.TextBox();
            this.CompleteAssociativeRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TraceEntriesCountTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BranchPredictor
            // 
            this.BranchPredictor.Location = new System.Drawing.Point(423, 11);
            this.BranchPredictor.Name = "BranchPredictor";
            this.BranchPredictor.Size = new System.Drawing.Size(75, 23);
            this.BranchPredictor.TabIndex = 0;
            this.BranchPredictor.Text = "Import";
            this.BranchPredictor.UseVisualStyleBackColor = true;
            this.BranchPredictor.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // TraceFileTextbox
            // 
            this.TraceFileTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TraceFileTextbox.Enabled = false;
            this.TraceFileTextbox.Location = new System.Drawing.Point(139, 13);
            this.TraceFileTextbox.Name = "TraceFileTextbox";
            this.TraceFileTextbox.Size = new System.Drawing.Size(278, 20);
            this.TraceFileTextbox.TabIndex = 1;
            // 
            // DirectMappingRadioButton
            // 
            this.DirectMappingRadioButton.AutoSize = true;
            this.DirectMappingRadioButton.Location = new System.Drawing.Point(139, 90);
            this.DirectMappingRadioButton.Name = "DirectMappingRadioButton";
            this.DirectMappingRadioButton.Size = new System.Drawing.Size(97, 17);
            this.DirectMappingRadioButton.TabIndex = 2;
            this.DirectMappingRadioButton.TabStop = true;
            this.DirectMappingRadioButton.Text = "Direct Mapping";
            this.DirectMappingRadioButton.UseVisualStyleBackColor = true;
            this.DirectMappingRadioButton.CheckedChanged += new System.EventHandler(this.DirectMappingRadioButton_CheckedChanged);
            // 
            // CacheEntriesCountTextbox
            // 
            this.CacheEntriesCountTextbox.Location = new System.Drawing.Point(139, 64);
            this.CacheEntriesCountTextbox.Name = "CacheEntriesCountTextbox";
            this.CacheEntriesCountTextbox.Size = new System.Drawing.Size(278, 20);
            this.CacheEntriesCountTextbox.TabIndex = 3;
            // 
            // CompleteAssociativeRadioButton
            // 
            this.CompleteAssociativeRadioButton.AutoSize = true;
            this.CompleteAssociativeRadioButton.Location = new System.Drawing.Point(139, 113);
            this.CompleteAssociativeRadioButton.Name = "CompleteAssociativeRadioButton";
            this.CompleteAssociativeRadioButton.Size = new System.Drawing.Size(126, 17);
            this.CompleteAssociativeRadioButton.TabIndex = 4;
            this.CompleteAssociativeRadioButton.TabStop = true;
            this.CompleteAssociativeRadioButton.Text = "Complete Associative";
            this.CompleteAssociativeRadioButton.UseVisualStyleBackColor = true;
            this.CompleteAssociativeRadioButton.CheckedChanged += new System.EventHandler(this.CompleteAssociativeRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TRA File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cache entries count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cache architecture type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trace entries count";
            // 
            // TraceEntriesCountTextbox
            // 
            this.TraceEntriesCountTextbox.Enabled = false;
            this.TraceEntriesCountTextbox.Location = new System.Drawing.Point(139, 39);
            this.TraceEntriesCountTextbox.Name = "TraceEntriesCountTextbox";
            this.TraceEntriesCountTextbox.Size = new System.Drawing.Size(278, 20);
            this.TraceEntriesCountTextbox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TraceEntriesCountTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompleteAssociativeRadioButton);
            this.Controls.Add(this.CacheEntriesCountTextbox);
            this.Controls.Add(this.DirectMappingRadioButton);
            this.Controls.Add(this.TraceFileTextbox);
            this.Controls.Add(this.BranchPredictor);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BranchPredictor;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.TextBox TraceFileTextbox;
        private System.Windows.Forms.RadioButton DirectMappingRadioButton;
        private System.Windows.Forms.TextBox CacheEntriesCountTextbox;
        private System.Windows.Forms.RadioButton CompleteAssociativeRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TraceEntriesCountTextbox;
    }
}

