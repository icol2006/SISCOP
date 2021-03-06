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
    
    public partial class Proyectos
    {
        public Proyectos()
        {
            this.Etapas = new HashSet<Etapas>();
            this.Proyecto_Usuario = new HashSet<Proyecto_Usuario>();
        }
    
        public int id_proyecto { get; set; }
        public string codigo { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string nombre_estudio { get; set; }
        public string descripcion { get; set; }
        public string directorProyecto { get; set; }
        public string anho { get; set; }
        public string pais { get; set; }
        public string fecha_recepcion { get; set; }
        public string fecha_presentacion { get; set; }
        public Nullable<int> id_estado_proyecto { get; set; }
        public Nullable<int> id_oferta { get; set; }
        public string notas { get; set; }
        public string observacion { get; set; }
        public string jefe_campo { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Estados_Proyectos Estados_Proyectos { get; set; }
        public virtual ICollection<Etapas> Etapas { get; set; }
        public virtual Ofertas Ofertas { get; set; }
        public virtual ICollection<Proyecto_Usuario> Proyecto_Usuario { get; set; }
    }
}
