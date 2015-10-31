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
    
    public partial class Ofertas
    {
        public Ofertas()
        {
            this.Proyectos = new HashSet<Proyectos>();
        }
    
        public int id_oferta { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> id_responsable { get; set; }
        public string anho { get; set; }
        public string pais { get; set; }
        public string fecha_recepcion { get; set; }
        public string fecha_presentacion { get; set; }
        public Nullable<int> id_estado_oferta { get; set; }
        public string nota { get; set; }
        public string observacion { get; set; }
        public Nullable<int> id_cliente { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Estados_Ofertas Estados_Ofertas { get; set; }
        public virtual Responsables Responsables { get; set; }
        public virtual ICollection<Proyectos> Proyectos { get; set; }
    }
}
