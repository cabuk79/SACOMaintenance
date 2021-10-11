using SACOMaintenance.Common.ModelDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface ICompany
    {
        Task<List<Company>> LoadCompanies();
        Task<Company> LoadSingleCompany(int Id);
        void SaveEditArea(Company company);
    }
}
