using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class PPEDataProvider : IPPE
    {
        public IEnumerable<PPE> LoadAllPPE()
        {
            throw new NotImplementedException();
        }

        public void SaveAddPPE(PPE ppe)
        {
            throw new NotImplementedException();
        }

        public void ViewSinglePPEI(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
