namespace EventsApi.Server.Controllers
{
    using Data.Repository;
    using Data.Repository.Interfaces;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using System.Web.Mvc;
    using System.Linq;
    using Newtonsoft.Json;
    using System.Net.Http;

    [EnableCors(origins: "*", headers: "*", methods:"get")]
    public class EventController : ApiController
    {
        readonly IUnitOfWork dbEvents = new UnitOfWork();

        // Only Get methood will be used externaly from "WebSite"!
        public HttpResponseMessage Get()
        {
            var allEvents = dbEvents
                .EventRepo
                .Get()
                .OrderBy(x => x.HeldOn)
                .ToList();

            var json = JsonConvert.SerializeObject(allEvents);

            return new HttpResponseMessage()
            {
                Content = new StringContent(json)
            };
        }

        public ActionResult Post()
        {
            return null;
        }

        public ActionResult Edit()
        {
            return null;
        }

        public ActionResult Delete()
        {
            return null;
        }
    }
}