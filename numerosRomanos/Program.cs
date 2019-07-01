using System;

namespace numerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 numero = Convert.ToInt16(args[0]);
            string numerosRomano = "";
            
            int miles = numero / 1000;
            if (miles > 0)
            {
                numerosRomano = numerosRomano.PadLeft(miles, 'M');
                numero = numero % miles;
            }

            int cientos = numero / 100;
            if (cientos > 8)
            {
                numerosRomano = numerosRomano.PadRight(1, 'C');
                numerosRomano = numerosRomano.PadRight(1, 'M');
                numero = numero % cientos;
            } else if(cientos >= 5){
                int numeroCientos = cientos - 5;
                numerosRomano = numerosRomano.PadRight(1, 'D');
                numerosRomano = numerosRomano.PadRight(numeroCientos, 'C');
                numero = numero % cientos;

            } else if(cientos > 3){
                numerosRomano = numerosRomano.PadRight(1, 'C');
                numerosRomano = numerosRomano.PadRight(1, 'D');
                numero = numero % cientos;
            } else{
                numerosRomano = numerosRomano.PadRight(cientos, 'C');
                numero = numero % cientos;
            }

            int decadas = numero / 10;
            if (decadas > 8)
            {
                numerosRomano = numerosRomano.PadRight(1, 'X');
                numerosRomano = numerosRomano.PadRight(1, 'C');
                numero = numero % decadas;
            } else if(decadas >= 5){
                int numeroDecadas = decadas - 5;
                numerosRomano = numerosRomano.PadRight(1, 'L');
                numerosRomano = numerosRomano.PadRight(numeroDecadas, 'X');
                numero = numero % decadas;

            } else if(decadas > 3){
                numerosRomano = numerosRomano.PadRight(1, 'X');
                numerosRomano = numerosRomano.PadRight(1, 'L');
                numero = numero % decadas;
            } else{
                numerosRomano = numerosRomano.PadRight(decadas, 'X');
                numero = numero % decadas;
            }

            if (numero > 8)
            {
                numerosRomano = numerosRomano.PadRight(1, 'I');
                numerosRomano = numerosRomano.PadRight(1, 'X');
               
            } else if(numero >= 5){
                int numeroNumero = numero - 5;
                numerosRomano = numerosRomano.PadRight(1, 'V');
                numerosRomano = numerosRomano.PadRight(numeroNumero, 'I');
               

            } else if(numero > 3){
                numerosRomano = numerosRomano.PadRight(1, 'I');
                numerosRomano = numerosRomano.PadRight(1, 'V');
            } else{
                numerosRomano = numerosRomano.PadRight(cientos, 'I');
            }





            Console.WriteLine(numerosRomano);


        }
    }
}
