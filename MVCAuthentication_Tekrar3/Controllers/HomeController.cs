using MVCAuthentication_Tekrar3.AuthenticationClasses;
using MVCAuthentication_Tekrar3.DesignPatterns.SingletonPattern;
using MVCAuthentication_Tekrar3.Models.Context;
using MVCAuthentication_Tekrar3.Models.Entities;
using MVCAuthentication_Tekrar3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication_Tekrar3.Controllers
{
    public class HomeController : Controller
    {
        MyContext _db;

        public HomeController()
        {
            _db = DBTool.DBInstance;
        }
        [AdminAuthentication]
        public ActionResult Index()
        {
            HomeVM hvm = new HomeVM
            {
                AppUsers = _db.AppUsers.ToList()
            };
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AppUser appUser)
        {
            AppUser ap = _db.AppUsers.FirstOrDefault(x => x.UserName == appUser.UserName && x.Password == appUser.Password);

            if(ap != null)
            {
                if(ap.Role == Models.Enums.UserRole.Admin)
                {
                    Session["admin"] = ap;
                    return RedirectToAction("Index");
                }
                ViewBag.Message = "Yetkiniz admin değil";
                return View();
            }
            ViewBag.Message = "Böyle bir kullanıcı bulunamadı";
            return View();

        }

       
    }
}