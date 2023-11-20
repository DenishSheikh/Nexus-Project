namespace Nexus_Project.Models
{
    public class Billing
    {
        public int BillingId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
    }
}
