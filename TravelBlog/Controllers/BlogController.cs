using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Models.Sınıflar;

namespace TravelBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context blog = new Context();
        public ActionResult Index()
        {
            by.Deger1 = blog.Blogs.ToList();
            by.Deger3 = blog.Blogs.Take(3).ToList();
            return View(by);
        }
        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = blog.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = blog.Comments.Where(x => x.BlogId == id).ToList();

            //var blogbul = blog.Blogs.Where(x => x.ID == id).ToList();
            return View(by);
           
        }
        [HttpGet]
        public PartialViewResult MakeComment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MakeComment(Comment b)
        {
            blog.Comments.Add(b);
            blog.SaveChanges();
            return PartialView();
            
        }

    }
}