using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionJoss.CLASES
{
    public class SERVICIOSEXTRA
    {

        public SERVICIOSEXTRA(string nombre)
        {
            Nombre = nombre;
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
                
    }
}
