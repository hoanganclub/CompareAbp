using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Haha.Authorization.Roles;
using Haha.Authorization.Users;
using Haha.MultiTenancy;

namespace Haha.EntityFrameworkCore
{
    public class HahaDbContext : AbpZeroDbContext<Tenant, Role, User, HahaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HahaDbContext(DbContextOptions<HahaDbContext> options)
            : base(options)
        {
        }
    }
}
