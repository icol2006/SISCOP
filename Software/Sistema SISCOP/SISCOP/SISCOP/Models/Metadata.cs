using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SISCOP.Models
{
    public class ClienteMetadata
    {
        [Display(Name = "ID Cliente")]
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
    }

    [MetadataType(typeof(ClienteMetadata))]
    public partial class Cliente
    {
    }

    public class ContactoMetaData
    {
        [Display(Name = "Contacto-Id")]
        public int id_contacto;
        [Display(Name = "Cliente-Id")]
        public Nullable<int> id_cliente;
        [Display(Name = "Pais")]
        public string pais;
        [Display(Name = "Nombre")]
        public string nombre;
        [Display(Name = "Ocupacion")]
        public string ocupacion;
        [Display(Name = "Telefono")]
        public string telefonos;
        [Display(Name = "Correo")]
        public string correo;
    }

    [MetadataType(typeof(ContactoMetaData))]
    public partial class Contacto
    {
    }

    public class OfetasMetaData
    {
        [Display(Name = "Oferta-Id")]
        public int id_oferta;
        [Display(Name = "Descripcion")]
        public string descripcion;
        [Display(Name = "Responsable")]
        public string responsable;
        [Display(Name = "Año")]
        public string anho;
        [Display(Name = "Pais")]
        public string pais;
        [Display(Name = "Fecha Recepcion")]
        public string fecha_recepcion;
        [Display(Name = "Fecha Presentacion")]
        public string fecha_presentacion;
        [Display(Name = "Estado")]
        public string estado;
        [Display(Name = "Nota")]
        public string nota;
        [Display(Name = "Observacion")]
        public string observacion;
        [Display(Name = "Cliente-Id")]
        public Nullable<int> id_cliente;
    }

    [MetadataType(typeof(OfetasMetaData))]
    public partial class Oferta
    {
    }

    public class ProyectoMetaData
    {
        [Display(Name = "Proyecto-Id")]
        public int id_proyecto;
        [Display(Name = "Cliente-Id")]
        public Nullable<int> id_cliente;
        [Display(Name = "Proyecto")]
        public string nombre_estudio;
        [Display(Name = "Descripcion")]
        public string descripcion;
        [Display(Name = "Responsable")]
        public string responsable;
        [Display(Name = "Año")]
        public string anho;
        [Display(Name = "Pais")]
        public string pais;
        [Display(Name = "Fecha Recepcion")]
        public string fecha_recepcion;
        [Display(Name = "Fecha Presentacion")]
        public string fecha_presentacion;
        [Display(Name = "Estado")]
        public string estado;
        [Display(Name = "Oferta-id")]
        public Nullable<int> id_oferta;
        [Display(Name = "Notas")]
        public string notas;
        [Display(Name = "Observacion")]
        public string observacion;
        [Display(Name = "Jefe de campo")]
        public string jefe_campo;
    }

    [MetadataType(typeof(ProyectoMetaData))]
    public partial class Proyecto
    {
    }

    public class EtapaMetadata
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

    [MetadataType(typeof(EtapaMetadata))]
    public partial class Etapa
    {
    }

    public class TareaMetadata
    {
        [Display(Name = "Tarea-id")]
        public int id_tarea;
        [Display(Name = "Descripcion")]
        public string descripcion;
        [Display(Name = "Fecha Inicio")]
        public string fecha_inicio;
        [Display(Name = "Fecha final")]
        public string fecha_final;
        [Display(Name = "Estado")]
        public string estado;
        [Display(Name = "Prioridad")]
        public string prioridad;
        [Display(Name = "Etapa-id")]
        public Nullable<int> id_etapa;
    }

    [MetadataType(typeof(TareaMetadata))]
    public partial class Tarea
    {
    }

}