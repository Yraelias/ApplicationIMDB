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
    public class MovieController : Controller
    {
        MovieService service;
        MovieRepository repository;

        public MovieController()
        {
            service = new MovieService();
            repository = new MovieRepository();
        }
        // GET: Movie
        public ActionResult Index()
        {
            IEnumerable<Movie> listMovies = service.Get();
            switch (HttpContext.Session.GetInt32("_Role"))
            {
                case 1: //Admin
                    return View("../Admin/Movie/Index", listMovies);
                case 2: //Regular
                    return View("../Regular/Movie/Index", listMovies);
                default:
                    return View("../anonymous/Movie/Index", listMovies);
            }
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            Movie movie = service.GetOne(id);
            switch (HttpContext.Session.GetInt32("_Role"))
            {
                case 1: //Admin
                    return View("../Admin/Movie/Details", movie);
                case 2: //Regular
                    return View("../Regular/Movie/Details", movie);
                default:
                    return View("../anonymous/Movie/Details", movie);
            }
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View("../Admin/Movie/Create");
        }

        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.AddorUpdate(movie,false);
                    return RedirectToAction("Index");
                }
                return View(movie);
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            Movie movie = service.GetOne(id);
            return View("../Admin/Movie/Edit",movie);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            try
            {
                service.AddorUpdate(movie,true);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("../Admin/Movie/Edit");
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
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
