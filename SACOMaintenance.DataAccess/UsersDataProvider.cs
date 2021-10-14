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
    }
}
