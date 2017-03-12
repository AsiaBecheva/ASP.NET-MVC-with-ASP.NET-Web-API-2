namespace WebSite.Web.Controllers
{
    using System.Web.Mvc;
    using System.Net;
    using System.IO;
    using Newtonsoft.Json;
    using WebSite.Models;
    using System.Collections.Generic;
    using Services;

    public class HomeController : Controller
    {
        private AllItemsService allItemsService = new AllItemsService();

        public ActionResult Index()
        {
            var Articles = this.allItemsService.AllArticles();

            return View(Articles);
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