using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.SafetyModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SafetyData.LooseProductData
{
    public class LooseProductData : ILooseProductData
    {
        private readonly ISqlDataAccess _db;

        public LooseProductData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<LooseProductModel>> GetAllReports()
        {
            string sql = "select * from dbo.LooseProduct";

            return _db.LoadData<LooseProductModel, dynamic>(sql, new { });
        }

        public Task<List<LooseProductModel>> GetActiveReports()
        {
            string sql = "select * from dbo.LooseProduct where Complete = 0";

            return _db.LoadData<LooseProductModel, dynamic>(sql, new { });
        }

        public Task InsertReport(LooseProductModel report)
        {
            string sql = @"insert into dbo.LooseProduct (Department, Slot, Comments, Date, Complete)
                            values (@Department, @Slot, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, report);
        }

        public Task UpdateReport(LooseProductModel report)
        {
            string sql = @"update dbo.LooseProduct set Department = @Department, Slot = @Slot, Comments = @Comments, Date = @Date;";

            return _db.SaveData(sql, report);
        }

        public Task DeleteReport(int Id)
        {
            string sql = @"delete from dbo.LooseProduct where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteLooseProduct(LooseProductModel report)
        {
            report.Complete = true;
            string sql = @"update dbo.LooseProduct set Complete = @Complete where Id = " + report.Id;
            return _db.SaveData(sql, report);
        }
    }
}
