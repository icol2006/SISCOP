using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SISCOP.Models
{
    public class ViewModelSISCOP
    {
        public List<Proyecto> listadoProyectos { get; set; }
        public List<Cliente> listadoClientes { get; set; }
        public List<Contacto> listadoContactos { get; set; }
        public List<Etapa> listadoEtapas { get; set; }
        public List<Etapa_Tarea> listadoEtapasTareas { get; set; }
        public List<Oferta> listadoOfertas { get; set; }
        public List<Proyecto_Contactos> listadoProyecto_Contactos { get; set; }
        public List<Proyecto_Usuario> listadoProyecto_Usuarios { get; set; }
        public List<Tarea> listadoTareas{ get; set; }
        public List<Usuario> listadoUsuarios { get; set; }
    }
}