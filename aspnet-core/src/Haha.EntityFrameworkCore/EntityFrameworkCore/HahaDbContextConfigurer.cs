using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Haha.EntityFrameworkCore
{
    public static class HahaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HahaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HahaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
