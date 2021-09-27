using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class MaintReqUptateNote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        [ForeignKey("Id")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        //public int MaintReqId { get; set; }
        //public virtual MaintRequestInitiation MaintRequestInitiation { get; set; }
    }
}
