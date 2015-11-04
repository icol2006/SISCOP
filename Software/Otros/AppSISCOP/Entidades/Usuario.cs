using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        private int id;
        private String nombre;
        private String password;
        private String tipo;
        private List<Email> correos;
        private List<Telefono> listadoTelefonos;
        private List<Telefono> listadoCelulares;

        public Usuario() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Tipo1
        {
            get { return tipo; }
            set { tipo = value; }
        }       
        
        public List<Email> Correos
        {
            get { return correos; }
            set { correos = value; }
        }

        public List<Telefono> ListadoTelefonos
        {
            get { return listadoTelefonos; }
            set { listadoTelefonos = value; }
        }

        public List<Telefono> ListadoCelulares
        {
            get { return listadoCelulares; }
            set { listadoCelulares = value; }
        }
    }
}
