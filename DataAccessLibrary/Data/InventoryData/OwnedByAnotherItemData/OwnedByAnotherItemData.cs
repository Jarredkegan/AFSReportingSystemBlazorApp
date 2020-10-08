using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.InventoryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.InventoryData.OwnedByAnotherItemData
{
    public class OwnedByAnotherItemData : IOwnedByAnotherItemData
    {
        private readonly ISqlDataAccess _db;

        public OwnedByAnotherItemData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<OwnedByAnotherItemModel>> GetAllReports()
        {
            string sql = "select * from dbo.OwnedByAnotherItemReports";

            return _db.LoadData<OwnedByAnotherItemModel, dynamic>(sql, new { });
        }

        public Task<List<OwnedByAnotherItemModel>> GetActiveReports()
        {
            string sql = "select * from dbo.OwnedByAnotherItemReports where Complete = 0";

            return _db.LoadData<OwnedByAnotherItemModel, dynamic>(sql, new { });
        }

        public Task InsertReport(OwnedByAnotherItemModel report)
        {
            string sql = @"insert into dbo.OwnedByAnotherItemReports (Department, Slot, Comments, Date, Complete)
                            values (@Department, @Slot, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, report);
        }

        public Task UpdateReport(OwnedByAnotherItemModel report)
        {
            string sql = @"update dbo.OwnedByAnotherItemReports set Department = @Department, Slot = @Slot, Comments = @Comments, Date = @Date;";

            return _db.SaveData(sql, report);
        }

        public Task DeleteReport(int Id)
        {
            string sql = @"delete from dbo.OwnedByAnotherItemReports where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteOwnedByAnotherItemReport(OwnedByAnotherItemModel report)
        {
            report.Complete = true;
            string sql = @"update dbo.OwnedByAnotherItemReports set Complete = @Complete where Id = " + report.Id;
            return _db.SaveData(sql, report);
        }
    }
}
