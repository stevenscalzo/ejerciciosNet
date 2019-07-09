using System;

namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {
            //int? x = null;
            try
            {
                //Console.WriteLine("Null: " + x.Value);
            }
            catch (InvalidOperationException)
            {
               // x = 3;
                //Console.WriteLine("Null: " + x);
            }
            //bool? y = false;
            //Console.WriteLine("GetValue: " + x.GetValueOrDefault());
            //Console.WriteLine("Bool: " + y.GetValueOrDefault());
            
            
            //for(int i = 0; i <= 10; System.Console.WriteLine(i), i += 2 ){    
            //}
            //for(int i = 0; i <= 10;i ++ ){    
                //System.Console.WriteLine(i + (i % 3 == 0? " es mult de 3" : " no es multiplo de 3"));
            //}

            /* 
            int numero1;
            int numero2;
            int numero3;

            Console.WriteLine("Introduzca el primer número:");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número:");
            numero2 = Int32.Parse(Console.ReadLine());

            if(numero1 < numero2){
                numero3 = numero1;
                numero1 = numero2;
                numero2 = numero3;
            }
            System.Console.WriteLine("numero mayor: " + numero1 + " y numero menor: " + numero2);
            */
            /*
            int edad;
            int mayorDeEdad = 18;
            do{
            Console.WriteLine("Introduzca su edad:");
            edad = Int32.Parse(Console.ReadLine());
            } while(edad < mayorDeEdad);

            System.Console.WriteLine("ya eres mayor de edad");
            */

            

        }
    }
}

// FICHEROS


