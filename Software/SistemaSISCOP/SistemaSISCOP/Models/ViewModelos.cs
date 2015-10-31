using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaSISCOP.Models
{
    public class ViewModelos
    {
        public Clientes Clientes { get; set; }
        public Contactos Contactos { get; set; }
        public Proyectos Proyectos { get; set; }
        public Etapas Etapas { get; set; }
        public Tareas Tareas { get; set; }
        public Etapa_Tarea Etapa_Tarea { get; set; }
        public Prioridad_Etapa Prioridad_Etapa { get; set; }
        public Usuarios Usuarios { get; set; }

    }
}