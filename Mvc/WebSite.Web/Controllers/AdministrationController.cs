namespace WebSite.Web.Controllers
{
    using System.Web.Mvc;
    using System.Linq;

    [Authorize(Roles = "Administrator")]
    public class AdministrationController : Controller
    {
        // GET: Administration
        public ActionResult Index()
        {
            return View("_AdministrationLayout");
        }
    }
}