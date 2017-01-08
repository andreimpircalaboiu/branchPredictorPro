using BranchPredictorPro.App.Interfaces;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.App.Detectors
{
    public class GenericDetector
    {
        protected ResultModel ResultModel;
        protected DetectorModel DetectorModel;
        protected ITable Table;
        protected void InitDetectorModels(InitModel initModel)
        {
            DetectorModel = new DetectorModel(initModel);
            ResultModel = new ResultModel
                          {
                              GlobalHistoryBits = initModel.GlobalHistoryBits,
                              LocalHistoryBits = initModel.LocalHistoryBits,
                              PathBits = initModel.PathBits,
                              UnbiasedPolarization = initModel.UnbiasesPolarization,
                              TraceName = initModel.TraceName,
                              TypeName = initModel.DetectionType.ToString()
                          };
        }
    }
}
