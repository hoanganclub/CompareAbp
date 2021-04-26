using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Haha.Authorization;

namespace Haha
{
    [DependsOn(
        typeof(HahaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HahaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HahaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HahaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
