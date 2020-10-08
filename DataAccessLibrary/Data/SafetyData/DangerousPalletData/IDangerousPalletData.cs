using DataAccessLibrary.Models.SafetyModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SafetyData
{
    public interface IDangerousPalletData
    {
        Task CompleteRackDamage(DangerousPalletModel report);
        Task DeleteReport(int Id);
        Task<List<DangerousPalletModel>> GetActiveReports();
        Task<List<DangerousPalletModel>> GetAllReports();
        Task InsertReport(DangerousPalletModel report);
        Task UpdateReport(DangerousPalletModel report);
    }
}