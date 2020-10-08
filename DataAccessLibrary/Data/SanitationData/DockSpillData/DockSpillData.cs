using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.SanitationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SanitationData.DockSpillData
{
    public class DockSpillData : IDockSpillData
    {
        private readonly ISqlDataAccess _db;

        public DockSpillData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<DockSpillModel>> GetAllSpills()
        {
            string sql = "select * from dbo.DockSpills";

            return _db.LoadData<DockSpillModel, dynamic>(sql, new { });
        }

        public Task<List<DockSpillModel>> GetActiveSpills()
        {
            //select all spills that are NOT complete
            string sql = "select * from dbo.DockSpills where Complete = 0";

            return _db.LoadData<DockSpillModel, dynamic>(sql, new { });
        }

        public Task InsertSpill(DockSpillModel spill)
        {
            string sql = @"insert into dbo.DockSpills (Department, Dock, WetSpill, Glass, Scrubber, Comments, Date, Complete)
                            values (@Department, @Dock, @WetSpill, @Glass, @Scrubber, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, spill);
        }

        public Task UpdateSpill(DockSpillModel spill)
        {
            string sql = @"update dbo.DockSpills set Department = @Department, Dock = @Dock, WetSpill = @WetSpill, Glass = @Glass, Scrubber = @Scrubber, Comments = @comments, Date = @Date;";

            return _db.SaveData(sql, spill);
        }

        public Task DeleteDockSpill(int Id)
        {
            string sql = @"delete from dbo.DockSpills where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteDockSpill(DockSpillModel spill)
        {
            spill.Complete = true;
            string sql = @"update dbo.DockSpills set Complete = @Complete where Id = " + spill.Id;
            return _db.SaveData(sql, spill);
        }
    }
}
