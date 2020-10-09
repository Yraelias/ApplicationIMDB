using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationIMDB.DAL.Repositories;
using ApplicationIMDB.DAL.Services;
using ApplicationIMDB.Models;

namespace ApplicationIMDB.Controllers
{
    public class ActorController : Controller
    {
        ActorService service;
        ActorRepository repository;

        public ActorController()
        {
            service = new ActorService();
            repository = new ActorRepository();
        }
        // GET: Actor
        public ActionResult Index()
        {
            IEnumerable<Actor> listActors = service.Get();
            return View(listActors);
        }

        // GET: Actor/Details/5
        public ActionResult Details(int id)
        {
            Actor actor = service.GetOne(id);
            return View(actor);
        }

        // GET: Actor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Actor actor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.Add(actor);
                    return RedirectToAction("Index");
                }
                return View(actor);
            }
            catch
            {
                return View();
            }
        }

        // GET: Actor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Actor/Edit/5
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

        // GET: Actor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Actor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
