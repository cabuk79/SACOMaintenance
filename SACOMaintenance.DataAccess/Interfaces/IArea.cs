using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IArea
    {
        IEnumerable<Area> LoadAllAreas();
        Area LoadSingleArea(int Id);
        void AddEditArea(Area area);
        Area FindAreaByName(string areaName);
        void UpdateArea(Area area);
    }
}
