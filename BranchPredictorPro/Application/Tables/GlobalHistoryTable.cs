using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchPredictorPro.Application.Interfaces;
using BranchPredictorPro.Application.Rows;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.Application.Tables
{
    public class GlobalHistoryTable : ITable
    {
        private readonly DetectorModel _detectorModel;
        private int _tableHrg;
        private IList<GlobalHistoryTableRow> _rows;
        public GlobalHistoryTable(DetectorModel detectorModel)
        {
            _detectorModel = detectorModel;
            _tableHrg = 0;
            _rows = new List<GlobalHistoryTableRow>();
        }

        public void AddRow(TraceEntry entry)
        {
            
        }


        private GlobalHistoryTableRow MapTraceEntryToGlobalHistoryTableRow(TraceEntry entry)
        {
            var response = new GlobalHistoryTableRow();

            return response;
        }

        private long GetAddress(int programCounter)
        {
            return 1;
        }
        
    }
}
