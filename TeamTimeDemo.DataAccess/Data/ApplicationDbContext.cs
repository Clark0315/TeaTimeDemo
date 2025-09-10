using Microsoft.EntityFrameworkCore;
using TeaTimeDemo.Models;

namespace TeaTimeDemo.DataAccess.Data
{
    /// <summary>
    /// 繼承自 DbContext 的類別，屬於 Entity Framework Core 的一部分。它的主要用途是作為資料庫與應用程式之間的橋樑，負責：
    ///•	管理資料庫連線
    ///•	追蹤及儲存資料變更
    ///•	提供查詢與儲存資料的 API
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        /// <summary>
        /// 代表資料庫中的一個資料表。每個 DbSet 屬性都對應一個實體類別（例如 Category），讓你可以：
        ///•	查詢（如 LINQ 查詢）
        ///•	新增、修改、刪除資料
        /// Categories是類別，商品品項的資料庫實體列別
        /// </summary>
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
