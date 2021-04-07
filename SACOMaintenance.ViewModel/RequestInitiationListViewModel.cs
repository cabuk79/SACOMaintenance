using ExcelLibs;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SACOMaintenance.ViewModel
{
    public class RequestInitiationListViewModel : INotifyPropertyChanged, IRequestInitiationListViewModel
    {

        public Status currentStatus { get; set; } = new();
        public IEnumerable<MaintRequestInitiation> filteredMaintRequests { get; set; }
        public ObservableCollection<Status> statusList { get; set; } = new();

        public ObservableCollection<MaintRequestInitiation> requests { get; } = new();

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

        public void LoadRequests()
        {
            var maintReqList = MaintReqDataProvider.LoadRequestInitiationWithEquipment();
            requests.Clear();

            foreach(var item in maintReqList)
            {
                requests.Add(item);
            }

            var statusLists = StatusDataProvider.LoadAllStatuses();
            
            foreach(var statusItem in statusLists)
            {
                statusList.Add(statusItem);
            }
        }

        

        public void LoadReqsByStatusId(int statusId)
        {
            var maintReqList = MaintReqDataProvider.LoadReqBasedOnStatus(statusId);
            requests.Clear();

            foreach(var item in maintReqList)
            {
                requests.Add(item);
            }
        }

        public void LoadNewRequests()
        {
            var maintNewreq = MaintReqDataProvider.LoadNewRequests();
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
