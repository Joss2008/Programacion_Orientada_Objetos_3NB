using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionJoss.CLASES
{
    public class HABITACION
    {

        public HABITACION(int habitacion)
        {
            Habitacion = habitacion;
        }

        private int habitacion;
        public int Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }

    }
}
