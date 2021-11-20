using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Models.Sınıflar;

namespace TravelBlog.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        // GET: About
        public ActionResult Index()
        {
            var degerler = c.Abouts.ToList();
            return View(degerler);
        }
    }
}