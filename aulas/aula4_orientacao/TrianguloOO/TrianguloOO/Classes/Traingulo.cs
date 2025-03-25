using System.Diagnostics;
using System.Globalization;

namespace CalculoAreaTriangulo.Classes;

public class Triangulo
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public double CalcularAreaDoTriangulo()
    {
        double p = (A + B + C) / 2.0;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public void MensagemAreaDoTriangulo(string mensagemInicial, double areaDoTriangulo)
    {
        return mensagemInicial + areaDoTriangulo.ToString("F4", CultureInfo.InvariantCulture);
    }
}