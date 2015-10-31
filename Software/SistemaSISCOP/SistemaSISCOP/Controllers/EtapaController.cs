using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaSISCOP.Models;

namespace SistemaSISCOP.Controllers
{
    public class EtapaController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Etapa/

        public ActionResult Index()
        {
            var etapas = db.Etapas.Include(e => e.Proyectos);
            return View(etapas.ToList());
        }

        //
        // GET: /Etapa/Details/5

        public ActionResult Details(int id = 0)
        {
            Etapas etapas = db.Etapas.Find(id);
            if (etapas == null)
            {
                return HttpNotFound();
            }
            return View(etapas);
        }

        //
        // GET: /Etapa/Create

        public ActionResult Create()
        {
            ViewBag.id_proyecto = new SelectList(db.Proyectos, "id_proyecto", "nombre_estudio");
            return View();
        }


        //
        // POST: /Etapa/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Etapas etapas)
        {
            if (ModelState.IsValid)
            {
                db.Etapas.Add(etapas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_proyecto = new SelectList(db.Proyectos, "id_proyecto", "nombre_estudio", etapas.id_proyecto);
            return View(etapas);
        }

        //
        // GET: /Etapa/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Etapas etapas = db.Etapas.Find(id);
            if (etapas == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_proyecto = new SelectList(db.Proyectos, "id_proyecto", "nombre_estudio", etapas.id_proyecto);
            return View(etapas);
        }

        //
        // POST: /Etapa/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Etapas etapas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(etapas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_proyecto = new SelectList(db.Proyectos, "id_proyecto", "nombre_estudio", etapas.id_proyecto);
            return View(etapas);
        }

        //
        // GET: /Etapa/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Etapas etapas = db.Etapas.Find(id);
            if (etapas == null)
            {
                return HttpNotFound();
            }
            return View(etapas);
        }

        //
        // POST: /Etapa/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Etapas etapas = db.Etapas.Find(id);
            db.Etapas.Remove(etapas);
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