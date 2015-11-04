using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Contacto
    {
        private int id;
        private Cliente cliente;
        private String pais;
        private String nombre;
        private String ocupacion;
        private List<Email> listadoEmail;
        private List<Telefono> listadoTelefonos;

        public Contacto() { }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        internal Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }

        public List<Email> ListadoEmail
        {
            get { return listadoEmail; }
            set { listadoEmail = value; }
        }

        public List<Telefono> ListadoTelefonos
        {
            get { return listadoTelefonos; }
            set { listadoTelefonos = value; }
        }


        public List<Telefono> ListadoCelular
        {
            get { return listadoCelular; }
            set { listadoCelular = value; }
        }
    }
}
