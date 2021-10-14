using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class CompanyDataProvider : ICompany
    {
        private readonly SACOMaintenanceContext _companyDBContext;

        public CompanyDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _companyDBContext = sacoMaintenanceContext;
        }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public async Task<IEnumerable<Company>> LoadCompanies()
        {
            var companies = await _companyDBContext.Companies.ToListAsync();
            return companies;
        }

        public async Task<Company> LoadSingleCompany(int Id)
        {
            var company = await _companyDBContext.Companies
                .Where(i => i.Id == Id)
                .Include(c => c.MaintenanceRequestIniations)
                .ThenInclude(a => a.Area)
                .Include(f => f.MaintenanceRequestIniations).ThenInclude(f => f.Factory)
                .FirstOrDefaultAsync();
            return company;
        }

        public void SaveEditArea(Company company)
        {
            _companyDBContext.Companies.Add
            (
                new Company { CompanyName = company.CompanyName }
            );
            _companyDBContext.SaveChanges();
        }
    }
}
