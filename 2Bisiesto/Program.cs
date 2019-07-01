using System;

namespace _2Bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 ano = Convert.ToInt16(args[0]);
            bool respuesta = esBisiesto(ano);
            if (respuesta)
            {
                Console.WriteLine("El año " + ano + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + ano + " no es bisiesto");
            }
        }
        static bool esBisiesto(Int16 ano)
        {
            return ((ano % 400) == 0 || ((ano % 100) != 0 && (ano % 4) == 0) );

        }
    }
}
