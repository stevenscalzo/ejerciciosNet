namespace figurasGeometricas
{
    public class Triangulo : Forma
    {
        private double b;
        private double h;
        private double lado1;
        private double lado2;


        

        public Triangulo(double b, double h, double lado1, double lado2) :
            base(b + lado1 + lado2, b * h / 2)
        {
            this.b = b;
            this.h = h;
            this.lado1 = lado1;
            this.lado2 = lado2;

        }

        public override string ToString()
        {
            return string.Format(
                "Esto es un triangulo de area es {0} y perimetro eso {1} con base {2}, altura {3} y lados {4} y {5} ",
            base.getArea(), base.getPerimetro(), this.b, this.h, this.lado1, this.lado2);
        }

        public override void draw(){System.Console.WriteLine(" ");}  

        public double getH()
        {
            return this.h;
        }

        public double getB()
        {
            return this.b;
        }

        public double getLado1()
        {
            return this.lado1;
        }

        public double getLado2()
        {
            return this.lado2;
        }





        public void setLado2(double lado2)
        {
            this.lado2 = lado2;
        }

        public void setLado1(double lado1)
        {
            this.lado1 = lado1;
        }

        public void setH(double h)
        {
            this.h = h;
        }

        public void setB(double b)
        {
            this.b = b;
        }

    }
}