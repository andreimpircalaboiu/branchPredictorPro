using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchPredictorPro.Models
{
    public enum DetectionType
    {
        None = 0,
        Global = 1,
        Local = 2,
        Path = 4,
        GlobalLocal = 3,
        GlobalPath = 5,
        LocalPath = 6,
        GlobalLocalPath = 7
    }
}
