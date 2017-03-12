namespace WebSite.Web.Controllers
{
    using System.Web.Mvc;
    using Services;

    public class AboutController : Controller
    {
        readonly AllItemsService allItemsService = new AllItemsService();
        
        public ActionResult TeamMembers()
        {
            var members = this.allItemsService.AllMembers();

            return View(members);
        }
    }
}