namespace SACOMaintenance.Common.ModelDB
{
    public class MaintRequestInitiationRisk
    {
        public int MaintRequestInitiationId { get; set; }
        public int RisksId { get; set; }
        public string RiskLevel { get; set; } //H = High, M = Medium, L = Low
    }
}
