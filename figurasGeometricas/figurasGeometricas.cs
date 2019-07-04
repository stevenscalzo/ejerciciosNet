namespace figurasGeometricas
{
    public abstract class Forma
    {
        public Forma()
        {

        }
        public Forma(double perimetro, double area)
        {
            this.setPerimetro(perimetro);
            this.setArea(area);
        }

        public abstract void draw();

        private double area;
        private double perimetro;







        public double getPerimetro()
        {
            return this.perimetro;
        }

        public double getArea()
        {
            return this.area;
        }






        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public void setArea(double area)
        {
            this.area = area;
        }

        public override string ToString()
        {
            return  string.Format("base es {0} y perimetro eso {1}", this.area, this.perimetro);
        }

    }
}