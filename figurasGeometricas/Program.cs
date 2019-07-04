using System;

namespace figurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
        // Forma f = new Forma();
        double b = 10;
        double h = 5;
        double lado1 = 2;
        double lado2 = 5;
        Forma r = new Rectangulo(b ,h);
        Forma c = new Cuadrado(b);
        Forma t = new Triangulo(b,h, lado1, lado2);


        System.Console.WriteLine(c);
        System.Console.WriteLine(r);
        System.Console.WriteLine(t);

        r.draw();
        t.draw();

        }
    }
}
