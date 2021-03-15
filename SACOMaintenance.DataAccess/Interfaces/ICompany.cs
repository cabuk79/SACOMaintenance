using SACOMaintenance.Common.ModelDB;
using System.Collections.Generic;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface ICompany
    {
        IEnumerable<Company> LoadCompanies();
        Company LoadSingleCompany(int Id);
        void SaveEditArea(Company company);
    }
}
