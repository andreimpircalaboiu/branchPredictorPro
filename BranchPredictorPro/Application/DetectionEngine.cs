using BranchPredictorPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BranchPredictorPro.Application
{
    public class DetectionEngine
    {
        private Thread _engineThread;
        private bool _done;

        public DetectionEngine(InitModel initModel)
        {
            _engineThread = new Thread(() => StartDetection(initModel));
        }

        private void StartDetection(InitModel initModel)
        {
            switch(initModel.DetectionType)
            {
                case DetectionType.None:
                    break;
                case DetectionType.Global:
                    break;
                case DetectionType.Local:
                    break;
                case DetectionType.Path:
                    break;
                case DetectionType.GlobalLocal:
                {
                    
                }
                    break;
                case DetectionType.GlobalPath:
                    break;
                case DetectionType.LocalPath:
                    break;
                case DetectionType.GlobalLocalPath:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
