using DataAccessLibrary.Models.SafetyModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SafetyData.LooseProductData
{
    public interface ILooseProductData
    {
        Task CompleteLooseProduct(LooseProductModel report);
        Task DeleteReport(int Id);
        Task<List<LooseProductModel>> GetActiveReports();
        Task<List<LooseProductModel>> GetAllReports();
        Task InsertReport(LooseProductModel report);
        Task UpdateReport(LooseProductModel report);
    }
}