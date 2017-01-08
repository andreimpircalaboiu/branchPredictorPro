using System;
using System.Collections.Generic;
using System.Linq;
using BranchPredictorPro.App.Interfaces;
using BranchPredictorPro.App.Rows;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.App.Tables
{
    public class GlobalHistoryTable : ITable
    {
        private readonly DetectorModel _detectorModel;
        private long _tableHrg;
        private readonly IList<GlobalHistoryTableRow> _rows;
        private int _numberOfBranches;
        public GlobalHistoryTable(DetectorModel detectorModel)
        {
            _detectorModel = detectorModel;
            _tableHrg = 0;
            _rows = new List<GlobalHistoryTableRow>();
        }

        public void AddRow(TraceEntry entry)
        {
            IncrementAge();
            var currentRow = MapTraceEntryToGlobalHistoryTableRow(entry);
            if (_detectorModel.GlobalHistoryEntries > (Math.Pow(2,_detectorModel.InitModel.GlobalHistoryBits) - 1))
            {
                RemoveLeastRecentlyUsedRow();
            }
            _tableHrg = SetNewHistory(_tableHrg, _detectorModel.InitModel.GlobalHistoryBits, entry.Happens);
            _numberOfBranches++;
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
            return sum * 1.0 / _numberOfBranches * 100.0 * Math.Pow(10.0, _detectorModel.InitModel.UnbiasesPolarization) / Math.Pow(10.0, _detectorModel.InitModel.UnbiasesPolarization);

        }
        public static long SetNewHistory(long hrg, int globalHistoryBits, bool happens)
        {
            var binaryHrg = Convert.ToString(hrg, 2);
            binaryHrg = happens ? binaryHrg + "1" : binaryHrg + "0";
            if (binaryHrg.Length > globalHistoryBits)
            {
                binaryHrg = binaryHrg.Substring(1);
            }
            return Convert.ToInt64(binaryHrg,2);
        }

        private void IncrementAge()
        {
            foreach (var row in _rows)
            {
                row.LeastRecentlyUsed++;
            }
        }

        private void RemoveLeastRecentlyUsedRow()
        {
            var leastRecentlyUsed = _rows.FirstOrDefault(i => i.LeastRecentlyUsed == _rows.Max(x => x.LeastRecentlyUsed));
            if (leastRecentlyUsed == null) return;
            _rows.Remove(leastRecentlyUsed);
        }


        private GlobalHistoryTableRow MapTraceEntryToGlobalHistoryTableRow(TraceEntry entry)
        {
            var address = GetAddress(entry.CurrentAddressLong);
            var response = _rows.FirstOrDefault(i => i.Address == address);
            if (response == null)
            {
                var newRow = new GlobalHistoryTableRow
                {
                    Destination = entry.DestinationAddressLong,
                    ProgramCounter = entry.CurrentAddressLong,
                    Hrg = _tableHrg,
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
                response.LeastRecentlyUsed = 0;
                response.SetHappens(entry.Happens);
            }
            return response;
        }

        private long GetAddress(long programCounter)
        {
            programCounter = programCounter * (long)Math.Pow(2, _detectorModel.InitModel.GlobalHistoryBits);
            programCounter = programCounter + _tableHrg;
            return programCounter;
        }

    }
}
