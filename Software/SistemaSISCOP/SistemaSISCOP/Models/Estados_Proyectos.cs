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
    
    public partial class Estados_Proyectos
    {
        public Estados_Proyectos()
        {
            this.Proyectos = new HashSet<Proyectos>();
        }
    
        public int id_estado_proyecto { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<Proyectos> Proyectos { get; set; }
    }
}
