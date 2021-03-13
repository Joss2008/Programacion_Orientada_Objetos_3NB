using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionJoss.CLASES
{
    public class HABITACIONPORRESERVA
    {
        private HABITACION habitacion;

        public HABITACIONPORRESERVA(HABITACION habitacion, RESERVA reserva, List<SERVICIOSEXTRA> servicios)
        {
            Habitacion = habitacion;
            Reserva = reserva;
            Servicios = servicios;
        }

        public HABITACION Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }

        private RESERVA reserva;

        public RESERVA Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }

        private List <SERVICIOSEXTRA> servicios;

        public List <SERVICIOSEXTRA> Servicios
        {
            get { return servicios; }
            set { servicios = value; }
        }

    }
}
