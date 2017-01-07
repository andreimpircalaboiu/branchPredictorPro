using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchPredictorPro.Models
{
    public class ResultModel
    {
        public string TraceName { get; set;}
        public string TypeName { get; set; }
        public int GlobalHistoryBits { get; set; }
        public int LocalHistoryBits { get; set; }
        public int PathBits { get; set; }
        public double UnbiasedPolarization { get; set; }
        public string UnbiasedContext { get; }

        public string Print() {

            return "Trace:                 " + TraceName + "\n" +
                   "Type:                  " + TypeName + "\n" +
                   "Hrl:                   " + LocalHistoryBits + "\n" +
                   "Hrg:                   " + GlobalHistoryBits + "\n" +
                   "Path:                  " + PathBits + "\n" +
                   "Unbiased Polarization: " + UnbiasedPolarization + "\n" +
                   "Unbiased Context:      " + UnbiasedContext + "\n";






        }


    }
}
