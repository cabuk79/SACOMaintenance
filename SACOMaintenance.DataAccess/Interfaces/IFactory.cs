using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IFactory
    {
        IEnumerable<Factory> LoadAllFactories();
        Factory ViewSingleFactory(int Id);
        void AddEditFactory(Factory factory);
    }
}
