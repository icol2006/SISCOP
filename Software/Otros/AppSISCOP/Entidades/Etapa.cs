using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Etapa
    {
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private String estado;
        private String encargado;
        private List<Tarea> listadoTareas;
        private int proyectoid;

        public Etapa() { }

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


        internal List<Tarea> ListadoTareas
        {
            get { return listadoTareas; }
            set { listadoTareas = value; }
        }

        public int Proyectoid
        {
            get { return proyectoid; }
            set { proyectoid = value; }
        }




    }
}
