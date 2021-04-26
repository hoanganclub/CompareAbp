using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Haha.Web.Views
{
    public abstract class HahaRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HahaRazorPage()
        {
            LocalizationSourceName = HahaConsts.LocalizationSourceName;
        }
    }
}
