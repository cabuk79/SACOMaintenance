using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;

namespace SACOMaintenance.ViewModel
{
    public class CompanyViewModel : INotifyPropertyChanged, ICompanyViewModel
    {
        public Company company { get; set; } = new();

        public ICompany CompanyDataProvider { get; }

        public CompanyViewModel(ICompany companyDataProvider)
        {
            CompanyDataProvider = companyDataProvider;
            LoadAllCompanies(); 
        }

        public ObservableCollection<Company> companies { get; set; } = new();
        public ObservableCollection<MaintRequestInitiation> maintRegs { get; set; } = new();

        public int CompanyId
        {
            get => company.Id;
            set
            {
                if(company.Id != value)
                {
                    company.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string CompanyName
        {
            get => company.CompanyName;
            set
            {
                if(company.CompanyName != value)
                {
                    company.CompanyName = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler Propertychanged;

        public void AddNewCompany(Company company)
        {
            
        }

        public async void LoadAllCompanies()
        {
            var companyList = new ObservableCollection<Company>(await CompanyDataProvider.LoadCompanies());
            companies.Clear();

            foreach (var companyItem in companyList)
            {
                companies.Add(companyItem);
            }
        }

        public async Task<Company> LoadSingleCompany(int CompanyId)
        {
            company = await CompanyDataProvider.LoadSingleCompany(CompanyId);
            maintRegs = new ObservableCollection<MaintRequestInitiation>(company.MaintenanceRequestIniations);
            return company;
        }

        public void UpdateCompany(Company company)
        {
            throw new NotImplementedException();
        }

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
