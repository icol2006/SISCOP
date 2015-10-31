using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaSISCOP.Models
{
    public class ViewCientesContactos
    {

        public IEnumerable<Clientes> Clientes { get; set; }
        public IEnumerable<Contactos> Contactos { get; set; }
        public IEnumerable<Tareas> Tareas { get; set; }
        public IEnumerable<Etapa_Tarea> Etapa_Tarea { get; set; }
    }
}