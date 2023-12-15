using Microsoft.EntityFrameworkCore;

namespace Nexus_Project.Models
{
    public class Applicationdbcontext : DbContext
    {
        //internal readonly object billing;

        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> options):base(options)
        {

        }
               public DbSet<Payment> Payment { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<ConnectionPlan> ConnectionPlan { get; set; }
               public DbSet<Customer> Customer { get; set; }
        public DbSet<ProductEquipment> ProductEquipment { get; set; }
        public DbSet<Order> Order { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<Employee> Employees { get; set; }




    }

 
}
