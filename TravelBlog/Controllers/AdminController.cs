using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlog.Models.Sınıflar;

namespace TravelBlog.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");//action
        }
        public ActionResult BlogSil(int id)
        {
            var blg = c.Blogs.Find(id);
            c.Blogs.Remove(blg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FindBlog(int id)
        {
            var blg = c.Blogs.Find(id);
            return View("FindBlog",blg);

        }
        public ActionResult UpdateBlog(Blog blg)
        {
            var blog = c.Blogs.Find(blg.ID);//get parametre value
            blog.Aciklama = blg.Aciklama;//blg=new Value 
            blog.Baslik = blg.Baslik;
            blog.BlogImage = blg.BlogImage;
            blog.Tarih = blg.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
       public ActionResult CommentList()
        {
            var comments = c.Comments.ToList();
            return View(comments);
        }
        public ActionResult CommentDelete(int id)
        {
            var comment = c.Comments.Find(id);
            c.Comments.Remove(comment);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult UpdateComment(Comment cmt)
        {
            var comment = c.Comments.Find(cmt.ID);//get parametre value
            comment.KullaniciAdi = cmt.KullaniciAdi;//blg=new Value 
            comment.Mail = cmt.Mail;
            comment.Comments = cmt.Comments;
            comment.Blog = cmt.Blog;
            c.SaveChanges();
            return RedirectToAction("CommentList*");


        }
        public ActionResult GetComment(int id)
        {
            var cmt = c.Comments.Find(id);
            return View("GetComment",cmt);
        }
    }
}