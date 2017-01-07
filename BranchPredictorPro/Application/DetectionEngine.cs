using BranchPredictorPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BranchPredictorPro.Application.Interfaces;

namespace BranchPredictorPro.Application
{
    public class DetectionEngine
    {
        private Thread _engineThread;
        private bool _done;
        private readonly IDetectorFactory _detectorFactory;
        public ResultModel Result { get; set; }

        public DetectionEngine(InitModel initModel)
        {
            _engineThread = new Thread(() => StartDetection(initModel));
            _detectorFactory = new DetectorFactory();
        }

        private void StartDetection(InitModel initModel)
        {
            var detector = _detectorFactory.Generate(initModel.DetectionType);
            if (detector == null) return;
            Result = detector.RunDetector(initModel);
        }
    }
}
