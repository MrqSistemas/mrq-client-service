using Microsoft.EntityFrameworkCore;
using ClientService.Domain.Entities.Clients;

namespace ClientService.Repository.Context
{
    public class AppDbContext : DbContext
    {
        //TODO: Acertar para pegar do arquivo Json

        //public IConfiguration? Configuration { get; }

        //public AppDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public AppDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    if (!options.IsConfigured)
        //    {
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //           //.SetBasePath(Directory.GetCurrentDirectory())
        //           .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
        //           .AddJsonFile("appsettings.json")
        //           .Build();
        //        var connectionString = configuration.GetConnectionString("ShopConnection");
        //        options.UseSqlServer(connectionString);
        //    }
        //}

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Client>? Clients { get; set; }
    }
}
