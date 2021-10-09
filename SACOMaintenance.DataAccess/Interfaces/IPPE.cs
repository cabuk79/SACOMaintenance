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
        Task<List<PPE>> LoadAllPPE();
        Task<List<PPE>> LoadAllPlantPPE(string ppeTypeName);
        void SaveAddPPE(PPE ppe);
        Task<PPE> ViewSinglePPEI(int Id);
    }
}
