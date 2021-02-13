using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SACOMaintenance.BuisnessModels;

namespace SACOMaintenance.DataAccess
{
    public class AreaProvider : IArea
    {
        public AreaProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditArea(Area area)
        {
            SacoMaintenanceContext.Areas.Add
            (
                new Area { AreaName = area.AreaName }
            );

            SacoMaintenanceContext.SaveChanges();
        }

        public Area FindAreaByName(string areaName)
        {
            var area = SacoMaintenanceContext.Areas.FirstOrDefault(n => n.AreaName == areaName);
            return area;
        }

        public IEnumerable<Area> LoadAllAreas()
        {
            var areas = SacoMaintenanceContext.Areas.ToList();
            return areas;
        }

        public Area LoadSingleArea(int Id)
        {
            var area = SacoMaintenanceContext.Areas.FirstOrDefault(i => i.Id == Id);
            return area;
        }

        
    }
}
