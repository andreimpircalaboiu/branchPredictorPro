using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BranchPredictorPro.Constants;
using BranchPredictorPro.Helpers;
using BranchPredictorPro.Import;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.Presentation
{
    public partial class MainForm : Form
    {
        public InitModel InitModel { get; set; }
        public MainForm()
        {
            InitializeComponent();
            InitModel = new InitModel();
            GlobalHistoryUpDown.Value = 8;
            LocalHistoryUpDown.Value = 8;
            PathUpDown.Value = 0;
            UnbiasedUpDown.Value = 0.95M;
            EnableDisableGlobalHistory.Checked = true;
            InitBindings();
        }

        private void InitBindings()
        {
            
            FormHelper.BindControlOnPropertyChanged(TraceEntriesCountTextbox, "Text", InitModel, "TracesCount");
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            TraceValidationMessage.Text = "";
            try
            {
                if (ImportFileDialog.ShowDialog(this) != DialogResult.OK) return;
                if (ImportFileDialog.FileName == null)
                {
                    MessageBox.Show(
                        @"No file selected",
                        "Import failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var extension = Path.GetExtension(ImportFileDialog.FileName).ToLower();
                if (extension != ".txt" && extension != ".tra")
                {
                    MessageBox.Show(
                        @"Extension provided is not .txt or .tra",
                        "Import failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                var lines = File.ReadLines(ImportFileDialog.FileName).ToList();
                var traceParser = new TraceParser(lines);
                InitModel.TraceEntries = traceParser.TraceEntries;
                TraceFileTextbox.Text = ImportFileDialog.FileName;
                InitModel.TraceName = TraceFileTextbox.Text;

            }
            catch (IOException)
            {
                MessageBox.Show(
                    @"Unable to open file, used by other process",
                    "Import failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    @"Unable to open file",
                    "Import failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void EnableDisableLocalHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDisableLocalHistory.Checked)
            {
                InitModel.DetectionType = InitModel.DetectionType + 2;
                LocalHistoryUpDown.Enabled = true;
            }
            else
            {
                InitModel.DetectionType = InitModel.DetectionType - 2;
                LocalHistoryUpDown.Enabled = false;
            }
            DetectionTypeLabel.Text = InitModel.DetectionType.ToString();
        }

        private void EnableDisableGlobalHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDisableGlobalHistory.Checked)
            {
                InitModel.DetectionType = InitModel.DetectionType + 1;
                GlobalHistoryUpDown.Enabled = true;
            }
            else
            {
                InitModel.DetectionType = InitModel.DetectionType - 1;
                GlobalHistoryUpDown.Enabled = false;
            }
            DetectionTypeLabel.Text = InitModel.DetectionType.ToString();
        }

        private void EnableDisablePath_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDisablePath.Checked)
            {
                InitModel.DetectionType = InitModel.DetectionType + 4;
                PathUpDown.Enabled = true;
            }
            else
            {
                InitModel.DetectionType = InitModel.DetectionType - 4;
                PathUpDown.Enabled = false;
            }
            DetectionTypeLabel.Text = InitModel.DetectionType.ToString();
        }

        private void LocalHistoryUpDown_ValueChanged(object sender, EventArgs e)
        {

            HrlValidationMessage.Text = "";
            InitModel.LocalHistoryBits = (int)LocalHistoryUpDown.Value;
        }

        private void GlobalHistoryUpDown_ValueChanged(object sender, EventArgs e)
        {
            HrGValidationMessage.Text = "";
            InitModel.GlobalHistoryBits = (int)GlobalHistoryUpDown.Value;
        }

        private void PathUpDown_ValueChanged(object sender, EventArgs e)
        {
            PathValidationMessage.Text = "";
            InitModel.PathBits = (int)PathUpDown.Value;
        }

        private void UnbiasedUpDown_ValueChanged(object sender, EventArgs e)
        {
            InitModel.UnbiasesPolarization = (double)UnbiasedUpDown.Value;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (InitModel.TraceEntries.Count==0)
            {
                TraceValidationMessage.Text = "Import Traces!";
            }


            if (LocalHistoryUpDown.Enabled || GlobalHistoryUpDown.Enabled || PathUpDown.Enabled)
            {
                if (LocalHistoryUpDown.Enabled && LocalHistoryUpDown.Value == 0)
                {
                    HrlValidationMessage.Text = "Local History must be bigger then 0!";
                }

                if (GlobalHistoryUpDown.Enabled && GlobalHistoryUpDown.Value == 0)
                {
                    HrGValidationMessage.Text = "Global History must be bigger then 0!";
                }

                if (PathUpDown.Enabled && PathUpDown.Value == 0)
                {
                    PathValidationMessage.Text = "Path must be bigger then 0!";
                }
            }
            else
            {
                MessageBox.Show("Please select at least one type of prediction!");
            }
           


        }
    }
}
