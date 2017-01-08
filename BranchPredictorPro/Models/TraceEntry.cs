using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchPredictorPro.Constants;

namespace BranchPredictorPro.Models
{
    public class TraceEntry
    {
        public TraceEntry(string tipBr, string adrCrt, string adrDest)
        {
            TipBrString = tipBr;
            CurrentAddress = adrCrt;
            DestinationAddress = adrDest;
        }
        public string TipBrString { get; }
        public string CurrentAddress { get; }
        public string DestinationAddress { get; }

        public bool Happens => TipBrString[0] == 'B';

        public BrType TipBr
        {
            get
            {
                switch (TipBrString[1])
                {
                    case 'T':
                        {
                            return BrType.ConditionedJump;
                        }
                    case 'F':
                        {
                            return BrType.ConditionedJump;
                        }
                    case 'S':
                        {
                            return BrType.Call;
                        }
                    case 'M':
                        {
                            return BrType.Return;
                        }
                    case 'R':
                        {
                            return BrType.UnconditionedJump;
                        }
                    default:
                        {
                            throw new Exception("wrong brType");
                        }
                }
            }
        }

        public long CurrentAddressLong => Convert.ToInt64(CurrentAddress);
        public long DestinationAddressLong => Convert.ToInt64(DestinationAddress);
    }
}
