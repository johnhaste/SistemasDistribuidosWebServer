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
        public static List<CompraHospedagem> comprasHospedagens = new CompraHospedagem().RetornaComprasHospedagens().ToList();
        public static List<TicketHospedagem> ticketHospedagens = new List<TicketHospedagem>();

        public List<CompraHospedagem> RetornaComprasHospedagens()
        {
            return comprasHospedagens;
        }

        // GET: api/CompraHospedagem
        public IEnumerable<CompraHospedagem> Get()
        {
            return comprasHospedagens;
        }

        // GET: api/CompraHospedagem/5
        public string Get(int id)
        {
            return "value";
        }


        //api/CompraHospedagem/1/2/3/4/5/1
        [HttpGet]
        [Route("api/CompraHospedagem/{numQuartos}/{qtdPessoas}/{parcelamento}/{numeroCartao}/{codCartao}/{idHospedagem}")]
        public CompraHospedagem Get(int numQuartos,int qtdPessoas, int parcelamento, int numeroCartao, int codCartao, int idHospedagem)
        {
            CompraHospedagem compraHospedagemAtual = new CompraHospedagem();
            //string[] clientes = nomeClientes.Split(',');

            if (comprasHospedagens.Count > 0)
            {
                compraHospedagemAtual.Id = comprasHospedagens.Last().Id + 1;
            }
            else
            {
                compraHospedagemAtual.Id = 1;
            }

            compraHospedagemAtual.NumQuartos = numQuartos;
            compraHospedagemAtual.QtdPessoas = qtdPessoas;
            compraHospedagemAtual.Parcelamento = parcelamento;
            compraHospedagemAtual.NumeroCartao = numeroCartao;
            compraHospedagemAtual.CodCartao = codCartao;
            compraHospedagemAtual.IdHospedagem = idHospedagem;

            comprasHospedagens.Add(compraHospedagemAtual);

            return compraHospedagemAtual;
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
