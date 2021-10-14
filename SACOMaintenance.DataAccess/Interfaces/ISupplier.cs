using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface ISupplier
    {
        Task<IEnumerable<Supplier>> LoadAllSuppliers();
        Task<IEnumerable<PostCodeTown>> LoadAllPostCodes();
        Task<PostCodeTown> GetPostCode(string postCode);
        Task<PostCodeTown> LoadPostCodesByRef(string postCode);
        Task<Supplier> LoadSingleSupplier(int Id);
        public void AddNewSupplier(Supplier supplier);
        public void UpdateSupplier(Supplier supplier);
    }
}
