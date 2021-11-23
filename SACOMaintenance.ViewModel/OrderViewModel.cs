﻿using SACOMaintenance.Common.ModelDB;
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
        IDepartment DepartmentDataProvider { get; }

        public OrderViewModel(IOrder orderDataProvider, ISupplier supplierDataProvider, IDepartment departmentDataProvider)
        {
            OrderDataProvider = orderDataProvider;
            SupplierDataProvider = supplierDataProvider;
            DepartmentDataProvider = departmentDataProvider;
        }

        public ObservableCollection<Order> Orders { get; } = new();
        public ObservableCollection<Supplier> Suppliers { get; } = new();
        public ObservableCollection<Department> Departments { get; } = new();

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

        public async Task LoadDepartments()
        {
            var departmentList = new ObservableCollection<Department>(await DepartmentDataProvider.LoadAllDepartments());
            Departments.Clear();

            foreach(var item in departmentList)
            {
                Departments.Add(item);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
