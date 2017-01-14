using System.Globalization;
using BranchPredictorPro.App.Interfaces;
using BranchPredictorPro.App.Tables;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.App.Detectors
{
    public class LocalDetetor : GenericDetector, IDetector
    {
        public void InitTable()
        {
            Table = new LocalHistoryTable(DetectorModel);
        }

        public ResultModel RunDetector(InitModel initModel)
        {
            InitDetectorModels(initModel);
            InitTable();
            AddRowsToTable(initModel);
            ResultModel.UnbiasedContext = Table.GetUnbiasedRatio().ToString(CultureInfo.InvariantCulture);
            return ResultModel;
        }
    }
}
