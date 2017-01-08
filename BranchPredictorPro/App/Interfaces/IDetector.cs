using BranchPredictorPro.Models;

namespace BranchPredictorPro.App.Interfaces
{
    public interface IDetector
    {
        void InitTable();
        ResultModel RunDetector(InitModel initModel);
    }
}
