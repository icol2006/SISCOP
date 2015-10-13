using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Proyecto
    {
        private int id;
        private int anho;
        private String pais;
        private String cliente;
        private String estudio;
        private String descripcion;
        private DateTime fechaRecibido;
        private DateTime fechaPresentada;
        private String responsable;
        private String estado;
        private List<Contacto> listadoContactos;
        private String notas;
        private String observación;
        private String jefeCampo;
        private List<Etapa> listadoEtapas;
        private OfertaServicio ofertaServicio;




        public Proyecto() { }


        public int Anho
        {
            get { return anho; }
            set { anho = value; }
        }


        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public String Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public String Estudio
        {
            get { return estudio; }
            set { estudio = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime FechaRecibido
        {
            get { return fechaRecibido; }
            set { fechaRecibido = value; }
        }

        public DateTime FechaPresentada
        {
            get { return fechaPresentada; }
            set { fechaPresentada = value; }
        }

        public String Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public List<Contacto> ListadoContactoss
        {
            get { return listadoContactos; }
            set { listadoContactos = value; }
        }

        public String Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public String Observación
        {
            get { return observación; }
            set { observación = value; }
        }


        public String JefeCampo
        {
            get { return jefeCampo; }
            set { jefeCampo = value; }
        }

        public OfertaServicio OfertaServicio
        {
            get { return ofertaServicio; }
            set { ofertaServicio = value; }
        }


    }
}
