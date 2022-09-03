using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClientService.Repository.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder
                .UseSqlServer("Data Source=DESKTOP-GGHN154\\SQLEXPRESS;Initial Catalog=BDClient;Integrated Security=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
