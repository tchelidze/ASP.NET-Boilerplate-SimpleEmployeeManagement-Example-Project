using System.Web.Mvc;

namespace SimpleEmployeeManagement.Web.Controllers
{
    public class AboutController : SimpleEmployeeManagementControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}