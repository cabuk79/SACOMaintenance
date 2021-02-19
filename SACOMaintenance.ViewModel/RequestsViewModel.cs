using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel
{
    public class RequestsViewModel : INotifyPropertyChanged
    {
        private readonly IMaintRequestInitiation maintReqDataProvider;

        public ObservableCollection<MaintRequestInitiation> MaintRequestsList { get; } = new();
       


        public RequestsViewModel(IMaintRequestInitiation MaintReqDataProvider)
        {
            maintReqDataProvider = MaintReqDataProvider;
        }

        public void Load()
        {
            var requestsList = maintReqDataProvider.LoadAllRequestInitations();
            
            foreach(var requestItem in requestsList)
            {
                MaintRequestsList.Add(requestItem);
            }
        }





        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
