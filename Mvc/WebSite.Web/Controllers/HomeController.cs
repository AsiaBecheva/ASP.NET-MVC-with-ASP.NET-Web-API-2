namespace WebSite.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Data.Repository;
    using Data.Repository.Interfaces;
    using WebSite.Models;
    using Models;

    public class HomeController : Controller
    {
        IUnitOfWork db = new UnitOfWork();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult News()
        {
            var result = db.ArticleRepo
                .Get()
                .Take(3)
                .ToList();

            return View(result);
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult TeamMembers()
        {
            var result = db.TeamMemberRepo
                .Get()
                .OrderBy(x => x.EmployedOn)
                .ToList();

            return View(result);
        }

        [HttpGet]
        public ActionResult Email()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Email(EmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var email = new Email()
                {
                    Company = model.Company,
                    Message = model.Message,
                    Name = model.Name,
                    Phone = model.Phone,
                    Subject = model.Subject,
                    Url = model.Url
                };

                db.EmailRepo.Insert(email);
                db.SaveChanges();
            }

            return View(model);
        }
    }
}