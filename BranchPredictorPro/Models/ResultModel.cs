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
        public string UnbiasedContext { get; set; }

        public string Print() {

            return "Trace:                 " + TraceName + Environment.NewLine +
                   "Type:                  " + TypeName + Environment.NewLine +
                   "Hrl bits:              " + LocalHistoryBits + Environment.NewLine +
                   "Hrg bits:              " + GlobalHistoryBits + Environment.NewLine +
                   "Path bits:             " + PathBits + Environment.NewLine +
                   "Unbiased Contexts:     " + UnbiasedContext + Environment.NewLine;

        }
    }
}
