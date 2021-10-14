using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class DepartmentDataProvider : IDepartment
    {
        private readonly SACOMaintenanceContext _sacoMaintenanceContext;
        public DepartmentDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _sacoMaintenanceContext = sacoMaintenanceContext;
        }

        public async Task<IEnumerable<Department>> LoadAllDepartments()
        {
            var departments = await _sacoMaintenanceContext.Departments.ToListAsync();
            return departments;
        }

        public async Task<Department> LoadSingleDepartment(int Id)
        {
            var department = await _sacoMaintenanceContext.Departments.FirstOrDefaultAsync(d => d.Id == Id);
            return department;
        }
    }
}
