using System.Threading;
using System.Windows.Forms;
using BranchPredictorPro.App.Interfaces;
using BranchPredictorPro.Models;
using BranchPredictorPro.Presentation;

namespace BranchPredictorPro.App
{
    public class DetectionEngine
    {
        private readonly MainForm _form;
        private Thread _engineThread;
        private bool _done;
        private readonly IDetectorFactory _detectorFactory;
        public ResultModel Result { get; set; }

        public DetectionEngine(InitModel initModel, MainForm form)
        {
            _form = form;
            _engineThread = new Thread(() => StartDetection(initModel));
            _detectorFactory = new DetectorFactory();
            _engineThread.Start();
        }

        private void StartDetection(InitModel initModel)
        {
            var detector = _detectorFactory.Generate(initModel.DetectionType);
            if (detector == null) return;
            Result = detector.RunDetector(initModel);
            _form.Invoke((MethodInvoker)delegate {
                _form.OutputText.Text = Result.Print();
            });
            
        }
    }
}
