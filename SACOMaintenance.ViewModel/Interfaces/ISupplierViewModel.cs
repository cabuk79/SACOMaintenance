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
        public PostCodeTown postcodefound(string value);
        public void LoadAllSuppliers();
        //public void LoadAllPostCodes();
        //public void LoadPostCodesByRef();
        //public void LoadPostCodesByRef(string postCodeString);
        //public ISupplier SupplierDataProvider { get; }
        public void GetSingleSupplier(int Id);
        public Supplier SelectedSupplier { get; set; }
    }
}
