namespace figurasGeometricas
{
    public class Rectangulo : Forma
    {
        private double b;
        private double h;

        public override void draw()
        {
            for (int i = 0; i < this.h; i++)
            {
                if (i == 0 || i == (this.h - 1))
                {
                    for (int j = 0; j < this.b; j++)
                    {

                        if (j == (this.b - 1))
                        {
                            System.Console.WriteLine("▒▒▒▒▒▒▒▒");
                        }
                        else
                        {
                            System.Console.Write("▒▒");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < this.b; j++)
                    {
                        if (j == 0)
                        {
                            System.Console.Write("▓");

                        }
                        else if (j == (this.b - 1))
                        {
                            System.Console.WriteLine("▓");
                        } else{
                            System.Console.Write("   ");
                        }
                    }

                }
            }
        }

        public Rectangulo(double b, double h) : base(b * 2 + 2 * h, b * h)
        {
            this.b = b;
            this.h = h;

        }

        public override string ToString()
        {
            return string.Format("Esto es un rectangulo de area es {0} y perimetro eso {1} con base {2} y altura {3} ",
            base.getArea(), base.getPerimetro(), this.b, this.h);
        }


        public double getH()
        {
            return this.h;
        }

        public double getB()
        {
            return this.b;
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