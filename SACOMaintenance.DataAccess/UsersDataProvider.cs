using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;

namespace SACOMaintenance.DataAccess
{
    public class UsersDataProvider : IUsers
    {
        private readonly SACOMaintenanceContext _usersContext;
        public UsersDataProvider(SACOMaintenanceContext usersContext)
        {
            _usersContext = usersContext;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var allUsers = await _usersContext.Users.ToListAsync();
            return allUsers;
        }

        public async Task<IEnumerable<User>> GetUsersByDepartment(int departmentId)
        {
            var returnUsers =
                await _usersContext.Users
                .Where(d => d.DepartmentId == departmentId)
                .ToListAsync();           
            
            return returnUsers;
        }

        public async Task<IEnumerable<MaintRequestInitiation>> GetUsersForMaintReq(int MaintId)
        {
            var requestUsers =
                await _usersContext.MaintRequestInitiations
                .Include(u => u.Users)
                .Where(i => i.Id == MaintId)
                .ToListAsync();

            return requestUsers;
        }
    }
}
