//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaSISCOP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tareas
    {
        public Tareas()
        {
            this.Etapa_Tarea = new HashSet<Etapa_Tarea>();
        }
    
        public int id_tarea { get; set; }
        public string descripcion { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_final { get; set; }
        public string estado { get; set; }
        public Nullable<int> id_prioridad { get; set; }
    
        public virtual ICollection<Etapa_Tarea> Etapa_Tarea { get; set; }
        public virtual Prioridad_Etapa Prioridad_Etapa { get; set; }
    }
}