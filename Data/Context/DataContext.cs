
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SerialComPort.Model;

namespace SerialComPort.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DataContext()
        {
            
        }
        public class BloggingContextFactory : IDesignTimeDbContextFactory<DataContext>
        {
            public DataContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
                optionsBuilder.UseSqlite("Data Source=SerialPort.db");

                return new DataContext(optionsBuilder.Options);
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=SerialPort.db");
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ConnectionLog> ConnectionLogs { get; set; }
        public DbSet<Ports> Ports { get; set; }
    }
}
