using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchPredictorPro.App.Rows
{
    public class LocalHistoryTableRow
    {
        public long Address { get; set; }

        public long Destination { get; set; }

        public long ProgramCounter { get; set; }

        public int NumberOfTimesReached { get; set; }

        public int NumberOfTimesNotReached { get; set; }

        public long Hrl { get; set; }

        public int LeastRecentlyUsed { get; set; }

        public int LocalHistoryBits { get; set; }

        public LocalHistoryTableRow()
        {
            LeastRecentlyUsed = 0;
        }

        public void SetHappens(bool happens)
        {
            if (happens)
            {
                NumberOfTimesReached++;
                Hrl = Hrl * 2 + 1;
            }
            else
            {
                NumberOfTimesNotReached++;
                Hrl = Hrl * 2;
            }
            Hrl = Hrl % (long) Math.Pow(2, LocalHistoryBits);
        }
    }
}

