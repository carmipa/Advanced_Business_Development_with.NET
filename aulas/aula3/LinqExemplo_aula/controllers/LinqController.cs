using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqApiExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqController : ControllerBase
    {
        // Dados estáticos para os exemplos
        private static readonly List<Livro> livros = new List<Livro>
        {
            new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", Categoria = "Fantasia", AnoPublicacao = 1954, Preco = 60.00m, EditoraID = 1 },
            new Livro { Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", Categoria = "Fantasia", AnoPublicacao = 1997, Preco = 45.00m, EditoraID = 2 },
            new Livro { Titulo = "A Revolução dos Bichos", Autor = "George Orwell", Categoria = "Ficção", AnoPublicacao = 1945, Preco = 35.00m, EditoraID = 3 },
            new Livro { Titulo = "1984", Autor = "George Orwell", Categoria = "Ficção", AnoPublicacao = 1949, Preco = 40.00m, EditoraID = 3 },
            new Livro { Titulo = "Dom Casmurro", Autor = "Machado de Assis", Categoria = "Romance", AnoPublicacao = 1899, Preco = 25.00m, EditoraID = 4 },
            new Livro { Titulo = "O Cortiço", Autor = "Aluísio Azevedo", Categoria = "Romance", AnoPublicacao = 1890, Preco = 30.00m, EditoraID = 4 },
            new Livro { Titulo = "Clean Code", Autor = "Robert C. Martin", Categoria = "Tecnologia", AnoPublicacao = 2008, Preco = 55.00m, EditoraID = 5 },
            new Livro { Titulo = "Refactoring", Autor = "Martin Fowler", Categoria = "Tecnologia", AnoPublicacao = 1999, Preco = 65.00m, EditoraID = 5 },
            new Livro { Titulo = "A Game of Thrones", Autor = "George R. R. Martin", Categoria = "Fantasia", AnoPublicacao = 1996, Preco = 70.00m, EditoraID = 1 },
            new Livro { Titulo = "The Pragmatic Programmer", Autor = "Andrew Hunt", Categoria = "Tecnologia", AnoPublicacao = 1999, Preco = 50.00m, EditoraID = 5 }, 
            new Livro { Titulo = "Livro Moderno", Autor = "Autor Atual", Categoria = "Tecnologia", AnoPublicacao = 2020, Preco = 75.00m, EditoraID = 6 }

        };

        private static readonly List<Editora> editoras = new List<Editora>
        {
            new Editora { EditoraID = 1, Nome = "Editora Fantasia" },
            new Editora { EditoraID = 2, Nome = "Magic Books" },
            new Editora { EditoraID = 3, Nome = "Classic Reads" },
            new Editora { EditoraID = 4, Nome = "Literatura Brasileira" },
            new Editora { EditoraID = 5, Nome = "Tech Books" }
        };

        // 1. Filtro Simples (Where) - Livros de categoria 'Fantasia'
        [HttpGet("filtro")]
        public IActionResult GetFiltro()
        {
            var resultado = livros
                .Where(l => l.Categoria == "Fantasia")
                .Select(l => new { l.Titulo, l.Autor });
            return Ok(resultado);
        }


    // Modelo para Livro
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public int AnoPublicacao { get; set; }
        public decimal Preco { get; set; }
        public int EditoraID { get; set; }
    }

    // Modelo para Editora
    public class Editora
    {
        public int EditoraID { get; set; }
        public string Nome { get; set; }
    }
        public class XmlRequest
    {
        public string XmlData { get; set; }
    }
}
}
