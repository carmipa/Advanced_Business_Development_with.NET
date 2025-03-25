using System;

namespace ProjetoCompleto.Classes
{
    class Pessoa
    {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome} e tenho {Idade} anos.");
        }

    }
}
