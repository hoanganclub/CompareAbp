using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Haha.Controllers
{
    public abstract class HahaControllerBase: AbpController
    {
        protected HahaControllerBase()
        {
            LocalizationSourceName = HahaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
