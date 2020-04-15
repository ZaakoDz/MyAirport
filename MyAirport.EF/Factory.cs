using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;
using ZW.MyAirport.EF;

namespace MyAirport.EF
{
    class MyAirportContextFactory : IDesignTimeDbContextFactory<MyAirportContext>
    {
        public MyAirportContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyAirportContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyAirportCodeFirst;Integrated Security=True");
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Debug)
                    .AddFilter("System", LogLevel.Warning);
            });
            optionsBuilder.UseLoggerFactory(loggerFactory);
            return new MyAirportContext(optionsBuilder.Options);
        }
    }
}
