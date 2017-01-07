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

        private int _cacheEntriesCount;
        public int CacheEntriesCount
        {
            get { return _cacheEntriesCount; }
            set { SetField(ref _cacheEntriesCount, value); }
        }

        private IList<TraceEntry> _traceEntries;
        public IList<TraceEntry> TraceEntries
        {
            get { return _traceEntries; }
            set
            {
                _traceEntries = value;
                TracesCount = _traceEntries.Count;
            }
        }
        public ArchitectureType ArchitectureType { get; set; }
        public int BitsNumber { get; set; }

        private int _tracesCount;
        public int TracesCount
        {
            get { return _tracesCount; }
            set { SetField(ref _tracesCount, value); }
        }

        public int LocalHistory { get; set; }
        public int GlobalHistory { get; set; }
        public int Path { get; set; }
        public bool UnbiasesPolarization { get; set; }
    }
}
