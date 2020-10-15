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
        public   SignInController()
        {
            service = new UserService();
            repository = new UserRepository();
        }
        // GET: SignIn
        public ActionResult Index()
        {
            return View();
        }


        // POST: SignIn/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(User user)
        {
                user = service.SignIn(user);
                if(user  != null ) return View("../User/Details",user);
            return View();
        }

    }
}
