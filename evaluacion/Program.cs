using System;
using System.Collections.Generic;
using EvaluacionJoss.CLASES;

namespace EvaluacionJoss
{
    class Program
    {
        static void Main(string[] args)
        {
            CLIENTE datoscliente = new CLIENTE(9999999, " " , new List<RESERVA>());
            RESERVA reservacion1 = new RESERVA(23, "18noviembre2019", datoscliente, new List<HABITACIONPORRESERVA>());

            //datoscliente.Reserva.Add(1, "fecha", " cliente", );
            datoscliente.Reserva.Add(reservacion1);

            HABITACION habitacion1 = new HABITACION(30);
            habitacion1.Habitacion.Add(habitacion1);
            HABITACION habitacion2 = new HABITACION(304);
            habitacion2.Habitacion.Add(habitacion2);

            SERVICIOSEXTRA servicio1 = new SERVICIOSEXTRA("TV Cable");
            ERVICIOSEXTRA servicio2 = new SERVICIOSEXTRA("TV Cable");
            servicios.Nombre.Add(servicio1-);
            servicios.Nombre.Add(servicio2);

            Console.WriteLine("Cliente 10%", "       ", "Reservas20%", "        ", "Habitaciones30% ", "        ", " Servicios40%");

        }
    }
}
