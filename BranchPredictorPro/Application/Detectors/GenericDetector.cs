using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchPredictorPro.Application.Interfaces;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.Application.Detectors
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
                              TraceName = initModel.TraceName
                          };
        }
    }
}
