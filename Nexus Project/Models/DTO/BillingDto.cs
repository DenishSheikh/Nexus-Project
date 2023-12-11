using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models.DTO
{
    public class BillingDto
    {
        public Guid BillingId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
    }
}
