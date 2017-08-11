using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        private AppDbContext _db;

        public NewsletterController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(NewsletterMember model)
        {
            
            _db.NewsletterMembers.Add(model);
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
