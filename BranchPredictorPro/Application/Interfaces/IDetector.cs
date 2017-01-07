﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.Application.Interfaces
{
    public interface IDetector
    {
        void InitTable();
        ResultModel RunDetector(InitModel initModel);
    }
}
