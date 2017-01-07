using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchPredictorPro.Models
{
    class ResultModel
    {
        public string TraceName { get; set;}
        public string TypeName { get; set; }
        public int Hrl { get; set; }
        public int Hrg { get; set; }
        public int Path { get; set; }
        public double UnbiasedPolarization { get; set; }
        public string UnbiasedContext { get; }

  

        public string print() {

            return "Trace:                 " + TraceName + "\n" +
                   "Type:                  " + TypeName + "\n" +
                   "Hrl:                   " + Hrl + "\n" +
                   "Hrg:                   " + Hrg + "\n" +
                   "Path:                  " + Path + "\n" +
                   "Unbiased Polarization: " + UnbiasedPolarization + "\n" +
                   "Unbiased Context:      " + UnbiasedContext + "\n";

        }


    }
}
