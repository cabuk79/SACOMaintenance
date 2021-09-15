using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class SupplierDataProvider : ISupplier
    {
        public readonly SACOMaintenanceContext _sacoMaintenanceContext;

        public SupplierDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _sacoMaintenanceContext = sacoMaintenanceContext;
        }

        

        public IEnumerable<Supplier> LoadAllSuppliers()
        {
            var suppliers = _sacoMaintenanceContext.Suppliers.ToList();
            return suppliers;
        }

        public Supplier LoadSingleSupplier(int Id)
        {
            var singleSupplier = _sacoMaintenanceContext.Suppliers
                .Where(i => i.Id == Id)
                .Include(sp => sp.SupplierParts)
                .Include(pc => pc.Postcode)
                .FirstOrDefault();
            
            return singleSupplier;
        }
    }
}
