
using CalculoAreaTriangulo.Classes;
using System.Globalization;

namespace CalculoAreaTriangulo.main;

public class Program
{
    static void Main(string[] args)
    {

        // com orientação a objetos

        Triangulo x, y;

        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pX = (x.A + x.B + x.C) / 2.0;
        double aX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));

        double pY = (y.A + y.B + y.C) / 2.0;
        double aY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

        Console.WriteLine("Área de X = " + aX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + aY.ToString("F4", CultureInfo.InvariantCulture));

        if (aX > aY)
        {
            Console.WriteLine($"Maior área: X ({pX})");
        }
        else
        {
            Console.WriteLine($"Maior área: Y ({pY})");
        }

    }
}