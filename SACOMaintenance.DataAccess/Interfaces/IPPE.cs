using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IPPE
    {
        Task<IEnumerable<PPE>> LoadAllPPE();
        Task<IEnumerable<PPE>> LoadAllPlantPPE(string ppeTypeName);
        void SaveAddPPE(PPE ppe);
        Task<PPE> ViewSinglePPEI(int Id);
    }
}
