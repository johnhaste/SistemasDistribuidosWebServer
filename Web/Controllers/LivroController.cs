using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Web.Models;

namespace Web.Controllers
{
    public class LivroController : ApiController
    {
        //Livros dummys para teste
        Livro[] baseDeLivros = new Livro().RetornaLivros();

        /*public IEnumerable<Livro> GetAllLivros()
        {
            return baseDeLivros;
        }*/

        public JsonResult GetAllLivros()
        {
            return baseDeLivros;
        }

        public Livro GetLivroById(int id)
        {
            var livro = baseDeLivros.FirstOrDefault((p) => p.Id == id);
            if (livro == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
                throw new HttpResponseException(resp);
            }
            return livro;
        }

        public IEnumerable<Livro> GetLivrosByCategory(string categoria)
        {
            return baseDeLivros.Where(
                (p) => string.Equals(p.Categoria, categoria,
                    StringComparison.OrdinalIgnoreCase));
        }
    }
}
