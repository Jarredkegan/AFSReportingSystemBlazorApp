using DataAccessLibrary.Models.InventoryModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.InventoryData.OwnedByAnotherItemData
{
    public interface IOwnedByAnotherItemData
    {
        Task CompleteOwnedByAnotherItemReport(OwnedByAnotherItemModel report);
        Task DeleteReport(int Id);
        Task<List<OwnedByAnotherItemModel>> GetAllReports();
        Task<List<OwnedByAnotherItemModel>> GetActiveReports();
        Task InsertReport(OwnedByAnotherItemModel report);
        Task UpdateReport(OwnedByAnotherItemModel report);
    }
}