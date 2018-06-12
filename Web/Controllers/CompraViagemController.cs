using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourismWeb.Models;

namespace Web.Controllers
{
    public class CompraViagemController : ApiController
    {

        CompraViagem[] comprasViagens = new CompraViagem().RetornaComprasViagens();

        public CompraViagem[] RetornaComprasViagens()
        {
            return comprasViagens;
        }

        // GET: api/CompraViagem
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CompraViagem/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CompraViagem
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CompraViagem/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CompraViagem/5
        public void Delete(int id)
        {
        }
    }
}
