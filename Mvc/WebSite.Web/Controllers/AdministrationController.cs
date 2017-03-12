namespace WebSite.Web.Controllers
{
    using System.Web.Mvc;
    using System.Linq;
    using WebSite.Models;
    using System.Collections.Generic;
    using Models;
    using Data.Repository.Interfaces;
    using Data.Repository;
    using Services;

    [Authorize(Roles = "Administrator")]
    public class AdministrationController : Controller
    {
        readonly AllItemsService allItemsService = new AllItemsService();
        readonly IUnitOfWork db = new UnitOfWork();

        // GET: Administration
        public ActionResult Index()
        {
            var articles = this.allItemsService.AllArticles();
            var members = this.allItemsService.AllMembers();
            //var Images = this.allItemsService.AllImages();

            var administrationItems = new AdminViewModel();

            administrationItems.Articles = articles;
            administrationItems.TeamMembers = members;

            return View(administrationItems);
        }

        [HttpGet]
        public ActionResult GetArticles()
        {
            var articles = this.allItemsService.AllArticles();

            return View(articles);
        }

        [HttpPost]
        public ActionResult AddArticles(List<Article> model)
        {

            return View();
        }

        [HttpPut]
        public ActionResult EditArticles(List<Article> model)
        {

            return View();
        }

        [HttpDelete]
        public ActionResult DeleteArticles(List<Article> model)
        {

            return View();
        }



        [HttpGet]
        public ActionResult GetMembers()
        {
            var members = this.allItemsService.AllMembers();

            return View(members);
        }

        [HttpPost]
        public ActionResult AddMembers(List<TeamMember> model)
        {

            return View();
        }

        [HttpPut]
        public ActionResult EditMembers(TeamMember model)
        {

            return View();
        }
        
        [HttpDelete]
        public ActionResult DeleteMembers(TeamMember model)
        {

            return View();
        }



        [HttpGet]
        public ActionResult GetImages()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddImages(Image model)
        {

            return View();
        }

        [HttpDelete]
        public ActionResult DeleteImages(Image model)
        {

            return View();
        }
    }
}