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
    
    public partial class Contactos
    {
        public int id_contacto { get; set; }
        public string pais { get; set; }
        public string nombre { get; set; }
        public string puesto { get; set; }
        public string telefonos { get; set; }
        public string correo { get; set; }
        public Nullable<int> id_cliente { get; set; }
    
        public virtual Clientes Clientes { get; set; }
    }
}
