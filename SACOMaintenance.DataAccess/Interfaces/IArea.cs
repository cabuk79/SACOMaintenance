using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IArea
    {
        IEnumerable<AreaModel> LoadAllAreas();
        IEnumerable<AreaModel> LoadAreasByFactory(int factoryId);
        AreaModel LoadSingleArea(int Id);
        AreaModel FindAreaByName(string areaName);
        void UpdateArea(AreaModel area);
        void AddEditArea(AreaModel area);
    }
}
