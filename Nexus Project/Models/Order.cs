﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nexus_Project.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int PlanId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }


    }

}
