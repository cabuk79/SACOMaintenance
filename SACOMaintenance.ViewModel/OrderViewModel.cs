using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
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
    public class OrderViewModel : INotifyPropertyChanged, IOrderViewModel
    {

        IOrder OrderDataProvider { get; }

        public OrderViewModel(IOrder orderDataProvider)
        {
            OrderDataProvider = orderDataProvider;
        }

        public ObservableCollection<Order> Orders { get; } = new();

        public void LoadAllOrders()
        {
            var orderLists = OrderDataProvider.LoadAllOrders();
            Orders.Clear();

            foreach(var item in orderLists)
            {
                Orders.Add(item);
            }    
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
