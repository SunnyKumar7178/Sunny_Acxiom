using Microsoft.EntityFrameworkCore;
using Sunny_Acxiom.Models;

namespace Sunny_Acxiom.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers {  get; set; }
        public DbSet<Employee> Employees { get; set; }
        
    }
}
