using System.Globalization;
using CalculoAreaTriangulo.Classes;



namespace CalculoAreaTriangulo.main
{
    class Program
    {
        static void Main(string[] args)
        {

            // com orientação a objetos

            Triangulo primeiroTriangulo = new Triangulo();
            Triangulo segundoTriangulo = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            primeiroTriangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            primeiroTriangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            primeiroTriangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            segundoTriangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            segundoTriangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            segundoTriangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaDoPrimeiroTriangulo = primeiroTriangulo.CalcularAreaDoTriangulo();
            double areaDoSegundoTriangulo = segundoTriangulo.CalcularAreaDoTriangulo();

            string mensagem1 = primeiroTriangulo.MensagemAreaDoTrianguloForma1("Area do primeiro triângulo = ", areaDoPrimeiroTriangulo);
            string mensagem2 = segundoTriangulo.MensagemAreaDoTrianguloForma1("Area do segundo triângulo = ", areaDoSegundoTriangulo);

            Console.WriteLine(mensagem1);
            Console.WriteLine(mensagem2);

            primeiroTriangulo.MensagemAreaDoTrianguloForma2("Mensagem 2 da area do primeiro triângulko = ", areaDoPrimeiroTriangulo);
            segundoTriangulo.MensagemAreaDoTrianguloForma2("Mensagem 2 da area do segundo triângulo = ", areaDoSegundoTriangulo);


            Triangulo.verificaTrianguloMaior(areaDoPrimeiroTriangulo, areaDoSegundoTriangulo);

        }
    }
}
