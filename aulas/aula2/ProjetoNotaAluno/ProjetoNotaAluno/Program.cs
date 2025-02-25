using System;
using ProjetoNotaAluno.Classes;

namespace ProjetoNotaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aluno Aluno = new Aluno();

            Console.WriteLine("=== Sistema de cadastro de alunos e notas ===");
            Console.WriteLine();

            bool continuar = true;

            // Enquanto a variável continuar for true, o programa continuará rodando
            // enquanto for false, o programa encerrará
            while (continuar)
            {

                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                
                
                Console.Write("Digite a idade do aluno: ");
                // int idade = int.Parse(Console.ReadLine());
                
                if (!int.TryParse(Console.ReadLine(),out int idade))
                {
                    Console.WriteLine("Idade inválida! Tente novamente");
                }
                
                Aluno aluno = new Aluno(nome, idade);

                Console.WriteLine(aluno.ObterInformaçoes());
                Console.WriteLine();
                
                //0 > nota1
                //1 > nota2
                // 2 > nota3
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(i);
                }

                
            }


        }
    }
}