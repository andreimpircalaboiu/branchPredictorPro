using System.Globalization;
using BranchPredictorPro.App.Interfaces;
using BranchPredictorPro.App.Tables;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.App.Detectors
{
    public class GlobalDetector : GenericDetector, IDetector
    {
        public void InitTable()
        {
            Table = new GlobalHistoryTable(DetectorModel);
        }

        public ResultModel RunDetector(InitModel initModel)
        {
            InitDetectorModels(initModel);
            InitTable();
            AddRowsToTable(initModel);
            ResultModel.UnbiasedContext = Table.GetUnbiasedRatio().ToString(CultureInfo.InvariantCulture);
            return ResultModel;
        }

        private void AddRowsToTable(InitModel initModel)
        {
            foreach (var entry in initModel.TraceEntries)
            {
                Table.AddRow(entry);
            }
        }
    }
}
