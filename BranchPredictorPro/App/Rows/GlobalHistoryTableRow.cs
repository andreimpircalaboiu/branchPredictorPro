using System;

namespace BranchPredictorPro.App.Rows
{
    public class GlobalHistoryTableRow
    {
        public long Address { get;set; }
        public long Destination { get; set; }

        public long ProgramCounter { get; set; }

        public int NumberOfTimesReached { get; set; }

        public int NumberOfTimesNotReached { get; set; }

        public long Hrg { get; set; }

        public int LeastRecentlyUsed { get; set; }

        public GlobalHistoryTableRow()
        {
            LeastRecentlyUsed = 0;
        }

        public void SetHappens(bool happens)
        {
            if (happens)
            {
                NumberOfTimesReached++;
            }
            else
            {
                NumberOfTimesNotReached++;
            }
        }
    }

}

