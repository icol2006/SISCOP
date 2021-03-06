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
    
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Etapas = new HashSet<Etapa>();
            this.Proyecto_Contactos = new HashSet<Proyecto_Contactos>();
            this.Proyecto_Usuario = new HashSet<Proyecto_Usuario>();
        }
    
        public int id_proyecto { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string nombre_estudio { get; set; }
        public string descripcion { get; set; }
        public string responsable { get; set; }
        public string anho { get; set; }
        public string pais { get; set; }
        public string fecha_recepcion { get; set; }
        public string fecha_presentacion { get; set; }
        public string estado { get; set; }
        public Nullable<int> id_oferta { get; set; }
        public string notas { get; set; }
        public string observacion { get; set; }
        public string jefe_campo { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Etapa> Etapas { get; set; }
        public virtual Oferta Oferta { get; set; }
        public virtual ICollection<Proyecto_Contactos> Proyecto_Contactos { get; set; }
        public virtual ICollection<Proyecto_Usuario> Proyecto_Usuario { get; set; }
    }
}
