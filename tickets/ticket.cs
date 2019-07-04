using System;
using System.Globalization;

namespace tickets
{
    public class Ticket
    {
        private string supermercado;
        DateTime date;
             


        public void generadorDeTicket(){
            System.Console.Write("Ingrese la fecha del ticket en formato DD/MM/AAAA: ");
            date = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del supermercado: ");
            supermercado = Console.ReadLine();

        }


    }
}