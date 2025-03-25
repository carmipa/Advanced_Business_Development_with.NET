namespace CalculoValorCompra.classes;

public class ConversorDeMoedas
{
    public static double Iof = 6.0;

    public static double DolarParaReal(double quantia, double contacao)
    {
        double total = quantia * contacao;
        return total + total * Iof / 100.00;
    }
}