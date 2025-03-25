namespace ProjetoCompleto.Classes;

 class Pessoa3
{
    public string Nome { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="nome"></param>
    public Pessoa3(string nome)
    {
        Nome = nome;
    }

    public void Apresentar()
    {
        Console.WriteLine($"O nome da pessoa é: {Nome}");
    }

}