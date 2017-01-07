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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TraceEntriesCountTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.EnableDisableLocalHistory = new System.Windows.Forms.CheckBox();
            this.EnableDisableGlobalHistory = new System.Windows.Forms.CheckBox();
            this.EnableDisablePath = new System.Windows.Forms.CheckBox();
            this.EnableDisableUnbiasedPol = new System.Windows.Forms.CheckBox();
            this.LocalHistoryUpDown = new System.Windows.Forms.NumericUpDown();
            this.GlobalHistoryUpDown = new System.Windows.Forms.NumericUpDown();
            this.PathUpDown = new System.Windows.Forms.NumericUpDown();
            this.UnbiasedUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LocalHistoryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalHistoryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PathUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnbiasedUpDown)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TRA File";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Local History:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Global History:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Path:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Unbiased polarization:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Result:";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(15, 174);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 15;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(15, 216);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(483, 100);
            this.OutputText.TabIndex = 16;
            // 
            // EnableDisableLocalHistory
            // 
            this.EnableDisableLocalHistory.AutoSize = true;
            this.EnableDisableLocalHistory.Location = new System.Drawing.Point(337, 71);
            this.EnableDisableLocalHistory.Name = "EnableDisableLocalHistory";
            this.EnableDisableLocalHistory.Size = new System.Drawing.Size(15, 14);
            this.EnableDisableLocalHistory.TabIndex = 17;
            this.EnableDisableLocalHistory.UseVisualStyleBackColor = true;
            this.EnableDisableLocalHistory.CheckedChanged += new System.EventHandler(this.EnableDisableLocalHistory_CheckedChanged);
            // 
            // EnableDisableGlobalHistory
            // 
            this.EnableDisableGlobalHistory.AutoSize = true;
            this.EnableDisableGlobalHistory.Location = new System.Drawing.Point(337, 94);
            this.EnableDisableGlobalHistory.Name = "EnableDisableGlobalHistory";
            this.EnableDisableGlobalHistory.Size = new System.Drawing.Size(15, 14);
            this.EnableDisableGlobalHistory.TabIndex = 19;
            this.EnableDisableGlobalHistory.UseVisualStyleBackColor = true;
            this.EnableDisableGlobalHistory.CheckedChanged += new System.EventHandler(this.EnableDisableGlobalHistory_CheckedChanged);
            // 
            // EnableDisablePath
            // 
            this.EnableDisablePath.AutoSize = true;
            this.EnableDisablePath.Location = new System.Drawing.Point(337, 117);
            this.EnableDisablePath.Name = "EnableDisablePath";
            this.EnableDisablePath.Size = new System.Drawing.Size(15, 14);
            this.EnableDisablePath.TabIndex = 21;
            this.EnableDisablePath.UseVisualStyleBackColor = true;
            this.EnableDisablePath.CheckedChanged += new System.EventHandler(this.EnableDisablePath_CheckedChanged);
            // 
            // EnableDisableUnbiasedPol
            // 
            this.EnableDisableUnbiasedPol.AutoSize = true;
            this.EnableDisableUnbiasedPol.Location = new System.Drawing.Point(336, 142);
            this.EnableDisableUnbiasedPol.Name = "EnableDisableUnbiasedPol";
            this.EnableDisableUnbiasedPol.Size = new System.Drawing.Size(15, 14);
            this.EnableDisableUnbiasedPol.TabIndex = 23;
            this.EnableDisableUnbiasedPol.UseVisualStyleBackColor = true;
            this.EnableDisableUnbiasedPol.CheckedChanged += new System.EventHandler(this.EnableDisableUnbiasedPol_CheckedChanged);
            // 
            // LocalHistoryUpDown
            // 
            this.LocalHistoryUpDown.Enabled = false;
            this.LocalHistoryUpDown.Location = new System.Drawing.Point(139, 65);
            this.LocalHistoryUpDown.Name = "LocalHistoryUpDown";
            this.LocalHistoryUpDown.Size = new System.Drawing.Size(192, 20);
            this.LocalHistoryUpDown.TabIndex = 25;
            this.LocalHistoryUpDown.ValueChanged += new System.EventHandler(this.LocalHistoryUpDown_ValueChanged);
            // 
            // GlobalHistoryUpDown
            // 
            this.GlobalHistoryUpDown.Enabled = false;
            this.GlobalHistoryUpDown.Location = new System.Drawing.Point(138, 88);
            this.GlobalHistoryUpDown.Name = "GlobalHistoryUpDown";
            this.GlobalHistoryUpDown.Size = new System.Drawing.Size(192, 20);
            this.GlobalHistoryUpDown.TabIndex = 26;
            this.GlobalHistoryUpDown.ValueChanged += new System.EventHandler(this.GlobalHistoryUpDown_ValueChanged);
            // 
            // PathUpDown
            // 
            this.PathUpDown.Enabled = false;
            this.PathUpDown.Location = new System.Drawing.Point(139, 111);
            this.PathUpDown.Name = "PathUpDown";
            this.PathUpDown.Size = new System.Drawing.Size(192, 20);
            this.PathUpDown.TabIndex = 27;
            this.PathUpDown.ValueChanged += new System.EventHandler(this.PathUpDown_ValueChanged);
            // 
            // UnbiasedUpDown
            // 
            this.UnbiasedUpDown.Enabled = false;
            this.UnbiasedUpDown.Location = new System.Drawing.Point(139, 137);
            this.UnbiasedUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UnbiasedUpDown.Name = "UnbiasedUpDown";
            this.UnbiasedUpDown.Size = new System.Drawing.Size(192, 20);
            this.UnbiasedUpDown.TabIndex = 28;
            this.UnbiasedUpDown.ValueChanged += new System.EventHandler(this.UnbiasedUpDown_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 328);
            this.Controls.Add(this.UnbiasedUpDown);
            this.Controls.Add(this.PathUpDown);
            this.Controls.Add(this.GlobalHistoryUpDown);
            this.Controls.Add(this.LocalHistoryUpDown);
            this.Controls.Add(this.EnableDisableUnbiasedPol);
            this.Controls.Add(this.EnableDisablePath);
            this.Controls.Add(this.EnableDisableGlobalHistory);
            this.Controls.Add(this.EnableDisableLocalHistory);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TraceEntriesCountTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TraceFileTextbox);
            this.Controls.Add(this.BranchPredictor);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LocalHistoryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalHistoryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PathUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnbiasedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BranchPredictor;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.TextBox TraceFileTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TraceEntriesCountTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.CheckBox EnableDisableLocalHistory;
        private System.Windows.Forms.CheckBox EnableDisableGlobalHistory;
        private System.Windows.Forms.CheckBox EnableDisablePath;
        private System.Windows.Forms.CheckBox EnableDisableUnbiasedPol;
        private System.Windows.Forms.NumericUpDown LocalHistoryUpDown;
        private System.Windows.Forms.NumericUpDown GlobalHistoryUpDown;
        private System.Windows.Forms.NumericUpDown PathUpDown;
        private System.Windows.Forms.NumericUpDown UnbiasedUpDown;
    }
}

