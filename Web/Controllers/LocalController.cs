using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourismWeb.Models;

namespace Web.Controllers
{
    public class LocalController : ApiController
    {
        public Local[] locais = new Local().RetornaLocais();
        
        public Local[] RetornaLocais()
        {
            return locais;
        }

        // GET: api/Local
        public IEnumerable<Local> Get()
        {
            return locais.ToList() ;
        }

        // GET: api/Local/5
        public Local Get(int id)
        {
            return locais.SingleOrDefault(i => i.Id == id);
        }

        // POST: api/Local
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Local/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Local/5
        public void Delete(int id)
        {
        
        }
    }
}
