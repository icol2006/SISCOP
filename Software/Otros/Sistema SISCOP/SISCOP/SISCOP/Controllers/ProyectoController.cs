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
    public class ProyectoController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Proyecto/

        public ActionResult Index()
        {
            var proyectos = db.Proyectos.Include(p => p.Cliente).Include(p => p.Oferta);
            return View(proyectos.ToList());
        }

        //
        // GET: /Proyecto/Details/5

        public ActionResult Details(int id = 0)
        {
            Proyecto proyecto = db.Proyectos.Find(id);
            if (proyecto == null)
            {
                return HttpNotFound();
            }
            return View(proyecto);
        }

        //
        // GET: /Proyecto/Create

        public ActionResult Create()
        {
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "nombre");
            ViewBag.id_oferta = new SelectList(db.Ofertas, "id_oferta", "id_oferta");
            return View();
        }

        //
        // POST: /Proyecto/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Proyecto proyecto)
        {
            if (ModelState.IsValid)
            {
                db.Proyectos.Add(proyecto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "nombre", proyecto.id_cliente);
            ViewBag.id_oferta = new SelectList(db.Ofertas, "id_oferta", "id_oferta", proyecto.id_oferta);
            return View(proyecto);
        }

        //
        // GET: /Proyecto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Proyecto proyecto = db.Proyectos.Find(id);
            if (proyecto == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "nombre", proyecto.id_cliente);
            ViewBag.id_oferta = new SelectList(db.Ofertas, "id_oferta", "id_oferta", proyecto.id_oferta);
            return View(proyecto);
        }

        //
        // POST: /Proyecto/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Proyecto proyecto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proyecto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "nombre", proyecto.id_cliente);
            ViewBag.id_oferta = new SelectList(db.Ofertas, "id_oferta", "id_oferta", proyecto.id_oferta);
            return View(proyecto);
        }

        //
        // GET: /Proyecto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Proyecto proyecto = db.Proyectos.Find(id);
            if (proyecto == null)
            {
                return HttpNotFound();
            }
            return View(proyecto);
        }

        //
        // POST: /Proyecto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proyecto proyecto = db.Proyectos.Find(id);
            db.Proyectos.Remove(proyecto);
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