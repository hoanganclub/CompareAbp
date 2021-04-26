using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Haha.EntityFrameworkCore;
using Haha.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Haha.Web.Tests
{
    [DependsOn(
        typeof(HahaWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HahaWebTestModule : AbpModule
    {
        public HahaWebTestModule(HahaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HahaWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HahaWebMvcModule).Assembly);
        }
    }
}