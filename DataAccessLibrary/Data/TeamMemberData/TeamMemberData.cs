using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.TeamMemberData
{
    public class TeamMemberData : ITeamMemberData
    {
        private readonly ISqlDataAccess _db;

        public TeamMemberData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TeamMemberModel>> GetTeamMembers()
        {
            string sql = "select * from dbo.TeamMembers";

            return _db.LoadData<TeamMemberModel, dynamic>(sql, new { });
        }

        public Task InsertTeamMember(TeamMemberModel teamMember)
        {
            string sql = @"insert into dbo.TeamMembers (FirstName, LastName)
                            values (@FirstName, @LastName);";

            return _db.SaveData(sql, teamMember);
        }

        public Task UpdateTeamMember(TeamMemberModel teamMember)
        {
            string sql = @"update dbo.TeamMembers set FirstName = @FirstName, LastName = @LastName;";

            return _db.SaveData(sql, teamMember);
        }

        public Task DeleteTeamMember(TeamMemberModel teamMember)
        {
            string sql = @"delete from dbo.TeamMembers where FirstName = @FirstName and LastName = @LastName";

            return _db.SaveData(sql, teamMember);
        }
    }
}
