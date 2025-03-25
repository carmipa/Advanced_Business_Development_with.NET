using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using CalculoValorCompra.classes;

namespace CalculoValorCompra
{
    internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual a cotação do dollar: ");
        double contacaoDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Quantos dolares você vai comprar: ");
        double quantidadeDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double ValorfINAL = ConversorDeMoedas.DolarParaReal(quantidadeDollar, quantidadeDollar);

        Console.WriteLine($"Valor a ser pago em reais = {ValorfINAL.ToString("F2", CultureInfo.InstalledUICulture)}");

    }
}
}



