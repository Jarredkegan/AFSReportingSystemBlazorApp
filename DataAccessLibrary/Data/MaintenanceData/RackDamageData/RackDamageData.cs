using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.MaintenanceModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.MaintenanceData
{
    public class RackDamageData : IRackDamageData
    {
        private readonly ISqlDataAccess _db;

        public RackDamageData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<RackDamageModel>> GetAllReports()
        {
            string sql = "select * from dbo.RackDamage";

            return _db.LoadData<RackDamageModel, dynamic>(sql, new { });
        }

        public Task<List<RackDamageModel>> GetActiveReports()
        {
            string sql = "select * from dbo.RackDamage where Complete = 0";

            return _db.LoadData<RackDamageModel, dynamic>(sql, new { });
        }

        public Task InsertReport(RackDamageModel report)
        {
            string sql = @"insert into dbo.RackDamage (Department, Slot, Comments, Date, Complete)
                            values (@Department, @Slot, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, report);
        }

        public Task UpdateReport(RackDamageModel report)
        {
            string sql = @"update dbo.RackDamage set Department = @Department, Slot = @Slot, Comments = @Comments, Date = @Date;";

            return _db.SaveData(sql, report);
        }

        public Task DeleteReport(int Id)
        {
            string sql = @"delete from dbo.RackDamage where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteRackDamage(RackDamageModel report)
        {
            report.Complete = true;
            string sql = @"update dbo.RackDamage set Complete = @Complete where Id = " + report.Id;
            return _db.SaveData(sql, report);
        }
    }
}
