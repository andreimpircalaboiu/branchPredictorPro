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
            InitBindings();
        }

        private void InitBindings()
        {
            
            FormHelper.BindControlOnPropertyChanged(TraceEntriesCountTextbox, "Text", InitModel, "TracesCount");
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
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

        private void DirectMappingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InitModel.ArchitectureType = ArchitectureType.DirectMapping;
        }

        private void CompleteAssociativeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InitModel.ArchitectureType = ArchitectureType.CompleteAssociative;
        }

        private void EnableDisableLocalHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDisableLocalHistory.Checked)
            {
                LocalHistoryUpDown.Enabled = true;
            }
            else
            {
                LocalHistoryUpDown.Enabled = false;
            }
        }

        private void EnableDisableGlobalHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDisableGlobalHistory.Checked)
            {
                GlobalHistoryUpDown.Enabled = true;
            }
            else
            {
                GlobalHistoryUpDown.Enabled = false;
            }
        }

        private void EnableDisablePath_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDisablePath.Checked)
            {
                PathUpDown.Enabled = true;
            }
            else
            {
                PathUpDown.Enabled = false;
            }
        }

        private void EnableDisableUnbiasedPol_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableDisableUnbiasedPol.Checked)
            {
                UnbiasedUpDown.Enabled = true;
            }
            else
            {
                UnbiasedUpDown.Enabled = false;
            }
        }

        private void LocalHistoryUpDown_ValueChanged(object sender, EventArgs e)
        {
            InitModel.LocalHistory = (int)LocalHistoryUpDown.Value;
        }

        private void GlobalHistoryUpDown_ValueChanged(object sender, EventArgs e)
        {
            InitModel.GlobalHistory = (int)GlobalHistoryUpDown.Value;
        }

        private void PathUpDown_ValueChanged(object sender, EventArgs e)
        {
            InitModel.Path = (int)PathUpDown.Value;
        }

        private void UnbiasedUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (UnbiasedUpDown.Value==0)
            {
                InitModel.UnbiasesPolarization = true;
            }
            else
            {
                InitModel.UnbiasesPolarization = false;
            }
        }
    }
}
