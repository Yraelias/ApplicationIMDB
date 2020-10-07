using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using ApplicationIMDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace ApplicationIMDB.Controllers
{
    public class AutorController : Controller
    {
        
        Autor autor = new Autor()
        {
            Id_Autor = 10,
            FirstName = "Michel",
            LastName = "Bibine",
        };
        List<Autor> listAut = new List<Autor>();
        
        // GET: Autor
        public ActionResult Index()
        {
            listAut.Add(autor);
            return View(listAut);
        }

        // GET: Autor/Details/5
        public ActionResult Details(int id)
        {
            listAut.Add(autor);
            return View(autor);
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
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

        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Autor/Edit/5
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

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Autor/Delete/5
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
