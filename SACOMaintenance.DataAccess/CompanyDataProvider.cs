using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class CompanyDataProvider : ICompany
    {
        public CompanyDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public IEnumerable<Company> LoadCompanies()
        {
            var companies = SacoMaintenanceContext.Companies.ToList();
            return companies;
        }

        public Company LoadSingleCompany(int Id)
        {
            var company = SacoMaintenanceContext.Companies.FirstOrDefault(i => i.Id == Id);
            return company;
        }

        public void SaveEditArea(Company company)
        {
            SacoMaintenanceContext.Companies.Add
            (
                new Company { CompantName = company.CompantName }
            );
        }
    }
}
