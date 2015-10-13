using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Tarea
    {
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private String estado;
        private String encargado;
        private String prioridad;
        private int etapaid;

        public Tarea() { }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }


        public String Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        public int Etapaid
        {
            get { return etapaid; }
            set { etapaid = value; }
        }

    }
}
