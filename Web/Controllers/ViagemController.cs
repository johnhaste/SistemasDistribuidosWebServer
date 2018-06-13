using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourismWeb.Models;

namespace Web.Controllers
{
    public class ViagemController : ApiController
    {
        public static Viagem[] viagens = new Viagem().RetornaViagens();

        public Viagem[] RetornaViagens()
        {
            return viagens;
        }

        // GET: api/Viagem
        public IEnumerable<Viagem> Get()
        {
            return viagens.ToList();
        }

        // GET: api/Viagem/5
        public Viagem Get(int id)
        {
            return viagens.SingleOrDefault(i => i.Id == id);
        }

        // POST: api/Viagem
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Viagem/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Viagem/5
        public void Delete(int id)
        {
        }
    }
}
