// Fecha 01/07/2019
/*
Hola
soy
un
comentario
de
muchas
lineas
 */
using System;

namespace _1HelloWorld
{
    class Program
    {
        const double PI = 3.14;
        const double numb1 = 3;
        const double numb2 = 2;

        static void Main(String[] args)
        {
            String nombre = "Steven Scalzo";

            //Int16 numero1 = Convert.ToInt16(args[0]);
            //Int16 numero2 = Convert.ToInt16(args[1]);
            //Int32 resultado = numero1 * numero2;
            Int32 numero4 = Convert.ToInt16(args[0]);

            double numero3= 123456.8;
            int a;
            a = (int)numero3;
            string cadena = "123456789";
            var numb4 = cadena.IndexOf("3", numero4);
            
            Console.WriteLine(nombre);
            // Console.WriteLine(PI);
            // dotnet run valor1 valor2
            // Console.WriteLine(numb2 * numb1);
            // Console.WriteLine("El resultado es: \n \"soy una comilla\" " + (numero1 * numero2));
            Console.WriteLine(a);
            // primer parametro es el lugar de inicio y el segundo es la longitud
            Console.WriteLine(cadena.Substring(2,numb4));
            Console.WriteLine(numb4);

            




        }
    }
}
