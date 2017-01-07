using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchPredictorPro.Models
{
    public class DetectorModel
    {
        public DetectorModel(InitModel initModel)
        {
            InitModel = initModel;
            TableEntries = 256;
            GlobalHistoryEntries = 0;
            LocalHistoryEntries = 0;
            PathEntries = 0;
            PcBits = 8;
            LruBits = 8;
            AutomationBits = 1;
        }

        public InitModel InitModel { get; private set; }

        public int TableEntries { get; set; } 

        private int GlobalHistoryEntries { get; set; } 

        public int LocalHistoryEntries { get; set; } 

        public int PathEntries { get; set; } 
        
        public int PcBits { get; set; }

        public int LruBits { get; set; }

        public int AutomationBits { get; set; }
    }
}
