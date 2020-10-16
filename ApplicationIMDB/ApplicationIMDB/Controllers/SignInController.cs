using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.DAL.Services;
using ApplicationIMDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationIMDB.Controllers
{
    public class SignInController : Controller
    {
        UserRepository repository;
        UserService service;
        public const string SessionKeyLogin = "_Login";
        public const string SessionKeyLastname = "_LastName";
        public const string SessionKeyFirstname = "_FirstName";
        public const string SessionKeyRole = "_Role";
        const string SessionKeyTime = "_Time";
        public   SignInController()
        {
            service = new UserService();
            repository = new UserRepository();
        }
        // GET: SignIn
        public ActionResult Index()
        {
            return View("../anonymous/SignIn/Index");
        }


        // POST: SignIn/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(User user)
        {
                user = service.SignIn(user);
                if(user  != null )
                {
                HttpContext.Session.SetString(SessionKeyLogin,user.Login);
                HttpContext.Session.SetString(SessionKeyLastname, user.LastName);
                HttpContext.Session.SetString(SessionKeyFirstname, user.FirstName);
                HttpContext.Session.SetInt32(SessionKeyRole, user.Id_Role);
                return RedirectToAction("Details","User",new { @id = user.Id_User });
                }
                
            return View();
        }

    }
}
