using BranchPredictorPro.Models;

namespace BranchPredictorPro.App.Interfaces
{
    public interface ITable
    {
        void AddRow(TraceEntry entry);
        double GetUnbiasedRatio();
    }
}
