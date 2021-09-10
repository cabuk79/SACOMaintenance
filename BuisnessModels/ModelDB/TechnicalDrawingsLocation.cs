using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class TechnicalDrawingsLocation
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public string DrawingFileLocation { get; set; }
    }
}
