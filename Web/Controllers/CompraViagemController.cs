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
        public static List<CompraViagem> comprasViagens = new CompraViagem().RetornaComprasViagens().ToList();
        public static List<TicketViagem> ticketViagens = new List<TicketViagem>();


        public List<CompraViagem> RetornaComprasViagens()
        {
            return comprasViagens;
        }

        // GET: api/CompraViagem
        public IEnumerable<CompraViagem> Get()
        {
            return comprasViagens;
        }

        // GET: api/CompraViagem/5
        public string Get(int id)
        {
            return "value";
        }
        
        // Gera um registro de Compra GET: api/CompraViagem/1/2
        [HttpGet]
        [Route("api/CompraViagem/{nomeClientes}/{Parcelamento}/{NumeroCartao}/{CodCartao}/{IdViagem}")]
        public CompraViagem Get(string nomeClientes, int parcelamento, int numeroCartao, int codCartao, int idViagem)
        {

            CompraViagem compraViagemAtual = new CompraViagem();
            string[] clientes = nomeClientes.Split(',');
            
            if (comprasViagens.Count > 0)
            {
                compraViagemAtual.Id = comprasViagens.Last().Id + 1;
            }
            else {
                compraViagemAtual.Id = 1;
            }
                        
            compraViagemAtual.NomeCliente = clientes[0];
            compraViagemAtual.Parcelamento = parcelamento;
            compraViagemAtual.NumeroCartao = numeroCartao;
            compraViagemAtual.CodCartao = codCartao;
            compraViagemAtual.IdVigem = idViagem;

            comprasViagens.Add(compraViagemAtual);


            //Adiciona Tickets
            for (int i = 0; i < clientes.Length; i++)
            {
                TicketViagem ticketAtual = new TicketViagem();
                if (ticketViagens.Count > 0)
                {
                    ticketAtual.Id = ticketViagens.Count + 1;
                }
                else
                {
                    ticketAtual.Id = 0;
                }

                ticketAtual.NomePassageiro = clientes[i];
                ticketAtual.IdCompraViagem = compraViagemAtual.Id;
                ticketViagens.Add(ticketAtual);
            }

            return compraViagemAtual;
        }

        [HttpGet]
        [Route("api/CompraViagem/Tickets")]
        public List<TicketViagem> GetTickets() {
            return ticketViagens;
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
