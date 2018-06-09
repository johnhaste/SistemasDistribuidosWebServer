using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Livro
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public Livro[] livros;


        public Livro[] RetornaLivros() {
            livros = new Livro[]
            {
                new Livro { Id = 1, Nome = "Livro 123", Categoria = "Sci-Fi", Preco= 45.60M },
                new Livro { Id = 2, Nome = "Livro 456", Categoria = "Drama", Preco = 23.75M },
                new Livro { Id = 3, Nome = "Livro 789", Categoria = "Ação", Preco = 19.90M }
            };
            return livros;
        }


    }
}