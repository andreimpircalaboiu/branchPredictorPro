using BranchPredictorPro.Models;

namespace BranchPredictorPro.App.Interfaces
{
    public interface IDetectorFactory
    {
        IDetector Generate(DetectionType type);
    }
}
