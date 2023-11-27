﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nexus_Project.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Role { get; set; } // Admin, Accounts, Technical, Retail Outlet
        public string Username { get; set; }
        public string Password { get; set; }

    }

}
