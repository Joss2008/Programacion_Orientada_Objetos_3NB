using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionJoss.CLASES
{
    public class RESERVA
    {
        private int numero;

        public RESERVA(int numero, string fecha, CLIENTE cliente, List<HABITACIONPORRESERVA> habitaciones)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Habitaciones = habitaciones;
            Total = total;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private CLIENTE cliente;

        public CLIENTE Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private List <HABITACIONPORRESERVA> habitaciones;

        public List <HABITACIONPORRESERVA>Habitaciones
        {
            get { return habitaciones; }
            set { habitaciones = value; }
        }

        private  float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        public RESERVA()
        {

        }



    }
}
