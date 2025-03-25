using System.Globalization;
using CalculoAreaTriangulo.Classes;

internal class Program
{
    static void Main(string[] args)
    {

        // sem orientação a objetos

        double xA, xB, xC;
        double yA, yB, yC; // poderia ser na mesma linha de cima

        Console.WriteLine("Entre com as medidas do triângulo X:");
        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        // formula de heron

        // area de X
        double p = (xA + xB + xC) / 2.0;

        double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

        // area de Y
        double p2 = (yA + yB + yC) / 2.0;

        double areaY = Math.Sqrt(p2 * (p2 - yA) * (p2 - yB) * (p2 - yC));

        Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        // F4 é para mostrar 4 casas decimais

        Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY)
        {
            Console.WriteLine($"Maior área: X ({p})");
        }
        else
        {
            Console.WriteLine($"Maior área: Y ({p2})");
        }

        


    }
}


