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
        Task<List<Part>> LoadAllPArts();
        Task<Part> GetSinglePartAndSuppliers(int Id);
        Task<List<Supplier>> LoadAllSuppliers();
    }
}
