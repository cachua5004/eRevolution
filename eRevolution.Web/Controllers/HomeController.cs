using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace eRevolution.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : eRevolutionControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}