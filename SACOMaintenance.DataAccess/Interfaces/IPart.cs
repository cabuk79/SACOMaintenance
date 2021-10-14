using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IPart
    {
        Task<IEnumerable<Part>> LoadAllPArts();
        Task<Part> GetSinglePartAndSuppliers(int Id);
        Task<IEnumerable<Supplier>> LoadAllSuppliers();
    }
}
