using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models.DTO
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }


        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
    }
}
