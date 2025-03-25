using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompleto.Classes
{
    class Pessoa2
    {
        private string Nome { get; set; }

        public void DefinirNome(String novoNome)
        {
            Nome = novoNome; 
        }

        public void ExibirNome()
        {
            Console.WriteLine("Nome: " + Nome);
        }
    }
}
