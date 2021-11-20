using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Models.Sınıflar;

namespace TravelBlog.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context contact = new Context();
        public ActionResult Index()
        {
            var address = contact.Addressses.ToList();
            return View(address);
        }
        [HttpGet]
        public PartialViewResult MakeContact()
        {
        
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MakeContact(Contact b)
        {
            contact.Constacts.Add(b);
            contact.SaveChanges();
            return PartialView();

        }
    }
}