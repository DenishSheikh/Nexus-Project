using Microsoft.EntityFrameworkCore;

namespace Nexus_Project.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
    }

}
