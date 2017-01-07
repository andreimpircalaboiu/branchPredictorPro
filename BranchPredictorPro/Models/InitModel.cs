using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchPredictorPro.Constants;

namespace BranchPredictorPro.Models
{
    public class InitModel : BaseModel
    {
        public InitModel()
        {
            TraceEntries = new List<TraceEntry>();
        }

        private IList<TraceEntry> _traceEntries;
        private int _tracesCount;

        public IList<TraceEntry> TraceEntries
        {
            get { return _traceEntries; }
            set
            {
                _traceEntries = value;
                TracesCount = _traceEntries.Count;
            }
        }

        public int TracesCount
        {
            get { return _tracesCount; }
            set { SetField(ref _tracesCount, value); }
        }

        public int LocalHistoryBits { get; set; }
        public int GlobalHistoryBits { get; set; }
        public int PathBits { get; set; }
        public double UnbiasesPolarization { get; set; }
        public DetectionType DetectionType { get; set; }
        public string TraceName { get; set; }
    }
}
