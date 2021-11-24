﻿using Microsoft.Extensions.Configuration;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel
{
    public class DashboardViewModel : INotifyPropertyChanged, IDashboardViewModel
    {
        public ObservableCollection<MaintRequestInitiation> MaintReqs { get; set; } = new();
        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public ObservableCollection<MaintRequestInitiation> MaintReqsAssignedOpen { get; set; } = new();
        public ObservableCollection<MaintRequestInitiation> MaintReqsNew { get; set; } = new();
        public ObservableCollection<MaintRequestInitiation> MaintReqCurrentYear { get; set; } = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public IConfiguration _config;
        public int yearStart { get; set; }



        public DashboardViewModel(IMaintRequestInitiation maintReqDataProvider, IConfiguration config)
        {
            MaintReqDataProvider = maintReqDataProvider;
            _config = config;
            yearStart =  Convert.ToInt32(_config["MaintenanceReqYearGraphStartDate"]);
            //LoadMaintReqs();
        }

        public async Task LoadMaintReqs()
        {
            MaintReqs.Clear();
            var list = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadAllRequestInitations());
            //MaintReqs = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadNewRequests());

            foreach (var item in list)
            {
                MaintReqs.Add(item);
            }
        }

        public async Task LoadNewReqs()
        {
            MaintReqsNew.Clear();
            var list = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadNewRequests());

            foreach (var item in list)
            {
                MaintReqsNew.Add(item);
            }
        }

        public async Task LoadAssignedOpenReqs()
        {
            MaintReqsAssignedOpen.Clear();
            var list = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadReqsAssignedOpen());

            foreach (var item in list)
            {
                MaintReqsAssignedOpen.Add(item);
            }
        }

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task LoadReqsCurrentYear()
        {
            var list = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadAllRequestsCurrentYear());
            MaintReqCurrentYear.Clear();

            foreach (var item in list)
            {
                MaintReqCurrentYear.Add(item);
            }
        }
    }
}
