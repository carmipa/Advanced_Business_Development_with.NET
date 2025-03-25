using System;
using ProjetoCompleto.Classes;

namespace ProjetoCompleto;

internal class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        pessoa.Nome = "Carlos";
        pessoa.Idade = 25;

        pessoa.Apresentar();

        // Pessoa2

        Pessoa2 p = new Pessoa2();
        p.DefinirNome("Ana");
        
        // Pessoa3

        Pessoa p3 = new Pessoa();
        p3.Apresentar();

    }
}