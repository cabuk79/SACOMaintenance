using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IDepartment
    {
        Task<List<Department>> LoadAllDepartments();
        Task<Department> LoadSingleDepartment(int Id);
    }
}
