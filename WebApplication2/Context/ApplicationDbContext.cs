using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class ApplicationDbContext : DbContext
    {
        private DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
        //{
        //    optionsBuilder.UseSqlServer(
        //        @"Data Source=.;Initial Catalog=ICodeNext;Integrated Security=True;Trust Server Certificate=True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.FirstName)
                .HasMaxLength(150).IsRequired();
        }
    }
}
