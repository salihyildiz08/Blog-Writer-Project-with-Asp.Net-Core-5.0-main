using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        public IEnumerable<object> Users;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-813UERA;database=CoreBlogApiDb;integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
        public IEnumerable<object> Writers { get; set; }
    }
}
