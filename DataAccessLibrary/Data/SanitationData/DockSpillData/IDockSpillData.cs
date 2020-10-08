using DataAccessLibrary.Models.SanitationModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SanitationData.DockSpillData
{
    public interface IDockSpillData
    {
        Task CompleteDockSpill(DockSpillModel spill);
        Task DeleteDockSpill(int Id);
        Task<List<DockSpillModel>> GetAllSpills();
        Task<List<DockSpillModel>> GetActiveSpills();
        Task InsertSpill(DockSpillModel spill);
        Task UpdateSpill(DockSpillModel spill);
    }
}