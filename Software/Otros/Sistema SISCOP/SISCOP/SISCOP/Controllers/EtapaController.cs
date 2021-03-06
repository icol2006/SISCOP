﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SISCOP.Models;

namespace SISCOP.Controllers
{
    public class EtapaController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Etapa/

        public ActionResult Index()
        {
            var etapas = db.Etapas.Include(e => e.Proyecto);
            return View(etapas.ToList());
        }

        //
        // GET: /Etapa/Details/5

        public ActionResult Details(int id = 0)
        {
            Etapa etapa = db.Etapas.Find(id);
            if (etapa == null)
            {
                return HttpNotFound();
            }
            return View(etapa);
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
        public ActionResult Create(Etapa etapa)
        {
            if (ModelState.IsValid)
            {
                db.Etapas.Add(etapa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_proyecto = new SelectList(db.Proyectos, "id_proyecto", "nombre_estudio", etapa.id_proyecto);
            return View(etapa);
        }

        //
        // GET: /Etapa/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Etapa etapa = db.Etapas.Find(id);
            if (etapa == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_proyecto = new SelectList(db.Proyectos, "id_proyecto", "nombre_estudio", etapa.id_proyecto);
            return View(etapa);
        }

        //
        // POST: /Etapa/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Etapa etapa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(etapa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_proyecto = new SelectList(db.Proyectos, "id_proyecto", "nombre_estudio", etapa.id_proyecto);
            return View(etapa);
        }

        //
        // GET: /Etapa/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Etapa etapa = db.Etapas.Find(id);
            if (etapa == null)
            {
                return HttpNotFound();
            }
            return View(etapa);
        }

        //
        // POST: /Etapa/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Etapa etapa = db.Etapas.Find(id);
            db.Etapas.Remove(etapa);
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