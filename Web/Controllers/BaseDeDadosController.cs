using Newtonsoft.Json;
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
        //public static Object[] compraViagens = new CompraViagemController().RetornaComprasViagens();
        //public static Object[] ticketViagens = new HospedagemController().retornaTicketsViagens();

        // GET: api/BaseDeDados
        public string Get()
        {
            //EXEMPLO MUDANDO UMA PROPRIEDADE IN MEMORY
            //LocalController.MudaIdLocal();
            //string locaisJson = JsonConvert.SerializeObject(locais);

            /*
            //Cria um array maior somando o tamanho de todos
            Object[] BaseDeDados = new Object[locais.Length + hospedagens.Length];

            //Copia o primeiro array de locais para o novo array grandão
            //(quem, para onde, quantos elementos)
            Array.Copy(locais, BaseDeDados, locais.Length);

            //Copia o segundo array de hospedagens para o novo array grandão
            Array.Copy(hospedagens, 0, BaseDeDados, locais.Length, hospedagens.Length);
            
            return BaseDeDados;
            */


            string locaisJson = JsonConvert.SerializeObject(locais);

            return " 'locais' : " + locaisJson;
            
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

    //Tentativa de Interface para usar locais[0].id = 4
    /*
     * public interface ILocal
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Cidade { get; set; }
        string Estado { get; set; }
        string Pais { get; set; }
    }
    */

    public class ILocal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }

}
