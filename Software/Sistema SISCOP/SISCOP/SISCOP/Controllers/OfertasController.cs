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
    public class OfertasController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Ofertas/

        public ActionResult Index()
        {
            var ofertas = db.Ofertas.Include(o => o.Cliente);
            return View(ofertas.ToList());
        }

        //
        // GET: /Ofertas/Details/5

        public ActionResult Details(int id = 0)
        {
            Oferta oferta = db.Ofertas.Find(id);
            if (oferta == null)
            {
                return HttpNotFound();
            }
            return View(oferta);
        }

        //
        // GET: /Ofertas/Create

        public ActionResult Create()
        {
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais");
            return View();
        }

        //
        // POST: /Ofertas/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Oferta oferta)
        {
            if (ModelState.IsValid)
            {
                db.Ofertas.Add(oferta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", oferta.id_cliente);
            return View(oferta);
        }

        //
        // GET: /Ofertas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Oferta oferta = db.Ofertas.Find(id);
            if (oferta == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "nombre", oferta.id_cliente);
            return View(oferta);
        }

        //
        // POST: /Ofertas/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Oferta oferta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oferta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", oferta.id_cliente);
            return View(oferta);
        }

        //
        // GET: /Ofertas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Oferta oferta = db.Ofertas.Find(id);
            if (oferta == null)
            {
                return HttpNotFound();
            }
            return View(oferta);
        }

        //
        // POST: /Ofertas/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Oferta oferta = db.Ofertas.Find(id);
            db.Ofertas.Remove(oferta);
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