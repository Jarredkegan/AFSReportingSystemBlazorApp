using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.SanitationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SanitationData.CardboardRequestData
{
    public class CardboardRequestData : ICardboardRequestData
    {
        private readonly ISqlDataAccess _db;

        public CardboardRequestData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CardboardRequestModel>> GetAllCardboardRequests()
        {
            string sql = "select * from dbo.CardboardRequest";

            return _db.LoadData<CardboardRequestModel, dynamic>(sql, new { });
        }

        public Task<List<CardboardRequestModel>> GetActiveCardboardRequests()
        {
            string sql = "select * from dbo.CardboardRequest where Complete = 0";

            return _db.LoadData<CardboardRequestModel, dynamic>(sql, new { });
        }

        public Task InsertRequest(CardboardRequestModel cardboard)
        {
            string sql = @"insert into dbo.CardboardRequest (Department, Dock, Comments, Date, Complete)
                        values (@Department, @Dock, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, cardboard);
        }

        public Task UpdateSpill(CardboardRequestModel cardboard)
        {
            string sql = @"update dbo.CardboardRequest set Department = @Department, Dock = @Dock, Comments = @comments, Date = @Date;";

            return _db.SaveData(sql, cardboard);
        }

        public Task DeleteCardboardRequest(int Id)
        {
            string sql = @"delete from dbo.CardboardRequest where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteCardboardRequest(CardboardRequestModel request)
        {
            request.Complete = true;
            string sql = @"update dbo.CardboardRequest set Complete = @Complete where Id = " + request.Id;
            return _db.SaveData(sql, request);
        }
    }
}
