using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface ICompany
    {
        IEnumerable<Company> LoadCompanies();
        void LoadSingleCompany(int Id);
        void SaveEditArea(Company company);
    }
}
