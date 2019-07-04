using System;

namespace vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Bienvendino a Cars Steven, ¿desea comprar un Vehiculo?");
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1 - Comprar un Vehiculo");
            Console.WriteLine("2 - Salir del sistema");
            opcion = Int32.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                byte numeroDeRuedas;
                ushort capacidad;
                ushort numeroDePuertas;
                int combustible;
                int respuesta;
                bool esAutomatico;
                ushort velocidadMaxima;
                string color;
                Vehiculo coche = new Vehiculo();
                Console.WriteLine("En Cars Steven puedes crear tu propio vehiculo");
                Console.WriteLine("¿Cuanta ruedas quieres en tu vehiculo?");
                numeroDeRuedas = byte.Parse(Console.ReadLine());
                coche.setNumeroDeRuedas(numeroDeRuedas);

                Console.WriteLine("¿Que capacidad deseas para tu vehiculo?");
                capacidad = ushort.Parse(Console.ReadLine());
                coche.setCapacidad(capacidad);

                Console.WriteLine("¿Cuantas puertas deseas para tu vehiculo?");
                numeroDePuertas = ushort.Parse(Console.ReadLine());
                coche.setNumeroDePuertas(numeroDePuertas);

                Console.WriteLine("Elije el combustible que prefieres:");
                Console.WriteLine("1 - Electrico");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Gas");
                combustible = int.Parse(Console.ReadLine());
                coche.setCombustible(combustible);

                Console.WriteLine("¿Quieres que tu vehiculo sea automatico?");
                Console.WriteLine("1 - Si");
                Console.WriteLine("2 - No");
                respuesta = int.Parse(Console.ReadLine());
                if(respuesta == 1){
                    esAutomatico = true;
                } else{
                    esAutomatico = false;
                }
                coche.isEsAutomatico(esAutomatico);

                Console.WriteLine("¿Velocidad maxima en km/h deseas para tu vehiculo?");
                velocidadMaxima = ushort.Parse(Console.ReadLine());
                coche.setVelocidadMaxima(velocidadMaxima);

                Console.WriteLine("Por ultmio... ¿De que color quieres tu vehiculo?");
                Console.WriteLine("El color se debe representar en forma hexadecimal");
                color = Console.ReadLine();
                coche.setColor('#' + color);

                Console.WriteLine("¡Felicidades! tu automovil fue creado con exito");
                Console.WriteLine("Tu vehiculo tiene las siguientes especificaciones:");
                Console.WriteLine("Numero de ruedas: "+ coche.getNumeroDeRuedas());
                Console.WriteLine("Capacidad: "+ coche.getCapacidad());
                Console.WriteLine("Numero de puertas: "+ coche.getNumeroDePuertas());
                Console.WriteLine("Tipo de combustible: "+ coche.getCombustible());
                Console.WriteLine("Automatico: "+ coche.getEsAutomatico());
                Console.WriteLine("Velocidad maxima: "+ coche.getVelocidadMaxima());
                Console.WriteLine("Color: #"+ coche.getColor());
                









            }
            else
            {

                System.Console.WriteLine("Adios. Vuelva pronto");
            }



        }
    }
}
