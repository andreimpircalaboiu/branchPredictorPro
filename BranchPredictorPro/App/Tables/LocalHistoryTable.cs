using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchPredictorPro.App.Interfaces;
using BranchPredictorPro.App.Rows;
using BranchPredictorPro.Models;
namespace BranchPredictorPro.App.Tables
{
    public class LocalHistoryTable : ITable
    {
        private readonly DetectorModel _detectorModel;
        private readonly IList<LocalHistoryTableRow> _rows;
        private IList<Tuple<long, long>> _hrlList;
        private int _numberOfBranches;
        public LocalHistoryTable(DetectorModel detectorModel)
        {
            _detectorModel = detectorModel;
            _rows = new List<LocalHistoryTableRow>();
            _hrlList = new List<Tuple<long, long>>();
            foreach (var item in _rows)
            {
                item.LocalHistoryBits = detectorModel.InitModel.LocalHistoryBits;
            }
        }

        public void AddRow(TraceEntry entry)
        {
            IncrementAge();
            long currentHrl = 0;
            var currentHrlTuple = _hrlList.FirstOrDefault(i => i.Item1 == entry.CurrentAddressLong);
            if (currentHrlTuple != null)
            {
                currentHrl = currentHrlTuple.Item2;
            }
            var currentRow = MapTraceEntryToLocalHistoryTableRow(entry, currentHrl);
            if (_numberOfBranches > (Math.Pow(2, _detectorModel.InitModel.LocalHistoryBits) - 1))
            {
                //RemoveLeastRecentlyUsedRow();
            }
            _numberOfBranches++;
        }

        private void IncrementAge()
        {
            foreach (var row in _rows)
            {
                row.LeastRecentlyUsed++;
            }
        }

        private LocalHistoryTableRow MapTraceEntryToLocalHistoryTableRow(TraceEntry entry, long currentHrl)
        {
            var address = GetAddress(entry.CurrentAddressLong, currentHrl);
            var response = _rows.FirstOrDefault(i => i.Address == address);
            if (response == null)
            {
                var newRow = new LocalHistoryTableRow
                {
                    Destination = entry.DestinationAddressLong,
                    ProgramCounter = entry.CurrentAddressLong,
                    Hrl = currentHrl,
                    LeastRecentlyUsed = 0,
                    Address = address
                };
                newRow.SetHappens(entry.Happens);
                _rows.Add(newRow);
                _detectorModel.GlobalHistoryEntries++;
                response = newRow;
            }
            else
            {
                response.Hrl = currentHrl;
                response.LeastRecentlyUsed = 0;
                response.SetHappens(entry.Happens);
            }
            return response;
        }

        public double GetUnbiasedRatio()
        {
            double sum = 0;
            foreach (var row in _rows)
            {
                var max = Math.Max(row.NumberOfTimesReached / (row.NumberOfTimesReached + (double)row.NumberOfTimesNotReached), row.NumberOfTimesNotReached / (row.NumberOfTimesReached + (double)row.NumberOfTimesNotReached));
                if (max <= 0.95)
                    sum = sum + row.NumberOfTimesReached + row.NumberOfTimesNotReached;
            }
            return sum*1.0/_numberOfBranches;

        }

        private long GetAddress(long address, long currentHrl)
        {
            return 0;
        }
        
    }
}
