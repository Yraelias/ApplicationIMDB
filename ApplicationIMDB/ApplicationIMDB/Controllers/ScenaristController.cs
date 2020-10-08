using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationIMDB.Controllers
{
    public class ScenaristController : Controller
    {
        // GET: Scenarist
        public ActionResult Index()
        {
            return View();
        }

        // GET: Scenarist/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Scenarist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Scenarist/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Scenarist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Scenarist/Edit/5
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

        // GET: Scenarist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Scenarist/Delete/5
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
