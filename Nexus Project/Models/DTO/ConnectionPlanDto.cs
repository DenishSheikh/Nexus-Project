namespace Nexus_Project.Models.DTO
{
    public class ConnectionPlanDto
    {
        public Guid PlanId { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public decimal Charges { get; set; }
    }
}
