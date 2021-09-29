using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class GeneralRequest
    {
        public int Id { get; set; }
        public int MaintRequestId { get; set; } //FK to MaintRequestInitiation Id
        public virtual MaintRequestInitiation MaintRequestInitiation { get; set; }
        public int? AuthorityToWorkUserId { get; set; }
        public DateTime? AuthorityToWorkDateTime { get; set; }
        public string DetailOfWorkCompleted { get; set; }
        public int? DetailOfWorkCompeltedUserId { get; set; }
        public DateTime? DetailOfWorkCompeltedDateTime { get; set; }
        public int? WorkCompletedYesNo { get; set; }
        public string WorkCompletedDetails { get; set; }
        public string SignOffDetails { get; set; }
        public int? WorkCompletedSignOffYesNo { get; set; }
        public int? WorkCompletedSignOffUserId { get; set; }
        public int? WorkCompletedSignOffDateTime { get; set; }
        public string ControlMeasuresTaken { get; set; }
    }
}
