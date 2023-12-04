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
        public Roles RolesId { get; set; } // Admin, Accounts, Technical, Retail Outlet
        public string Username { get; set; }
        public string Password { get; set; }

    }

}
