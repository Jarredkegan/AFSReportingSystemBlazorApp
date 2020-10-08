using DataAccessLibrary.Models.MaintenanceModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.MaintenanceData.RedDoorServiceData
{
    public interface IRedDoorServiceData
    {
        Task CompleteRedDoorService(RedDoorServiceModel report);
        Task DeleteReport(int Id);
        Task<List<RedDoorServiceModel>> GetActiveReports();
        Task<List<RedDoorServiceModel>> GetAllReports();
        Task InsertReport(RedDoorServiceModel report);
        Task UpdateReport(RedDoorServiceModel report);
    }
}