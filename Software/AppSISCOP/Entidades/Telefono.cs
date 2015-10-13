using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Telefono
    {
        private int id;
        private int numero;

        public Telefono(){}

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
