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
    public class TareaController : Controller
    {
        private SISCOPEntities db = new SISCOPEntities();

        //
        // GET: /Tarea/

        public ActionResult Index()
        {
            IEnumerable<ViewEtapaTarea> model = null;
            model = (from e in db.Tareas
                     join j in db.Etapa_Tarea on e.id_tarea equals j.id_tarea
                     join x in db.Usuarios on j.id_usuario equals x.id_usuario
                     select new ViewEtapaTarea
                     {
                         id_tarea = e.id_tarea,
                         descripcion = e.descripcion,
                         fecha_inicio = e.fecha_inicio,
                         fecha_final = e.fecha_final,
                         estado = e.estado,
                         id_usuario=x.id_usuario,
                         nombre_usuario = x.nombre_usuario
                     });



            return View(model);
        }

        public ActionResult Index2()
        {
           IEnumerable<ViewEtapaTarea> model = null;
           model = (from e in db.Tareas
                     join j in db.Etapa_Tarea on e.id_tarea equals j.id_tarea
                     join x in db.Usuarios on j.id_usuario equals x.id_usuario
                     select new ViewEtapaTarea
                     {
                         id_tarea = e.id_tarea,
                         descripcion = e.descripcion,
                         fecha_inicio=e.fecha_inicio,
                         fecha_final=e.fecha_final,
                         estado=e.estado,
                         id_usuario=x.id_usuario,
                         nombre_usuario = x.nombre_usuario
                     });

            return View(model);
        }

        //
        // GET: /Tarea/Details/5

        public ActionResult Details(int id = 0)
        {
            Tareas tareas = db.Tareas.Find(id);
            if (tareas == null)
            {
                return HttpNotFound();
            }
            return View(tareas);
        }

        //
        // GET: /Tarea/Create

        public ActionResult Create()
        {
            ViewBag.id_prioridad = new SelectList(db.Prioridad_Etapa, "id_prioridad", "descripcion");
            ViewBag.id_usuario = new SelectList(db.Usuarios, "id_usuario", "nombre_usuario");
            ViewBag.id_etapa = new SelectList(db.Etapas, "id_etapa", "nombre");
            return View();
        }

        //
        // POST: /Tarea/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tareas tareas, Etapa_Tarea etapaTarea)
        {
            if (ModelState.IsValid)
            {
                etapaTarea.id_etapa_tarea = tareas.id_tarea;
                db.Etapa_Tarea.Add(etapaTarea);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(tareas);
        }

        //
        // GET: /Tarea/Edit/5

        public ActionResult Edit(int id = 0)
        {
           ViewEtapaTarea model = null;
            model = (from e in db.Tareas
                     join j in db.Etapa_Tarea on e.id_tarea equals j.id_tarea
                     join x in db.Usuarios on j.id_usuario equals x.id_usuario
                     where e.id_tarea==id
                     select new ViewEtapaTarea
                     {
                         id_tarea = e.id_tarea,
                         descripcion = e.descripcion,
                         fecha_inicio = e.fecha_inicio,
                         fecha_final = e.fecha_final,
                         estado = e.estado,
                         nombre_usuario = x.nombre_usuario
                     }).ToList().FirstOrDefault();
            ViewBag.id_prioridad = new SelectList(db.Prioridad_Etapa, "id_prioridad", "descripcion");
            ViewBag.id_usuario = new SelectList(db.Usuarios, "id_usuario", "nombre_usuario");
            ViewBag.id_etapa = new SelectList(db.Etapas, "id_etapa", "nombre");

            return View(model);
        }

        //
        // POST: /Tarea/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ViewEtapaTarea viewEtapaTarea)
        {
            Tareas t = new Tareas();
            t.id_tarea = viewEtapaTarea.id_tarea;
            t.fecha_inicio = viewEtapaTarea.fecha_inicio;
            t.fecha_final = viewEtapaTarea.fecha_final;
            t.estado = viewEtapaTarea.estado;
            t.descripcion = viewEtapaTarea.descripcion;

            Usuarios u = new Usuarios();
            u.id_usuario = viewEtapaTarea.id_usuario;
            u = db.Usuarios.Where(x => x.id_usuario == u.id_usuario).FirstOrDefault();

            Etapa_Tarea et = new Etapa_Tarea();
            et = db.Etapa_Tarea.Where(x => x.id_tarea == viewEtapaTarea.id_tarea).FirstOrDefault();
            et.id_usuario = viewEtapaTarea.id_usuario;

            if (ModelState.IsValid)
            {
                db.Entry(t).State = EntityState.Modified;
                db.Entry(et).State = EntityState.Modified;
    
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_prioridad = new SelectList(db.Prioridad_Etapa, "id_prioridad", "descripcion", t.id_prioridad);
            return View(t);
        }

        //
        // GET: /Tarea/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Tareas tareas = db.Tareas.Find(id);
            if (tareas == null)
            {
                return HttpNotFound();
            }
            return View(tareas);
        }

        //
        // POST: /Tarea/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tareas tareas = db.Tareas.Find(id);
            db.Tareas.Remove(tareas);
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