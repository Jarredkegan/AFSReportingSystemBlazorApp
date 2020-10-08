using DataAccessLibrary.Models.SanitationModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SanitationData.AisleSpillData
{
    public interface ISpillData
    {
        Task DeleteSpill(int Id);
        Task CompleteAisleSpill(SpillModel spill);
        Task<List<SpillModel>> GetAllSpills();
        Task<List<SpillModel>> GetActiveSpills();
        Task InsertSpill(SpillModel spill);
        Task UpdateSpill(SpillModel spill);
    }
}