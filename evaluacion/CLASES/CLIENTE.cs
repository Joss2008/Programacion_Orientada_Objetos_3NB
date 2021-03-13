using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionJoss.CLASES
{
    public class CLIENTE
    {

        public CLIENTE(int identificacion, string nombre, List<RESERVA> reserva)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Reserva = reserva;
        }

        private int identificacion;

        public int Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private string nombre;

        public string  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List <RESERVA> reserva;
        public List <RESERVA> Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }

    }
}
