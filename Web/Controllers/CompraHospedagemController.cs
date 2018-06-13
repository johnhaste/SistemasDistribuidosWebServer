using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourismWeb.Models;

namespace Web.Controllers
{
    public class CompraHospedagemController : ApiController
    {
        public static CompraHospedagem[] comprasHospedagens = new CompraHospedagem().RetornaComprasHospedagens();

        public CompraHospedagem[] RetornaComprasHospedagens()
        {
            return comprasHospedagens;
        }

        // GET: api/CompraHospedagem
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CompraHospedagem/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CompraHospedagem
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CompraHospedagem/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CompraHospedagem/5
        public void Delete(int id)
        {
        }
    }
}
