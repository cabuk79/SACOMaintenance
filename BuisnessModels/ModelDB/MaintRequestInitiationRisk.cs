namespace SACOMaintenance.Common.ModelDB
{
    public class MaintRequestInitiationRisk
    {
        public int MaintRequestInitiationId { get; set; }

        public int RiskId { get; set; }

        public bool H { get; set; }
        public bool M { get; set; }
        public bool L { get; set; }

        //public string RiskLevel { get; set; } //H = High, M = Medium, L = Low

        //public virtual MaintRequestInitiation MaintRequestInitiation { get; set; }
        //public virtual Risk Risk { get; set; }
    }
}
