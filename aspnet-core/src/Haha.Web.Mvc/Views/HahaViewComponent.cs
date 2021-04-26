using Abp.AspNetCore.Mvc.ViewComponents;

namespace Haha.Web.Views
{
    public abstract class HahaViewComponent : AbpViewComponent
    {
        protected HahaViewComponent()
        {
            LocalizationSourceName = HahaConsts.LocalizationSourceName;
        }
    }
}
