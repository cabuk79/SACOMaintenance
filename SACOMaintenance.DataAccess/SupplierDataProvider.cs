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

        public PostCodeTown LoadPostCodesByRef(string postCode)
        {
            var postCodes = _sacoMaintenanceContext.PostCodeTowns
                .Where(pc => pc.PostCode == postCode).FirstOrDefault();
            return postCodes;
        }

        public async Task<List<Supplier>> LoadAllSuppliers()
        {
            var suppliers = await _sacoMaintenanceContext.Suppliers.ToListAsync();
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

        public PostCodeTown GetPostCode(string postCode)
        {
            var singlePostCode = _sacoMaintenanceContext.PostCodeTowns.Where(code => code.PostCode == postCode).FirstOrDefault();
            return singlePostCode;
        }

        public async Task<List<PostCodeTown>> LoadAllPostCodes()
        {
            throw new NotImplementedException();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _sacoMaintenanceContext.Update<Supplier>(supplier);
            _sacoMaintenanceContext.SaveChanges();
        }

        public void AddNewSupplier(Supplier supplier)
        {
            _sacoMaintenanceContext.Add<Supplier>(supplier);
            _sacoMaintenanceContext.SaveChanges();
        }
    }
}
