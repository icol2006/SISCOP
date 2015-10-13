using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class OfertaServicio
    {
        private int id;
        private int año;
        private String pais;
        private String cliente;
        private String descripción;
        private DateTime fechaRecibida;
        private DateTime fechaPresentada;
        private String responsable;
        private String estado;
        private List<Contacto> listadoContactos;
        private String notas;
        private String observacion;

        public OfertaServicio() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
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
        private String estudio;

        public String Estudio
        {
            get { return estudio; }
            set { estudio = value; }
        }

        public String Descripción
        {
            get { return descripción; }
            set { descripción = value; }
        }

        public DateTime FechaRecibida
        {
            get { return fechaRecibida; }
            set { fechaRecibida = value; }
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

        public List<Contacto> ListadoContactos
        {
            get { return listadoContactos; }
            set { listadoContactos = value; }
        }

        public String Notas
        {
            get { return notas; }
            set { notas = value; }
        }


        public String Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

    }
}
