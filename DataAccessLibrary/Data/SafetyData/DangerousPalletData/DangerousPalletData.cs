using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.SafetyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SafetyData
{
    public class DangerousPalletData : IDangerousPalletData
    {
        private readonly ISqlDataAccess _db;

        public DangerousPalletData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<DangerousPalletModel>> GetAllReports()
        {
            string sql = "select * from dbo.DangerousPallet";

            return _db.LoadData<DangerousPalletModel, dynamic>(sql, new { });
        }

        public Task<List<DangerousPalletModel>> GetActiveReports()
        {
            string sql = "select * from dbo.DangerousPallet where Complete = 0";

            return _db.LoadData<DangerousPalletModel, dynamic>(sql, new { });
        }

        public Task InsertReport(DangerousPalletModel report)
        {
            string sql = @"insert into dbo.DangerousPallet (Department, Slot, Comments, Date, Complete)
                            values (@Department, @Slot, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, report);
        }

        public Task UpdateReport(DangerousPalletModel report)
        {
            string sql = @"update dbo.DangerousPallet set Department = @Department, Slot = @Slot, Comments = @Comments, Date = @Date;";

            return _db.SaveData(sql, report);
        }

        public Task DeleteReport(int Id)
        {
            string sql = @"delete from dbo.DangerousPallet where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteRackDamage(DangerousPalletModel report)
        {
            report.Complete = true;
            string sql = @"update dbo.DangerousPallet set Complete = @Complete where Id = " + report.Id;
            return _db.SaveData(sql, report);
        }
    }
}
