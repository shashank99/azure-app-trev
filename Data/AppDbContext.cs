using Microsoft.EntityFrameworkCore;

namespace azure_app_trev.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:az-webapp-server-shashank.database.windows.net,1433;Initial Catalog=azure-webapp-db1;Persist Security Info=False;User ID=shashank;Password=Malliswari12024!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        { 
        
        
        }

        public DbSet<Person> Persons { get; set; }
    }
}
