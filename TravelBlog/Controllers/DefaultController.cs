using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Models.Sınıflar;
namespace TravelBlog.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {

            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();//last 3 values 
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID==1).ToList(); 
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(deger);
        }
        public ActionResult Contact()
        {

            return View();
        }
        [HttpGet]
        public PartialViewResult MakeContact(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MakeContact(Contact b)
        {
            c.Constacts.Add(b);
            c.SaveChanges();
            return PartialView();

        }


    }
}