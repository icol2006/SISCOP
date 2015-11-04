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

        public ActionResult Index(int id=0)
        {
            int idProyecto = Convert.ToInt16(Session["proyecto_id"] as String);
            IEnumerable<ViewEtapaTarea> model = null;
            model = (from t in db.Tareas
                     join et in db.Etapa_Tarea on t.id_tarea equals et.id_tarea
                     join u in db.Usuarios on et.id_usuario equals u.id_usuario
                     join e in db.Etapas on et.id_etapa equals e.id_etapa
                     join p in db.Etapas on et.id_etapa equals p.id_etapa
                     where p.id_proyecto==idProyecto && e.id_etapa==id

                  
                     select new ViewEtapaTarea
                     {
                         id_tarea = t.id_tarea,
                         descripcion = t.descripcion,
                         fecha_inicio = t.fecha_inicio,
                         fecha_final = t.fecha_final,
                         estado = t.estado,
                         id_usuario=u.id_usuario,
                         nombre_usuario = u.nombre_usuario,
                         id_etapa=e.id_etapa,
                         nombreEtapa=e.nombre,
                         prioridad=t.prioridad
                     });



            return View(model);
        }

        //
        // GET: /Tarea/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewEtapaTarea model = null;
            model = (from t in db.Tareas
                     join et in db.Etapa_Tarea on t.id_tarea equals et.id_tarea
                     join u in db.Usuarios on et.id_usuario equals u.id_usuario
                     join e in db.Etapas on et.id_etapa equals e.id_etapa
                     where t.id_tarea == id
                     select new ViewEtapaTarea
                     {
                         id_tarea = t.id_tarea,
                         descripcion = t.descripcion,
                         fecha_inicio = t.fecha_inicio,
                         fecha_final = t.fecha_final,
                         estado = t.estado,
                         id_usuario = u.id_usuario,
                         nombre_usuario = u.nombre_usuario,
                         id_etapa = e.id_etapa,
                         nombreEtapa = e.nombre,
                         prioridad=t.prioridad
                     }).ToList().FirstOrDefault();

            ViewBag.id_usuario = new SelectList(db.Usuarios, "id_usuario", "nombre_usuario", model.id_usuario);
            ViewBag.id_etapa = new SelectList(db.Etapas, "id_etapa", "nombre");

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // GET: /Tarea/Create

        public ActionResult Create()
        {
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
           model = (from t in db.Tareas
                    join et in db.Etapa_Tarea on t.id_tarea equals et.id_tarea
                    join u in db.Usuarios on et.id_usuario equals u.id_usuario
                    join e in db.Etapas on et.id_etapa equals e.id_etapa
                    where t.id_tarea == id
                    select new ViewEtapaTarea
                    {
                        id_tarea = t.id_tarea,
                        descripcion = t.descripcion,
                        fecha_inicio = t.fecha_inicio,
                        fecha_final = t.fecha_final,
                        estado = t.estado,
                        id_usuario = u.id_usuario,
                        nombre_usuario = u.nombre_usuario,
                        id_etapa = e.id_etapa,
                        nombreEtapa = e.nombre,
                        prioridad=t.prioridad
                    }).ToList().FirstOrDefault();

            ViewBag.id_usuario = new SelectList(db.Usuarios, "id_usuario", "nombre_usuario",model.id_usuario);
            ViewBag.id_etapa = new SelectList(db.Etapas, "id_etapa", "nombre",model.id_etapa);

            return View(model);
        }

        //
        // POST: /Tarea/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ViewEtapaTarea viewEtapaTarea)
        {
            Tareas tarea = new Tareas();
            tarea.id_tarea = viewEtapaTarea.id_tarea;
            tarea.fecha_inicio = viewEtapaTarea.fecha_inicio;
            tarea.fecha_final = viewEtapaTarea.fecha_final;
            tarea.estado = viewEtapaTarea.estado;
            tarea.descripcion = viewEtapaTarea.descripcion;
            tarea.prioridad = viewEtapaTarea.prioridad;

            Usuarios u = new Usuarios();
            u.id_usuario = viewEtapaTarea.id_usuario;
            u = db.Usuarios.Where(x => x.id_usuario == u.id_usuario).FirstOrDefault();

            Etapa_Tarea etapaTarea = new Etapa_Tarea();
            etapaTarea = db.Etapa_Tarea.Where(x => x.id_tarea == viewEtapaTarea.id_tarea).FirstOrDefault();
            etapaTarea.id_usuario = viewEtapaTarea.id_usuario;
            etapaTarea.id_etapa = viewEtapaTarea.id_etapa;

            if (ModelState.IsValid)
            {
                db.Entry(tarea).State = EntityState.Modified;
                db.Entry(etapaTarea).State = EntityState.Modified;
    
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tarea);
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
            Etapa_Tarea etapaTarea = db.Etapa_Tarea.Find(tareas.id_tarea);
            db.Tareas.Remove(tareas);
            db.Etapa_Tarea.Remove(etapaTarea);
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