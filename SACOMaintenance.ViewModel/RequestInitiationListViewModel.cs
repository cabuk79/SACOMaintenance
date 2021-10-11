using ExcelLibs;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace SACOMaintenance.ViewModel
{
    public class RequestInitiationListViewModel : INotifyPropertyChanged, IRequestInitiationListViewModel
    {

        public Status currentStatus { get; set; } = new();
        public IEnumerable<MaintRequestInitiation> filteredMaintRequests { get; set; }
        public ObservableCollection<Status> statusList { get; set; } = new();

        public ObservableCollection<MaintRequestInitiation> requests { get; set; } = new();

        public ObservableCollection<Equipment> equipment { get; } = new();

        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public int StatusId
        {
            get => currentStatus.Id;
            set
            {
                if(currentStatus.Id != value)
                {
                    currentStatus.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public IStatus StatusDataProvider;
     
        public RequestInitiationListViewModel(IMaintRequestInitiation maintReqDataProvider, IStatus statusDataProvider)
        {
            MaintReqDataProvider = maintReqDataProvider;
            StatusDataProvider = statusDataProvider;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void LoadRequests()
        {
            
            var items = new ObservableCollection<MaintRequestInitiation>
                (await MaintReqDataProvider.LoadRequestInitiationWithEquipment());
            requests.Clear();


            foreach (var item in items)
            {
                requests.Add(item);
            }

            var statusLists = new ObservableCollection<Status>(await StatusDataProvider.LoadAllStatuses());
            
            foreach(var statusItem in statusLists)
            {
                statusList.Add(statusItem);
            }
        }

        

        public async void LoadReqsByStatusId(int statusId)
        {
            var maintReqList = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadReqBasedOnStatus(statusId));
            requests.Clear();

            foreach(var item in maintReqList)
            {
                requests.Add(item);
            }
        }

        public async void LoadNewRequests()
        {
            var maintNewreq = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadNewRequests());
            requests.Clear();

            foreach(var item in maintNewreq)
            {
                requests.Add(item);
            }
        }

        public void ExportList()
        {
            MaintenanceRequestsExcel exportReqList = new MaintenanceRequestsExcel();
            exportReqList.ExportListToExcel(requests);
        }

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
