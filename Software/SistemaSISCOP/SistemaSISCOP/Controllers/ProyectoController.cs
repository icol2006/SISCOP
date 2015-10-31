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
    public class ProyectoController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Proyecto/

        public ActionResult Index()
        {
            var proyectos = db.Proyectos.Include(p => p.Clientes).Include(p => p.Estados_Proyectos).Include(p => p.Ofertas);
            return View(proyectos.ToList());
        }

        //
        // GET: /Proyecto/Details/5

        public ActionResult Details(int id = 0)
        {
            Proyectos proyectos = db.Proyectos.Find(id);
            if (proyectos == null)
            {
                return HttpNotFound();
            }
            return View(proyectos);
        }

        //
        // GET: /Proyecto/Create

        public ActionResult Create()
        {
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais");
            ViewBag.id_estado_proyecto = new SelectList(db.Estados_Proyectos, "id_estado_proyecto", "descripcion");
            ViewBag.id_oferta = new SelectList(db.Ofertas, "id_oferta", "descripcion");
            return View();
        }

        //
        // POST: /Proyecto/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Proyectos proyectos)
        {
            if (ModelState.IsValid)
            {
                db.Proyectos.Add(proyectos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", proyectos.id_cliente);
            ViewBag.id_estado_proyecto = new SelectList(db.Estados_Proyectos, "id_estado_proyecto", "descripcion", proyectos.id_estado_proyecto);
            ViewBag.id_oferta = new SelectList(db.Ofertas, "id_oferta", "descripcion", proyectos.id_oferta);
            return View(proyectos);
        }

        //
        // GET: /Proyecto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Proyectos proyectos = db.Proyectos.Find(id);
            if (proyectos == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", proyectos.id_cliente);
            ViewBag.id_estado_proyecto = new SelectList(db.Estados_Proyectos, "id_estado_proyecto", "descripcion", proyectos.id_estado_proyecto);
            ViewBag.id_oferta = new SelectList(db.Ofertas, "id_oferta", "descripcion", proyectos.id_oferta);
            return View(proyectos);
        }

        //
        // POST: /Proyecto/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Proyectos proyectos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proyectos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", proyectos.id_cliente);
            ViewBag.id_estado_proyecto = new SelectList(db.Estados_Proyectos, "id_estado_proyecto", "descripcion", proyectos.id_estado_proyecto);
            ViewBag.id_oferta = new SelectList(db.Ofertas, "id_oferta", "descripcion", proyectos.id_oferta);
            return View(proyectos);
        }

        //
        // GET: /Proyecto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Proyectos proyectos = db.Proyectos.Find(id);
            if (proyectos == null)
            {
                return HttpNotFound();
            }
            return View(proyectos);
        }

        //
        // POST: /Proyecto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proyectos proyectos = db.Proyectos.Find(id);
            db.Proyectos.Remove(proyectos);
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