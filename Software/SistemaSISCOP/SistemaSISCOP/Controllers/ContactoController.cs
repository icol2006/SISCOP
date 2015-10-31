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
    public class ContactoController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Contacto/

        public ActionResult Index()
        {
            var contactos = db.Contactos.Include(c => c.Clientes);
            return View(contactos.ToList());
        }

        //
        // GET: /Contacto/Details/5

        public ActionResult Details(int id = 0)
        {
            Contactos contactos = db.Contactos.Find(id);
            if (contactos == null)
            {
                return HttpNotFound();
            }
            return View(contactos);
        }

        //
        // GET: /Contacto/Create

        public ActionResult Create()
        {
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais");
            return View();
        }

        //
        // POST: /Contacto/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contactos contactos)
        {
            if (ModelState.IsValid)
            {
                db.Contactos.Add(contactos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", contactos.id_cliente);
            return View(contactos);
        }

        //
        // GET: /Contacto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Contactos contactos = db.Contactos.Find(id);
            if (contactos == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", contactos.id_cliente);
            return View(contactos);
        }

        //
        // POST: /Contacto/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contactos contactos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_cliente = new SelectList(db.Clientes, "id_cliente", "pais", contactos.id_cliente);
            return View(contactos);
        }

        //
        // GET: /Contacto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Contactos contactos = db.Contactos.Find(id);
            if (contactos == null)
            {
                return HttpNotFound();
            }
            return View(contactos);
        }

        //
        // POST: /Contacto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contactos contactos = db.Contactos.Find(id);
            db.Contactos.Remove(contactos);
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