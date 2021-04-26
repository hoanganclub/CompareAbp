using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Haha.Configuration;
using Haha.Web;

namespace Haha.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HahaDbContextFactory : IDesignTimeDbContextFactory<HahaDbContext>
    {
        public HahaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HahaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HahaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HahaConsts.ConnectionStringName));

            return new HahaDbContext(builder.Options);
        }
    }
}
