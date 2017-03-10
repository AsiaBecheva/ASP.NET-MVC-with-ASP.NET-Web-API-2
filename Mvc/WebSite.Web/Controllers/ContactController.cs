namespace WebSite.Web.Controllers
{
    using Data.Repository;
    using Data.Repository.Interfaces;
    using Models;
    using System.Web.Mvc;
    using WebSite.Models;

    public class ContactController : Controller
    {
        IUnitOfWork db = new UnitOfWork();

        [HttpGet]
        public ActionResult Email()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

                TempData["Success"] = "Message was sent successfully!";
                return RedirectToAction("Email");
            }

            return View(model);
        }
    }
}