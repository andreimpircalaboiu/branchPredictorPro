using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchPredictorPro.Application.Interfaces;
using BranchPredictorPro.Application.Tables;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.Application.Detectors
{
    public class GlobalDetector : GenericDetector, IDetector
    {
        public void InitTable()
        {
            Table = new GlobalHistoryTable(DetectorModel);
        }

        public ResultModel RunDetector(InitModel initModel)
        {
            InitDetectorModels(initModel);
            InitTable();
            AddRowsToTable(initModel);
            return ResultModel;
        }

        private void AddRowsToTable(InitModel initModel)
        {
            foreach (var entry in initModel.TraceEntries)
            {
                Table.AddRow(entry);
            }
        }
    }
}
