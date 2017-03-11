namespace WebSite.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Data.Repository;
    using Data.Repository.Interfaces;
    using System.Linq.Dynamic;

    public class HomeController : Controller
    {
        IUnitOfWork db = new UnitOfWork();

        public ActionResult Index()
        {
            var allArticles = db.ArticleRepo
                .Get()
                .Take(3)
                .ToList();

            return View(allArticles);
        }
        

        /// <summary>
        /// This comes from API
        /// </summary>
        /// <returns></returns>
        public ActionResult Events()
        {
            return View();
        }
        
        
        
    }
}