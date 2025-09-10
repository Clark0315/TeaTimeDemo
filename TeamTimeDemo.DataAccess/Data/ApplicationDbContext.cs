using Microsoft.EntityFrameworkCore;
using TeamTimeDemo.Models;

namespace TeamTimeDemo.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Green Tea", DisplayOrder = 1, Description = "Refreshing and light." },
                new Category { Id = 2, Name = "Black Tea", DisplayOrder = 2, Description = "Strong and bold." },
                new Category { Id = 3, Name = "Herbal Tea", DisplayOrder = 3, Description = "Caffeine-free and soothing." }
            );
        }
    }
}
