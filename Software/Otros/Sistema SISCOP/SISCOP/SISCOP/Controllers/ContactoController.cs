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
    public class ContactoController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Contacto/

        public ActionResult Index()
        {
            return View(db.Contactos.ToList());
        }

        //
        // GET: /Contacto/Details/5

        public ActionResult Details(int id = 0)
        {
            Contacto contacto = db.Contactos.Find(id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        //
        // GET: /Contacto/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contacto/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                db.Contactos.Add(contacto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contacto);
        }

        //
        // GET: /Contacto/Edit/5

        public ActionResult Edit(int id = 0)
        {

            Contacto contacto = db.Contactos.Find(id);

            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        //
        // POST: /Contacto/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contacto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contacto);
        }

        //
        // GET: /Contacto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Contacto contacto = db.Contactos.Find(id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        //
        // POST: /Contacto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contacto contacto = db.Contactos.Find(id);
            db.Contactos.Remove(contacto);
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