using ExcelLibs;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SACOMaintenance.ViewModel
{
    public class RequestInitiationListViewModel : INotifyPropertyChanged, IRequestInitiationListViewModel
    {
        public ObservableCollection<MaintRequestInitiation> requests { get; } = new();

        public ObservableCollection<Equipment> equipment { get; } = new();

        public IMaintRequestInitiation MaintReqDataProvider { get; }
     
        public RequestInitiationListViewModel(IMaintRequestInitiation maintReqDataProvider)
        {
            MaintReqDataProvider = maintReqDataProvider;
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
