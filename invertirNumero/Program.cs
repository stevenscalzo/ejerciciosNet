using System;

namespace invertirNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;

            Console.WriteLine("Introduzca un numero:");
            numero = Console.ReadLine();
            int[] digitos = new int[numero.Length];

            int i = 1;
            int j = 0;
            foreach (char caracter in numero)
            {
                j = numero.Length - i;
                digitos[j] = Int32.Parse(caracter.ToString());
                i++;
            }
            string inversa = string.Join("", digitos);
            System.Console.WriteLine(inversa);

        }
    }
}
