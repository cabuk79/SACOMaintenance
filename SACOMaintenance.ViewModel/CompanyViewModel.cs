﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
            get => company.CompantName;
            set
            {
                if(company.CompantName != value)
                {
                    company.CompantName = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler Propertychanged;

        public void AddNewCompany(Company company)
        {
            
        }

        public void LoadAllCompanies()
        {
            var companyList = CompanyDataProvider.LoadCompanies();
            companies.Clear();

            foreach (var companyItem in companyList)
            {
                companies.Add(companyItem);
            }
        }

        public Company LoadSingleCompany(int CompanyId)
        {
            company = CompanyDataProvider.LoadSingleCompany(CompanyId);
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
