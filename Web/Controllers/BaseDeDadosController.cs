using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web;

namespace Web.Controllers
{
    public class BaseDeDadosController : ApiController
    {
        public static Object[] locais = new LocalController().RetornaLocais();

        public static Object[] hospedagens = new HospedagemController().RetornaHospedagens();
        public static Object[] compraHospedagens = new CompraHospedagemController().RetornaComprasHospedagens();
        //public static Object[] ticketHospedagens = new HospedagemController().retornaTicketsHospedagens();

        public static Object[] viagens = new ViagemController().RetornaViagens();
        public static Object[] compraViagens = new CompraViagemController().retornaComprasViagens();
        //public static Object[] ticketViagens = new HospedagemController().retornaTicketsViagens();

        // GET: api/BaseDeDados
        public Object[] Get()
        {
            return hospedagens;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/BaseDeDados/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BaseDeDados
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BaseDeDados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BaseDeDados/5
        public void Delete(int id)
        {
        }
    }
}
