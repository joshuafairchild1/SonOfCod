using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using System.Collections.Generic;
using System.Linq;

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

        [Authorize]
        public IActionResult Members()
        {
            List<NewsletterMember> members = _db.NewsletterMembers.ToList();
            return View(members);
        }
    }
}
