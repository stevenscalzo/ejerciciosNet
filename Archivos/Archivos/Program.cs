using System.IO;

namespace Archivos
{
    class Program
    {


        static void Main(string[] args)
        {
            /*
            if (!Directory.Exists("c:/tests/"))
            {
                System.Console.WriteLine("No existe");
                Directory.CreateDirectory("c:/tests/");
            }
            else
            {
                System.Console.WriteLine("El directorio existe");
            }
            */
            /*
            var direcories = Directory.GetDirectories("c:/");
            foreach (string d in direcories)
            {
                System.Console.WriteLine(d);
            }

            */
            /*
            var files = Directory.GetFiles("c:/");
            foreach (string d in files)
            {
                System.Console.WriteLine(d);
            }
            */



            /*
            string directorio = "C:/Users/formacion.GTT/Documents/Clases";

            siExiste(directorio);








            void siExiste(string directorioE)
            {

                if (!Directory.Exists(directorioE))
                {
                    System.Console.WriteLine("\nNo existe\n");
                }
                else
                {
                    System.Console.WriteLine("\nDirectorios y files de {0}\n", directorioE);
                    var files = Directory.GetFiles(directorioE);
                    if (files.Length > 0)
                    {
                        System.Console.WriteLine("\nEstos son sus files:\n");
                        foreach (string d in files)
                        {
                            System.Console.WriteLine(d);
                        }
                    } else
                    {
                        System.Console.WriteLine("\nNo tiene files\n");
                    }


                    var direcories = Directory.GetDirectories(directorioE);
                    if (direcories.Length > 0)
                    {
                        System.Console.WriteLine("\nEstos son sus directorios:\n");
                        foreach (string d in direcories)
                        {
                            System.Console.WriteLine(d);
                        }
                        foreach (string d in direcories)
                        {
                            siExiste(d);
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("\nNo tiene directorios dentro\n");
                    }


                }


            }*/
            //File.WriteAllText("c:/tests/hello.txt", "Hola mundo");
            File.AppendAllText("c:/tests/hello.txt", "\nAdios mundo");
        }
    }
}
