using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotaAluno.Classes
{
    /// <summary>
    /// Classe que representa um aluno
    /// </summary>
    class Aluno
    {
        public string Nome { get; set; }
        public int  Idade { get; set; }
        public List<double> Notas { get; set; }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Aluno()
        {
        }

        /// <summary>
        /// Construtor que recebe o nome e a idade do aluno
        /// </summary>
        /// <param name="nome"> Nome do aluno</param>
        /// <param name="idade"> Idade do aluno</param>
        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Notas = new List<double>();
        }

        /// <summary>
        /// Método que retorna as informações do aluno
        /// </summary>
        /// <returns>retorna uma mensagem com o nome e a idade do aluno</returns>
        public string ObterInformaçoes()
        {
            return $"Nome: {Nome}, Idade: {Idade} anos";
        }



    }
}
