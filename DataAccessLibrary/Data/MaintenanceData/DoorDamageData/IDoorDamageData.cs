using DataAccessLibrary.Models.MaintenanceModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.MaintenanceData
{
    public interface IDoorDamageData
    {
        Task CompleteRackDamage(DoorDamageModel report);
        Task DeleteReport(int Id);
        Task<List<DoorDamageModel>> GetActiveReports();
        Task<List<DoorDamageModel>> GetAllReports();
        Task InsertReport(DoorDamageModel report);
        Task UpdateReport(DoorDamageModel report);
    }
}