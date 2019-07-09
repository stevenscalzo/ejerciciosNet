using System;

namespace Empresas
{
    class Empresa : IEquatable<Empresa>
    {
        public string nombre { get; set; }
        public string anyodefundacion { get; set; }
        public bool Equals(Empresa other)
        {
            return this.nombre == other.nombre && this.anyodefundacion == other.anyodefundacion;
        }

        public override string ToString()
        {
            return this.nombre + ", " + this.anyodefundacion;
        }
    }
    class Empleado : IEquatable<Empleado>
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string fechanacimiento { get; set; }
        public string fechaContrato { get; set; }

        public bool Equals(Empleado other)
        {
            return this.nombre == other.nombre && this.apellidos == other.apellidos && 
                this.fechanacimiento == other.fechanacimiento && this.fechaContrato == other.fechaContrato;
        }

        public override string ToString()
        {
            return this.nombre + ", " + this.apellidos + ", " + this.fechanacimiento + ", " + this.fechaContrato;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo opcion;
            do
            {

                Console.WriteLine("\nBienvenido");
                Console.WriteLine("Selecione una opcion:");
                Console.WriteLine("1- Crear nueva empresa");
                Console.WriteLine("2- Añadir empleado a empresa existente");
                Console.WriteLine("3- Listado de empresas");
                Console.WriteLine("4- Informacion de una empresa en particular");
                Console.WriteLine("5- Crear empleado");
                Console.WriteLine("6- Listado de empleados");
                Console.WriteLine("7- Información de un empleado en particular");
                Console.WriteLine("8- Salir");

                opcion = Console.ReadKey();

                if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1)
                {
                    crearEmpresa();
                }
                else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
                {
                    añadirEmpleadoAEmpresa();
                }
                else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
                {
                    listaEmpresas();
                }
                else if (opcion.Key == ConsoleKey.D4 || opcion.Key == ConsoleKey.NumPad4)
                {
                    informacionDeEmpresa();
                }
                else if (opcion.Key == ConsoleKey.D5 || opcion.Key == ConsoleKey.NumPad5)
                {
                    crearEmpleado();
                }
                else if (opcion.Key == ConsoleKey.D6 || opcion.Key == ConsoleKey.NumPad6)
                {
                    listaEmpleados();
                }
                else if (opcion.Key == ConsoleKey.D7 || opcion.Key == ConsoleKey.NumPad7)
                {
                    informacionDeEmpleado();
                }
                else if (opcion.Key == ConsoleKey.D8 || opcion.Key == ConsoleKey.NumPad8)
                {
                    Console.WriteLine("\n\nVuelva pronto");
                }
                else
                {
                    Console.WriteLine("\nOpcion no valida\n");
                }



            } while (opcion.Key != ConsoleKey.D8 && opcion.Key != ConsoleKey.NumPad8);

            void crearEmpresa()
            {

            }
            void añadirEmpleadoAEmpresa()
            {

            }
            void listaEmpresas()
            {

            }
            void informacionDeEmpresa()
            {

            }
            void crearEmpleado()
            {

            }
            void listaEmpleados()
            {

            }
            void informacionDeEmpleado()
            {

            }
        }
    }
}
