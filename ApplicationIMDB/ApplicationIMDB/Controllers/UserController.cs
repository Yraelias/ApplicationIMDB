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
    public class UserController : Controller
    {
        UserRepository repository;
        UserService service;
        public UserController()
        {
            service = new UserService();
            repository = new UserRepository();
        }
        // GET: User
        public ActionResult Index()
        {
            IEnumerable<User> listUsers = service.Get();
            return View(listUsers);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            User user = service.GetOne(id);
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    service.Add(user);
                    return RedirectToAction("Index");
                }
                return View(user);
            }
            catch
            {
                return View();
            }
        }
        // POST: User/Desactivate/5
        public ActionResult Desactivate(int id)
        {
            //try
            //{
                service.DesactiveActive(id,false);
                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return RedirectToAction("Index");
            //}
        }
        public ActionResult Activate(int id)
        {
            //try
            //{
                service.DesactiveActive(id,true);
                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return RedirectToAction("Index");
            //}
        }
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        
    }
}
