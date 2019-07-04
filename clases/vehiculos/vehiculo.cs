namespace vehiculos
{
    enum combustiblesDisponibles { electrico = 1, gasolina, diesel, gas };
    public class Vehiculo
    {
        public Vehiculo()
        {
            this.numeroDeRuedas = 4;
            this.numeroDePuertas = 3;
        }
        public Vehiculo(byte numeroDeRuedas, ushort numeroDePuertas)
        {
            this.numeroDeRuedas = numeroDeRuedas;
            this.numeroDePuertas = numeroDePuertas;
        }
        private byte numeroDeRuedas;
        private ushort capacidad;
        private ushort numeroDePuertas;
        private string combustible;
        private bool esAutomatico;
        private ushort velocidadMaxima;
        private bool encendido = false;
        private string color;
        private byte numeroVolantes = 1;









        public byte getNumeroDeRuedas()
        {
            return this.numeroDeRuedas;
        }
        public ushort getCapacidad()
        {
            return this.capacidad;
        }
        public ushort getNumeroDePuertas()
        {
            return this.numeroDePuertas;
        }
        public string getCombustible()
        {
            return this.combustible;
        }
        public bool getEsAutomatico()
        {
            return this.esAutomatico;
        }
        public ushort getVelocidadMaxima()
        {
            return this.velocidadMaxima;
        }
        public byte getNumeroVolantes()
        {
            return this.numeroVolantes;
        }
        public bool getEncendido()
        {
            return this.encendido;
        }
        public string getColor()
        {
            return this.color;
        }






        public void setNumeroDeRuedas(byte numeroDeRuedas)
        {
            System.Console.WriteLine(numeroDeRuedas);
            this.numeroDeRuedas = numeroDeRuedas;
            System.Console.WriteLine(this.numeroDeRuedas);
        }
        public void setCapacidad(ushort capacidad)
        {
            this.capacidad = capacidad;
        }
        public void setNumeroDePuertas(ushort numeroDePuertas)
        {
            this.numeroDePuertas = numeroDePuertas;
        }
        public void setCombustible(int tipo)
        {
           
            switch (tipo)
            {
                case 1:
                    this.combustible = "electrico";
                    break;
                case 2:
                    this.combustible = "gasolina";
                    break;
                case 3:
                    this.combustible = "diesel";
                    break;
                case 4:
                    this.combustible = "gas";
                    break;
                default:
                    this.combustible = "gasolina";
                    break;
            }
        }
        public void isEsAutomatico(bool esAutomatico)
        {
            this.esAutomatico = esAutomatico;
        }
        public void setVelocidadMaxima(ushort velocidadMaxima)
        {
            this.velocidadMaxima = velocidadMaxima;
        }
        public void setNumeroVolantes(byte numeroVolantes)
        {
            this.numeroVolantes = numeroVolantes;
        }
        public void isEncendido(bool encendido)
        {
            this.encendido = encendido;
        }
        public void setColor(string color)
        {
            this.color = color;
        }



        public void arrancar()
        {
            if (!encendido)
            {
                encendido = true;
                System.Console.WriteLine("Vehiculo encendido sin problema \nruuuuuuuunnnnn!!!!");
            }
            else
            {
                System.Console.WriteLine("El vehiculo ya estaba encendido");
            }
        }


    }
}