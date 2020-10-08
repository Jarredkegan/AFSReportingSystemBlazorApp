using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.TeamMemberData
{
    public interface ITeamMemberData
    {
        Task DeleteTeamMember(TeamMemberModel teamMember);
        Task<List<TeamMemberModel>> GetTeamMembers();
        Task InsertTeamMember(TeamMemberModel teamMember);
        Task UpdateTeamMember(TeamMemberModel teamMember);
    }
}