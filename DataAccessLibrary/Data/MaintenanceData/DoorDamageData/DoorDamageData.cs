using System;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.MaintenanceModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.MaintenanceData
{
    public class DoorDamageData : IDoorDamageData
    {
        private readonly ISqlDataAccess _db;

        public DoorDamageData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<DoorDamageModel>> GetAllReports()
        {
            string sql = "select * from dbo.DoorDamage";

            return _db.LoadData<DoorDamageModel, dynamic>(sql, new { });
        }

        public Task<List<DoorDamageModel>> GetActiveReports()
        {
            string sql = "select * from dbo.DoorDamage where Complete = 0";

            return _db.LoadData<DoorDamageModel, dynamic>(sql, new { });
        }

        public Task InsertReport(DoorDamageModel report)
        {
            string sql = @"insert into dbo.DoorDamage (Department, Door, Comments, Date, Complete)
                            values (@Department, @Door, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, report);
        }

        public Task UpdateReport(DoorDamageModel report)
        {
            string sql = @"update dbo.DoorDamage set Department = @Department, Door = @Door, Comments = @Comments, Date = @Date;";

            return _db.SaveData(sql, report);
        }

        public Task DeleteReport(int Id)
        {
            string sql = @"delete from dbo.DoorDamage where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteRackDamage(DoorDamageModel report)
        {
            report.Complete = true;
            string sql = @"update dbo.DoorDamage set Complete = @Complete where Id = " + report.Id;
            return _db.SaveData(sql, report);
        }
    }
}
