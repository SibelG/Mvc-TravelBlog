using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelBlog.Models.Sınıflar;

namespace TravelBlog.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        // GET: Login

        public ActionResult Index()
        {
            return View();

        }
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(Admin adm)
        {
            var UserKnown = c.Admins.FirstOrDefault(x => x.UserName == adm.UserName && x.Password == adm.Password);
            if (UserKnown != null)
            {
                FormsAuthentication.SetAuthCookie(UserKnown.UserName, false);
                Session["UserName"] = UserKnown.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
            

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}