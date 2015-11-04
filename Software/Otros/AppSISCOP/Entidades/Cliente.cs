using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Cliente
    {
        private int id;
        private String pais;
        private String actividad;
        private String web;
        private List<Email> listadoEmails;
        private List<Telefono> listadoTelefonos;
        private int fax;
        private String Dirección;

        public Cliente() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public String Actividad
        {
            get { return actividad; }
            set { actividad = value; }
        }

        public String Web
        {
            get { return web; }
            set { web = value; }
        }

        public List<Email> Email
        {
            get { return listadoEmails; }
            set { listadoEmails = value; }
        }

        public List<Telefono> Telefono
        {
            get { return listadoTelefonos; }
            set { listadoTelefonos = value; }
        }

        public int Fax
        {
            get { return fax; }
            set { fax = value; }
        }


        public String Dirección1
        {
            get { return Dirección; }
            set { Dirección = value; }
        }


    }
}
