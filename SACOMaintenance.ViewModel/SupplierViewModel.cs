using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SACOMaintenance.ViewModel
{
    public class SupplierViewModel : INotifyPropertyChanged, ISupplierViewModel
    {
        public ObservableCollection<Supplier> suppliers { get; set; } = new();
        public Supplier SelectedSupplier { get; set; }
        
        public ISupplier SupplierDataProvider { get; }

        public SupplierViewModel(ISupplier supplierDataProvider)
        {
            SupplierDataProvider = supplierDataProvider;
        }


        public void LoadAllSuppliers()
        {
            var suppliersList = SupplierDataProvider.LoadAllSuppliers();
            suppliers.Clear();

            foreach (var supplierItem in suppliersList)
            {
                suppliers.Add(supplierItem);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void GetSingleSupplier(int Id)
        {
            SelectedSupplier = SupplierDataProvider.LoadSingleSupplier(Id);

        }
    }
}
