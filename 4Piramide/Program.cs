using System;

namespace _4Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 pisos = Convert.ToInt16(args[0]);
            string elementos = "";
           
            for(int i = 0; i < pisos; i++)
            {   
                int numeroEspacios = pisos - i - 1;
                int numeroAsteriscos = i * 2+ 1;
                string asteriscos = elementos.PadRight(numeroAsteriscos, '*');
                string espacios = elementos.PadLeft(numeroEspacios, ' ');
                
                Console.WriteLine(espacios + asteriscos);

            }
            
        }
    }
}
