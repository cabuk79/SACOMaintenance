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
        ISupplier SupplierDataProvider { get; }

        public OrderViewModel(IOrder orderDataProvider, ISupplier supplierDataProvider)
        {
            OrderDataProvider = orderDataProvider;
            SupplierDataProvider = supplierDataProvider;
        }

        public ObservableCollection<Order> Orders { get; } = new();
        public ObservableCollection<Supplier> Suppliers { get; } = new();

        public async void LoadAllOrders()
        {
            var orderLists = new ObservableCollection<Order>(await OrderDataProvider.LoadAllOrders());
            Orders.Clear();

            foreach(var item in orderLists)
            {
                Orders.Add(item);
            }    
        }

        public async Task LoadSuppliers()
        {
            var suppliersList = new ObservableCollection<Supplier>(await SupplierDataProvider.LoadAllSuppliers());
            Suppliers.Clear();

            foreach(var item in suppliersList)
            {
                Suppliers.Add(item);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
