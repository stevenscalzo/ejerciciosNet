using System;

namespace _3Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 lng = Convert.ToInt16(args.Length);
            float suma = 0;

            foreach (string item in args)
            {
                // Int32 number = Int32.Parse(item);
                // suma += number;
                suma += Convert.ToInt16(item);
            }
            float promerdio = suma / lng;
            Console.WriteLine(promerdio);
        }
    }
}

