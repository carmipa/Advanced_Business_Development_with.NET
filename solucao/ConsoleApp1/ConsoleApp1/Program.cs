using System;
using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    internal class Program

    {   // digite a barra 3x para criar um bloco de comentário
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pessoa _pessoa = new Pessoa();
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public int calcular()
        {
            return 1 + 1;
        }
    }
}