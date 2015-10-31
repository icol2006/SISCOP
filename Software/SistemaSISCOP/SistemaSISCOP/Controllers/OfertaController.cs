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
    public class OfertaController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Oferta/

        public ActionResult Index()
        {
            var ofertas = db.Ofertas.Include(o => o.Clientes).Include(o => o.Estados_Ofertas).Include(o => o.Responsables);
            return View(ofertas.ToList());
        }

        //
        // GET: /Oferta/Details/5

        public ActionResult Details(int id = 0)
        {
            Ofertas ofertas = db.Ofertas.Find(id);
            if (ofertas == null)
            {
                return HttpNotFound();
            }
            return View(ofertas);
        }

        //
        // GET: /Oferta/Create

        public ActionResult Create()
        {
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais");
            ViewBag.id_estado_oferta = new SelectList(db.Estados_Ofertas, "id_estado_oferta", "descripcion");
            ViewBag.id_responsable = new SelectList(db.Responsables, "id_responsable", "nombre");
            return View();
        }

        //
        // POST: /Oferta/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ofertas ofertas)
        {
            if (ModelState.IsValid)
            {
                db.Ofertas.Add(ofertas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", ofertas.id_cliente);
            ViewBag.id_estado_oferta = new SelectList(db.Estados_Ofertas, "id_estado_oferta", "descripcion", ofertas.id_estado_oferta);
            ViewBag.id_responsable = new SelectList(db.Responsables, "id_responsable", "nombre", ofertas.id_responsable);
            return View(ofertas);
        }

        //
        // GET: /Oferta/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Ofertas ofertas = db.Ofertas.Find(id);
            if (ofertas == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", ofertas.id_cliente);
            ViewBag.id_estado_oferta = new SelectList(db.Estados_Ofertas, "id_estado_oferta", "descripcion", ofertas.id_estado_oferta);
            ViewBag.id_responsable = new SelectList(db.Responsables, "id_responsable", "nombre", ofertas.id_responsable);
            return View(ofertas);
        }

        //
        // POST: /Oferta/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ofertas ofertas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ofertas).State = EntityState.Modified;
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", ofertas.id_cliente);
            ViewBag.id_estado_oferta = new SelectList(db.Estados_Ofertas, "id_estado_oferta", "descripcion", ofertas.id_estado_oferta);
            ViewBag.id_responsable = new SelectList(db.Responsables, "id_responsable", "nombre", ofertas.id_responsable);
            return View(ofertas);
        }

        //
        // GET: /Oferta/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Ofertas ofertas = db.Ofertas.Find(id);
            if (ofertas == null)
            {
                return HttpNotFound();
            }
            return View(ofertas);
        }

        //
        // POST: /Oferta/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ofertas ofertas = db.Ofertas.Find(id);
            db.Ofertas.Remove(ofertas);
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