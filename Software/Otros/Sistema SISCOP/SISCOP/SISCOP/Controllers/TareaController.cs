using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SISCOP.Models;

namespace SISCOP.Controllers
{
    public class TareaController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Tarea/

        public ActionResult Index()
        {
            return View(db.Tareas.ToList());
        }

        //
        // GET: /Tarea/Details/5

        public ActionResult Details(int id = 0)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        //
        // GET: /Tarea/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tarea/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                db.Tareas.Add(tarea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tarea);
        }

        //
        // GET: /Tarea/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        //
        // POST: /Tarea/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tarea);
        }

        //
        // GET: /Tarea/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        //
        // POST: /Tarea/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tarea tarea = db.Tareas.Find(id);
            db.Tareas.Remove(tarea);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}