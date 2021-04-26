using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Haha.Controllers;

namespace Haha.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : HahaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
