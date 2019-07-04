using System;

namespace arrayNombres
{
    class Program
    {
        enum operaciones { suma = 1, resta, multiplicacion };
        static void Main()
        {
            //string[] nombresClase = {"David", "Manolo", "Victo", "Paz", "Miriam", "Steven", "Vero", "Nacho" };
            //string pegamento = "Nombre: ";
            //Console.WriteLine(pegamento + string.Join("\n" + pegamento, nombresClase));

            /*
            string[] arrayNumeros = new string[501];
            int lng = arrayNumeros.Length;
            int inicio = 100;
            for(int i = 0; i < lng; i++){
                arrayNumeros[i] = (inicio + i).ToString();
            }
            string pegamento = "Numero: ";
            Console.WriteLine(pegamento + int[] digitos = new int[11];);
             */


            int numero1;
            int numero2;
            operaciones opcion;

            Console.WriteLine("Introduzca el primer número:");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número:");
            numero2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            opcion = (operaciones)Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case operaciones.suma:
                    Console.WriteLine("El resultado es: " + (numero1 + numero2));
                    break;
                case operaciones.resta:
                    Console.WriteLine("El resultado es: " + (numero1 - numero2));
                    break;
                case operaciones.multiplicacion:
                    Console.WriteLine("El resultado es: " + (numero1 * numero2));
                    break;
                default:
                    Console.WriteLine("Error, debe ingresar un numero del 1 al 3");
                    break;
            }
        }
    }
}
