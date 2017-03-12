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
    using System;
    using System.Web;
    using Infrastructure.Constants;
    using System.IO;

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


        [HttpGet]
        public ActionResult AddArticle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddArticle(Article model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid && file != null)
            {
                var path = Server.MapPath(PathConstants.ArticlesImagePath);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                file.SaveAs(path + Path.GetFileName(file.FileName));

                var newImg = new Image()
                {
                    OriginalFileName = file.FileName,
                    Location = path
                };
                
                var article = new Article()
                {
                    Title = model.Title,
                    Content = model.Content,
                    CreatedOn = DateTime.UtcNow,
                    Image = newImg
                };

                db.ArticleRepo.Insert(article);
                //db.SaveChanges();                  //TODO : Problem with Save changes!

                TempData["Created!"] = "Article was created!";
                return RedirectToAction("AddArticle");
            };

            return View(model);
        }

        [HttpPut]
        public ActionResult EditArticle(Article model)
        {

            return View();
        }

        [HttpDelete]
        public ActionResult DeleteArticle(Article model)
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
        public ActionResult AddMember(TeamMember model)
        {

            return View();
        }

        [HttpPut]
        public ActionResult EditMember(TeamMember model)
        {

            return View();
        }
        
        [HttpDelete]
        public ActionResult DeleteMember(TeamMember model)
        {

            return View();
        }



        [HttpGet]
        public ActionResult GetImages()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddImage(Image model)
        {

            return View();
        }

        [HttpDelete]
        public ActionResult DeleteImage(Image model)
        {

            return View();
        }
    }
}