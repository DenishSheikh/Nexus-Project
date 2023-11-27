using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nexus_Project.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
    }

}
