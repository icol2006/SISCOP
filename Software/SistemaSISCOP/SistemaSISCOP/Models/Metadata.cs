using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaSISCOP.Models
{

    public class ClientesMetadata
    {
        [Display(Name = "Id")]
        public int id_cliente;

        [Display(Name = "Pais")]
        public string pais;

        [Display(Name = "Sitio Web")]
        public string web;

        [Display(Name = "Fax")]
        public string fax;

        [Display(Name = "Telefono")]
        public Nullable<int> telefono;

        [Display(Name = "Correo")]
        public string correo;

        [Display(Name = "Direccion")]
        public string direccion;

        [Display(Name = "Nombre")]
        public string nombre;
    }

    [MetadataType(typeof(ClientesMetadata))]
    public partial class Clientes
    {
    }

    public class ContactosMetaData
    {
        [Display(Name = "Id")]
        public int id_contacto;
        [Display(Name = "Pais")]
        public string pais;
        [Display(Name = "Nombre")]
        public string nombre;
        [Display(Name = "Puesto")]
        public string puesto;
        [Display(Name = "Telefono")]
        public string telefonos;
        [Display(Name = "Correo")]
        public string correo;
        [Display(Name = "Id-Cliente")]
        public int id_cliente;
    }

    [MetadataType(typeof(ContactosMetaData))]
    public partial class Contactos
    {
    }

    public class OfetasMetaData
    {
        [Display(Name = "Id")]
        public int id_oferta;
        [Display(Name = "Codigo Oferta")]
        public string codigo;
        [Display(Name = "Descripcion")]
        public string descripcion;
        [Display(Name = "Responsable-Id")]
        public string id_responsable;
        [Display(Name = "Año")]
        public string anho;
        [Display(Name = "Pais")]
        public string pais;
        [Display(Name = "Fecha Recepcion")]
        public string fecha_recepcion;
        [Display(Name = "Fecha Presentacion")]
        public string fecha_presentacion;
        [Display(Name = "Estad_Oferta-Id")]
        public string id_estado_oferta;
        [Display(Name = "Nota")]
        public string nota;
        [Display(Name = "Observacion")]
        public string observacion;
        [Display(Name = "Cliente-Id")]
        public Nullable<int> id_cliente;

    }

    [MetadataType(typeof(OfetasMetaData))]
    public partial class Ofertas
    {
    }

    public class ProyectosMetaData
    {
        [Display(Name = "Id")]
        public int id_proyecto;
        [Display(Name = "Codigo Proyecto")]
        public string codigo;
        [Display(Name = "Cliente-Id")]
        public Nullable<int> id_cliente;
        [Display(Name = "Proyecto")]
        public string nombre_estudio;
        [Display(Name = "Descripcion")]
        public string descripcion;
        [Display(Name = "Director Proyecto")]
        public string directorProyecto;
        [Display(Name = "Año")]
        public string anho;
        [Display(Name = "Pais")]
        public string pais;
        [Display(Name = "Fecha Recepcion")]
        public string fecha_recepcion;
        [Display(Name = "Fecha Presentacion")]
        public string fecha_presentacion;
        [Display(Name = "Estado-Id")]
        public string id_estado_proyecto;
        [Display(Name = "Oferta-id")]
        public Nullable<int> id_oferta;
        [Display(Name = "Notas")]
        public string notas;
        [Display(Name = "Observacion")]
        public string observacion;
        [Display(Name = "Jefe de campo")]
        public string jefe_campo;
    }

    [MetadataType(typeof(ProyectosMetaData))]
    public partial class Proyectos
    {
    }

    public class EtapasMetadata
    {
        [Display(Name = "Etapa-id")]
        public int id_etapa;
        [Display(Name = "Proyecto-id")]
        public Nullable<int> id_proyecto;
        [Display(Name = "Fecha Incio")]
        public string fecha_inicio;
        [Display(Name = "Fecha Final")]
        public string fecha_final;
        [Display(Name = "Estado")]
        public string estado;
        [Display(Name = "Encargado")]
        public string encargado;
        [Display(Name = "Etapa")]
        public string nombre;
    }

    [MetadataType(typeof(EtapasMetadata))]
    public partial class Etapas
    {
    }

    public class TareasMetadata
    {
        [Display(Name = "Id")]
        public int id_tarea;
        [Display(Name = "Descripcion")]
        public string descripcion;
        [Display(Name = "Fecha Inicio")]
        public string fecha_inicio;
        [Display(Name = "Fecha final")]
        public string fecha_final;
        [Display(Name = "Estado")]
        public string estado;
        [Display(Name = "Prioridad_id")]
        public string id_prioridad;
    }

    [MetadataType(typeof(TareasMetadata))]
    public partial class Tareas
    {
    }

    public class Estados_OfertasMetadata
    {
        [Display(Name = "Estado-id")]
        public int id_estado_oferta;
        [Display(Name = "Estado")]
        public string descripcion;

    }

    [MetadataType(typeof(Estados_OfertasMetadata))]
    public partial class Estados_Ofertas
    {
    }

    public class ResponsablesMetadata
    {
        [Display(Name = "Responsable-id")]
        public int id_responsable;
        [Display(Name = "Responsable")]
        public string nombre;

    }

    [MetadataType(typeof(ResponsablesMetadata))]
    public partial class Responsables
    {
    }

    public class Estados_ProyectosMetadata
    {
        [Display(Name = "Estado-id")]
        public int id_estado_proyecto;
        [Display(Name = "Estado")]
        public string descripcion;

    }

    [MetadataType(typeof(Estados_ProyectosMetadata))]
    public partial class Estados_Proyectos
    {
    }

    public class Prioridad_EtapaMetaData
    {
        [Display(Name = "Prioridad-id")]
        public int id_prioridad;
        [Display(Name = "Prioridad")]
        public string descripcion;

    }

    [MetadataType(typeof(Prioridad_EtapaMetaData))]
    public partial class Prioridad_Etapa
    {
    }
    
}