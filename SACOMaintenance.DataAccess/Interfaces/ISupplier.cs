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
        IEnumerable<Supplier> LoadAllSuppliers();
        IEnumerable<PostCodeTown> LoadAllPostCodes();
        public PostCodeTown GetPostCode(string postCode);
        public PostCodeTown LoadPostCodesByRef(string postCode);
        Supplier LoadSingleSupplier(int Id);
    }
}
