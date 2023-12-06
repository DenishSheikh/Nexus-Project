using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
      
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Roles Roles { get; set; }

    }

}
