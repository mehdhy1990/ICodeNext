using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class ApplicationDbContext : DbContext
    {
        private DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ICodeNext;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
