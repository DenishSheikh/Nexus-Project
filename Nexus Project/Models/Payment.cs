﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models
{
    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; }
        public Customer Customer { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
    }

}
