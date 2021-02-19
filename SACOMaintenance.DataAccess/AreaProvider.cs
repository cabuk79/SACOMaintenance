using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
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
                new Area
                {
                    AreaName = area.AreaName,
                    CommentsNotes = area.CommentsNotes,
                    FactoryId = area.FactoryId
                }
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

        public void UpdateArea(Area area)
        {
            var areaToUpdate = SacoMaintenanceContext.Areas.FirstOrDefault(i => i.Id == area.Id);
            areaToUpdate.AreaName = area.AreaName;
            SacoMaintenanceContext.SaveChanges();
        }
    }
}
