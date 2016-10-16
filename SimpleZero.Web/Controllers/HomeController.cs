using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SimpleZero.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SimpleZeroControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}