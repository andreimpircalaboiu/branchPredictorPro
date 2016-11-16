using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchPredictorPro.Models;

namespace BranchPredictorPro.Import
{
    public class TraceParser
    {
        public TraceParser(IList<string> paramStringTraceEntries)
        {
            var stringTraceEntries = paramStringTraceEntries;
            TraceEntries = new List<TraceEntry>();
            if (paramStringTraceEntries == null)
            {
                stringTraceEntries = new List<string>();
            }
            Parse(stringTraceEntries);
        }

        private void Parse(IList<string> stringTraceEntries)
        {
            foreach (var stringTraceEntry in stringTraceEntries)
            {
                var splitString = stringTraceEntry.Split(' ');
                var traceEntry = new TraceEntry(splitString[0], splitString[1], splitString[2]);
                TraceEntries.Add(traceEntry);
            }
        }

        public IList<TraceEntry> TraceEntries { get; }
    }
}
