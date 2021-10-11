using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel
{
    public class SupplierViewModel : INotifyPropertyChanged, ISupplierViewModel
    {
        public ObservableCollection<Supplier> suppliers { get; set; } = new();
        public Supplier SelectedSupplier { get; set; }
        
        
        public ISupplier SupplierDataProvider { get; }
        public ObservableCollection<PostCodeTown> postcodes { get; set; } = new();
        public Supplier NewSupplier { get;  set; }

        public SupplierViewModel(ISupplier supplierDataProvider)
        {
            SupplierDataProvider = supplierDataProvider;
        }


        public void CreateEmptySupplier()
        {
            NewSupplier = new();
            NewSupplier.Postcode = new();
        }

        public async Task<ObservableCollection<Supplier>> LoadAllSuppliers()
        {
            var suppliersList = new ObservableCollection<Supplier>(await SupplierDataProvider.LoadAllSuppliers());
            suppliers.Clear();

            foreach (var supplierItem in suppliersList)
            {
                suppliers.Add(supplierItem);
            }
            return suppliers;
        }

        public async void postcodefound (string value, string newEdit)
        {
           // var postcode = SupplierDataProvider.LoadPostCodesByRef(value);
            if(newEdit == "Edit")
            {
                SelectedSupplier.Postcode = await SupplierDataProvider.GetPostCode(value);
                if (SelectedSupplier.Postcode == null) { SelectedSupplier.Postcode = new PostCodeTown(); }
            }
            else if(newEdit == "New")
            {
                NewSupplier.Postcode = await SupplierDataProvider.GetPostCode(value);
                if (NewSupplier.Postcode == null) { NewSupplier.Postcode = new PostCodeTown(); }
            }
            
            //return postcode;
        }

      
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void GetSingleSupplier(int Id)
        {
            SelectedSupplier = await SupplierDataProvider .LoadSingleSupplier(Id);

        }

        public void UpdateSupplier()
        {
            SupplierDataProvider.UpdateSupplier(SelectedSupplier);
        }

        public void AddNewSupplier()
        {
            SupplierDataProvider.AddNewSupplier(NewSupplier);
        }
    }
}
