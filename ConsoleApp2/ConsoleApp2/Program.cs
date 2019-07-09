using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{

    class Palabra: IEquatable<Palabra>
    {
        public string palabra { get; set; }
        public string definicion { get; set; }
        public bool Equals(Palabra other)
        {
            return this.palabra == other.palabra && this.definicion == other.definicion;
        }

        public override string ToString()
        {
            return this.palabra + ": " + this.definicion;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo opcion;
            Dictionary<string, Palabra> palabras = new Dictionary<string, Palabra>();
            do
            {

                Console.WriteLine("\nBienvenido al Diccionario");
                Console.WriteLine("Selecione una opcion:");
                Console.WriteLine("1- Buscar palabra");
                Console.WriteLine("2- Añadir palabra");
                Console.WriteLine("3- Salir");

               

                opcion = Console.ReadKey();
                

                if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("\n\n¿Que palabra desea buscar?");
                    

                    buscarPalabra(Console.ReadLine());
                    

                }
                else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine("\n\nEscriba la palabra que desea añadir: ");
                    string palabraAAñadir = Console.ReadLine();
                    Console.WriteLine("\nAñada una definicion de la plabra: ");
                    string definicion = Console.ReadLine();

                    añadirPalabra(palabraAAñadir, definicion);

                } else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
                {
                    Console.WriteLine("\n\nVuelva pronto");
                } else
                {
                    Console.WriteLine("\nopcion no valida\n");
                }
            } while (opcion.Key != ConsoleKey.D3 && opcion.Key != ConsoleKey.NumPad3);
              


            void buscarPalabra (string palabraABuscar)
            {
                // esta opcion lee las lineas de un archivo txt 
                /*
                foreach (string line in File.ReadLines("c:/tests/hello.txt"))
                {
                    if (line.Contains(palabraABuscar + ","))
                    {
                        string[] arrayPalabra = line.Split(",");
                        Console.WriteLine(arrayPalabra[0] + ": " + arrayPalabra[1]);
                    }
                }
                */

                // esta linea lo guarda en un array dentro del programa que se borra al terminar de ejecutar

                // Palabra encontrado;
                //bool seEncontro = palabras.TryGetValue(palabraABuscar, out encontrado);
                //if (seEncontro)
                //{
                //    Console.WriteLine("\nEncontrado");
                //   Console.WriteLine(palabras[palabraABuscar] + "\n");
                //}
                //else
                //{
                //    Console.WriteLine("\nno existe esa palabra\n");
                //}
                Console.WriteLine(palabraABuscar.Length + " soy la longitud");
                StreamReader sr = new StreamReader("c:/tests/hello.txt");
                while (sr.Peek() >= 0)
                {
                    Console.Write((char)sr.Read());
                }
                sr.Close();
            }


            void añadirPalabra(string palabraAAñadir, string definicion)
            {
                Palabra encontrado;
                bool seEncontro = palabras.TryGetValue(palabraAAñadir, out encontrado);

                if (palabraAAñadir != "" && definicion != "" && !seEncontro)
                {

                    File.AppendAllText("c:/tests/hello.txt", palabraAAñadir + ", " + definicion + "\n");
                    //palabras.Add(palabraAAñadir, new Palabra() { palabra = palabraAAñadir, definicion = definicion });
                    Console.WriteLine("\npalabra {0} añadida \n", palabraAAñadir);
                }
                else
                {
                    Console.WriteLine("\nNo se pudo añadir la palabra\n");
                }
            }
        }
    }
}
