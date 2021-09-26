using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<Company> LoadCompanies()
        {
            var companies = _companyDBContext.Companies.ToList();
            return companies;
        }

        public Company LoadSingleCompany(int Id)
        {
            var company = _companyDBContext.Companies
                .Where(i => i.Id == Id)
                .Include(c => c.MaintenanceRequestIniations)
                .ThenInclude(a => a.Area)
                .Include(f => f.MaintenanceRequestIniations).ThenInclude(f => f.Factory)
                .FirstOrDefault();
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
