using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IUsers
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<IEnumerable<MaintRequestInitiation>> GetUsersForMaintReq(int MaintId);
        Task<IEnumerable<User>> GetUsersByDepartment(int departmentId);
    }
}
