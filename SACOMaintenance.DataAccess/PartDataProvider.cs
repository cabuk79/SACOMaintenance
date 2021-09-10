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
    public class PartDataProvider : IPart
    {
        public readonly SACOMaintenanceContext _sacoMaintenanceContext;

        public PartDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _sacoMaintenanceContext = sacoMaintenanceContext;
        }

        public Part GetSinglePartAndSuppliers(int Id)
        {
            var singlePart = _sacoMaintenanceContext.Parts
                .Where(i => i.Id == Id)
                .Include(s => s.SupplierParts)
                .Include(d => d.Drawings)
                .FirstOrDefault();
            return singlePart;
        }

        public IEnumerable<Supplier> LoadAllSuppliers()
        {
            var suppliers = _sacoMaintenanceContext.Suppliers.ToList();
            return suppliers;
        }

        public IEnumerable<Part> LoadAllPArts()
        {
            var parts = _sacoMaintenanceContext.Parts.ToList();
            return parts;
        }
    }
}
