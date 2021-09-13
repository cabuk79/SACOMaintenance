using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface ICompanyViewModel
    {
        #region Properties
        public Company company { get; set; }
        ICompany CompanyDataProvider { get; }
        ObservableCollection<Company> companies { get; set; }
        ObservableCollection<MaintRequestInitiation> maintRegs { get; set; }
        public int CompanyId { get; }
        public string CompanyName { get; set; }
        #endregion
         
        
        #region Methods
        void AddNewCompany(Company company);
        void LoadAllCompanies();
        Company LoadSingleCompany(int CompanyId);
        void UpdateCompany(Company company);
        #endregion

        event PropertyChangedEventHandler Propertychanged;
    }
}
