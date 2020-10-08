using DataAccessLibrary.Models.MaintenanceModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.MaintenanceData
{
    public interface IRackDamageData
    {
        Task CompleteRackDamage(RackDamageModel report);
        Task DeleteReport(int Id);
        Task<List<RackDamageModel>> GetAllReports();
        Task<List<RackDamageModel>> GetActiveReports();
        Task InsertReport(RackDamageModel report);
        Task UpdateReport(RackDamageModel report);
    }
}