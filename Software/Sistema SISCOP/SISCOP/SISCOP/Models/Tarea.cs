//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISCOP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarea
    {
        public Tarea()
        {
            this.Etapa_Tarea = new HashSet<Etapa_Tarea>();
        }
    
        public int id_tarea { get; set; }
        public string descripcion { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_final { get; set; }
        public string estado { get; set; }
        public string prioridad { get; set; }
        public Nullable<int> id_etapa { get; set; }
    
        public virtual ICollection<Etapa_Tarea> Etapa_Tarea { get; set; }
    }
}
