using System;
using BranchPredictorPro.App.Detectors;
using BranchPredictorPro.App.Interfaces;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.App
{
    public class DetectorFactory : IDetectorFactory
    {
        public IDetector Generate(DetectionType type)
        {
            switch (type)
            {
                case DetectionType.None:
                    break;
                case DetectionType.Global:
                    return new GlobalDetector();
                case DetectionType.Local:
                    break;
                case DetectionType.Path:
                    break;
                case DetectionType.GlobalLocal:
                    return new GlobalLocalDetector();
                case DetectionType.GlobalPath:
                    break;
                case DetectionType.LocalPath:
                    break;
                case DetectionType.GlobalLocalPath:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            return null;
        }
    }
}
