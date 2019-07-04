using System;

namespace numerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int lng = 0;
            int numero = Convert.ToInt16(args[0]);
            string numerosRomano = "";

            int miles = numero / 1000;

            if (miles > 0)
            {
                numerosRomano = numerosRomano.PadLeft(miles, 'M');
                numero = numero % 1000;
                lng = miles;
            }
            else { miles = 0; }

            int cientos = numero / 100;

            if (cientos > 8)
            {
                numerosRomano = numerosRomano.PadRight(++lng, 'C');
                numerosRomano = numerosRomano.PadRight(++lng, 'M');
                numero = numero % 100;

            }
            else if (cientos >= 5)
            {
                int numeroCientos = cientos - 5;
                numerosRomano = numerosRomano.PadRight(++lng, 'D');
                numerosRomano = numerosRomano.PadRight(lng + numeroCientos, 'C');
                numero = numero % 100;

            }
            else if (cientos > 3)
            {
                numerosRomano = numerosRomano.PadRight(++miles, 'C');
                numerosRomano = numerosRomano.PadRight(miles + cientos, 'D');
                numero = numero % 100;
                lng = miles + 1 + cientos;
            }
            else if (cientos > 0)
            {
                numerosRomano = numerosRomano.PadRight(miles + cientos, 'C');
                numero = numero % 100;
                lng = miles + cientos;
            }


            int decadas = numero / 10;

            if (decadas > 8)
            {
                numerosRomano = numerosRomano.PadRight(++lng, 'X');
                numerosRomano = numerosRomano.PadRight(++lng, 'C');
                numero = numero % 10;

            }
            else if (decadas >= 5)
            {
                int numeroDecadas = decadas - 5;
                numerosRomano = numerosRomano.PadRight(++lng, 'L');
                numerosRomano = numerosRomano.PadRight(lng + numeroDecadas, 'X');
                numero = numero % 10;
                lng += numeroDecadas;
            }
            else if (decadas > 3)
            {
                numerosRomano = numerosRomano.PadRight(++lng, 'X');
                numerosRomano = numerosRomano.PadRight(++lng, 'L');
                numero = numero % 10;
            }
            else if (decadas > 0)
            {
                numerosRomano = numerosRomano.PadRight(lng + decadas, 'X');
                numero = numero % 10;
                lng += decadas;
            }


            if (numero > 8)
            {
                numerosRomano = numerosRomano.PadRight(++lng, 'I');
                numerosRomano = numerosRomano.PadRight(++lng, 'X');

            }
            else if (numero >= 5)
            {
                int numeroNumero = numero - 5;
                numerosRomano = numerosRomano.PadRight(++lng, 'V');
                numerosRomano = numerosRomano.PadRight(lng + numeroNumero, 'I');
            }
            else if (numero > 3)
            {
                numerosRomano = numerosRomano.PadRight(++lng, 'I');
                numerosRomano = numerosRomano.PadRight(++lng, 'V');
            }
            else if (numero > 0)
            {
                numerosRomano = numerosRomano.PadRight(lng + numero, 'I');
            }

            Console.WriteLine(numerosRomano);
        }
    }
}
