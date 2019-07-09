using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Pez : IEquatable<Pez>
    {
        public string nombre { get; set; }
        public string color { get; set; }
        public bool Equals(Pez other)
        {
            return this.color == other.color && this.nombre == other.nombre;
        }

        public override string ToString()
        {
            return this.nombre + ", " + this.color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             string[] input = {"Brachiosaurus",
            "Amargasaurus",
            "Mamenchisaurus",
            "Pecesaurio",
            "Nemo"};
            
            List<Pez> peces = new List<Pez>(input);


            peces.Add("Dory");
            Console.WriteLine(peces.Capacity);
            Console.WriteLine(peces.Count);
            Console.WriteLine(peces.Contains("Nemo"));
            peces.Remove("Pecesaurio"); 
            foreach(var pez in peces)
            {
            Console.WriteLine(pez);

            }
            */
            /*
            List<Pez> peces = new List<Pez>();
            Pez nemo = new Pez() { nombre= "nemo", color = "naranja"};
            Pez dorada = new Pez() { nombre= "dorada", color = "dorada" };

            peces.Add(nemo);
            peces.Add(dorada);

            //peces.Remove(new Pez() { nombre = "dorada", color = "dorada" });
            bool encontrado = peces.Contains(new Pez() { nombre = "dorada", color = "dorada" });
            Console.WriteLine(encontrado? "Encontrado" : "No encontrado");
            */

            /*
            List<string> peces = new List<string> { "anguila", "besugo" };
            List<int> numeroLetras = peces.ConvertAll<int>(p => p.Length);
            foreach (var pez in numeroLetras)
            {
                Console.WriteLine(pez);

            }
            int contador = 0;
            List<int> numeroPeces = peces.ConvertAll<int>(p => contador++);
            Console.WriteLine(contador);
            */

            Dictionary<string, Pez> pecesitos = new Dictionary<string, Pez>();

            pecesitos.Add("nemo", new Pez() { nombre = "dorada", color = "dorada" });

            /*
            foreach (var pez in pecesitos)
            {
                Console.WriteLine(pez.Key);
                Console.WriteLine(pez.ToString());

                Console.WriteLine(pez.Value.nombre);
                Console.WriteLine(pez.Value.color);

            }
            */

            Pez encontrado;
            bool seEncontro = pecesitos.TryGetValue("nemo", out encontrado);
            if (seEncontro)
            {
                Console.WriteLine("Encontrado");
            }
            else
            {
                Console.WriteLine("no existe ese pescesito");
            }

        }
    }
}
