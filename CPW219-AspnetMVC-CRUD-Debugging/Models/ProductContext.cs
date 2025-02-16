using Microsoft.EntityFrameworkCore;

namespace CPW219_AspnetMVC_CRUD_Debugging.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        /// <summary>
        /// This is how the database is being created and its connection string
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The desired name for the database
            // Server = The server we are connecting to. LocalDB is included with Visual Studio
            // Trusted_Connection = True means we are using Windows Authentication
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CPW219CoreWithBugs;Trusted_Connection=True;");

        }
        /// <summary>
        public DbSet<Product> Product { get; set; }
    }
}
