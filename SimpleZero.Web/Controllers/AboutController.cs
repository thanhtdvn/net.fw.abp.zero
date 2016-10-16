using System.Web.Mvc;

namespace SimpleZero.Web.Controllers
{
    public class AboutController : SimpleZeroControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}