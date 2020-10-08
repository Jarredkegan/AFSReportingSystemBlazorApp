using DataAccessLibrary.Models.SanitationModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SanitationData.CardboardRequestData
{
    public interface ICardboardRequestData
    {
        Task CompleteCardboardRequest(CardboardRequestModel spill);
        Task DeleteCardboardRequest(int Id);
        Task<List<CardboardRequestModel>> GetAllCardboardRequests();
        Task<List<CardboardRequestModel>> GetActiveCardboardRequests();
        Task InsertRequest(CardboardRequestModel cardboard);
        Task UpdateSpill(CardboardRequestModel cardboard);
    }
}