using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.MaintenanceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.MaintenanceData.RedDoorServiceData
{
    public class RedDoorServiceData : IRedDoorServiceData
    {
        private readonly ISqlDataAccess _db;

        public RedDoorServiceData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<RedDoorServiceModel>> GetAllReports()
        {
            string sql = "select * from dbo.RedDoorService";

            return _db.LoadData<RedDoorServiceModel, dynamic>(sql, new { });
        }

        public Task<List<RedDoorServiceModel>> GetActiveReports()
        {
            string sql = "select * from dbo.RedDoorService where Complete = 0";

            return _db.LoadData<RedDoorServiceModel, dynamic>(sql, new { });
        }

        public Task InsertReport(RedDoorServiceModel report)
        {
            string sql = @"insert into dbo.RedDoorService (Location, Comments, Date, Complete)
                            values (@Location, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, report);
        }

        public Task UpdateReport(RedDoorServiceModel report)
        {
            string sql = @"update dbo.RedDoorService set Location = @Location, Comments = @Comments, Date = @Date;";

            return _db.SaveData(sql, report);
        }

        public Task DeleteReport(int Id)
        {
            string sql = @"delete from dbo.RedDoorService where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteRedDoorService(RedDoorServiceModel report)
        {
            report.Complete = true;
            string sql = @"update dbo.RedDoorService set Complete = @Complete where Id = " + report.Id;
            return _db.SaveData(sql, report);
        }
    }
}
