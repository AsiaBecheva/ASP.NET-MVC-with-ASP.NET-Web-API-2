namespace WebSite.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Data.Repository;
    using Data.Repository.Interfaces;
    using System.Linq.Dynamic;
    using System.Net;
    using System.IO;
    using Newtonsoft.Json;
    using WebSite.Models;
    using System.Collections.Generic;

    public class HomeController : Controller
    {
        IUnitOfWork db = new UnitOfWork();

        public ActionResult Index()
        {
            var allArticles = db.ArticleRepo
                .Get()
                .Take(3)
                .OrderBy(x => x.CreatedOn)
                .ToList();

            return View(allArticles);
        }
        

        /// <summary>
        /// Events that comes from API
        /// </summary>
        /// <returns></returns>
        public ActionResult Events()
        {
            //Write your localhost after you run EventsApi!
            var request = WebRequest.Create("http://localhost:56964/api") as HttpWebRequest;
            request.Method = "Get";
            request.ContentType = "application/json";
            WebResponse responce = request.GetResponse();
            Stream stream = responce.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string responseFromServer = reader.ReadToEnd();
            reader.Close();

            var deserializeData = JsonConvert.DeserializeObject<List<Event>>(responseFromServer);

            return View("_EventsPartial", deserializeData);
        }
    }
}