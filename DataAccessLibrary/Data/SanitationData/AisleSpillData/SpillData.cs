using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models.SanitationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data.SanitationData.AisleSpillData
{
    public class SpillData : ISpillData
    {
        private readonly ISqlDataAccess _db;

        public SpillData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<SpillModel>> GetAllSpills()
        {
            string sql = "select * from dbo.Spills";

            return _db.LoadData<SpillModel, dynamic>(sql, new { });
        }

        public Task<List<SpillModel>> GetActiveSpills()
        {
            string sql = "select * from dbo.Spills where Complete = 0";

            return _db.LoadData<SpillModel, dynamic>(sql, new { });
        }

        public Task InsertSpill(SpillModel spill)
        {
            string sql = @"insert into dbo.Spills (Department, Aisle, WetSpill, Glass, Scrubber, Comments, Date, Complete)
                            values (@Department, @Aisle, @WetSpill, @Glass, @Scrubber, @Comments, @Date, @Complete);";

            return _db.SaveData(sql, spill);
        }

        public Task UpdateSpill(SpillModel spill)
        {
            string sql = @"update dbo.Spills set Department = @Department, Aisle = @Aisle, WetSpill = @WetSpill, Glass = @Glass, Scrubber = @Scrubber, Comments = @comments, Date = @Date;";

            return _db.SaveData(sql, spill);
        }

        public Task DeleteSpill(int Id)
        {
            string sql = @"delete from dbo.Spills where Id = " + Id;

            return _db.SaveData(sql, Id);
        }

        public Task CompleteAisleSpill(SpillModel spill)
        {
            spill.Complete = true;
            string sql = @"update dbo.Spills set Complete = @Complete where Id = " + spill.Id;
            return _db.SaveData(sql, spill);
        }

    }
}
