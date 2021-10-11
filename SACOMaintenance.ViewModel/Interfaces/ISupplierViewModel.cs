using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface ISupplierViewModel
    {
        ObservableCollection<Supplier> suppliers { get; set; }
        public void postcodefound(string value, string newEdit);
        public void UpdateSupplier();
        Task<ObservableCollection<Supplier>> LoadAllSuppliers();
        public void CreateEmptySupplier();
        public void AddNewSupplier();
        //public void LoadAllPostCodes();
        //public void LoadPostCodesByRef();
        //public void LoadPostCodesByRef(string postCodeString);
        //public ISupplier SupplierDataProvider { get; }
        public void GetSingleSupplier(int Id);
        public Supplier SelectedSupplier { get; set; }
        public Supplier NewSupplier { get;  set; }
    }
}
