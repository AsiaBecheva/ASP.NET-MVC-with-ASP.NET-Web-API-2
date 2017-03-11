namespace WebSite.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Data.Repository;
    using Data.Repository.Interfaces;

    public class AboutController : Controller
    {
        IUnitOfWork db = new UnitOfWork();
        
        public ActionResult TeamMembers()
        {
            var result = db.TeamMemberRepo
                .Get()
                .OrderBy(x => x.EmployedOn)
                .ToList();

            return View(result);
        }
    }
}