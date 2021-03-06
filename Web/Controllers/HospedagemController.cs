﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourismWeb.Models;

namespace Web.Controllers
{
    public class HospedagemController : ApiController
    {

        public static Hospedagem [] hospedagens = new Hospedagem().RetornaHospedagens();

        public Hospedagem[] RetornaHospedagens() {
            return hospedagens;
        }
        
        // GET: api/Hospedagem
        public IEnumerable<Hospedagem> Get()
        {
            return hospedagens.ToList();
        }

        // GET: api/Hospedagem/5
        public Hospedagem Get(int id)
        {
            return hospedagens.SingleOrDefault(i => i.Id == id);
        }

        // Reduz quartos disponíveis GET: api/Hospedagem/1/2
        [HttpGet]
        [Route("api/Hospedagem/{id}/{quartos}")]
        public int Get(int id, int quartos)
        {

            if (hospedagens.SingleOrDefault(i => i.Id == id).QuartosDisponiveis >= quartos)
            {
                hospedagens.SingleOrDefault(i => i.Id == id).QuartosDisponiveis -= quartos;
                return hospedagens.SingleOrDefault(i => i.Id == id).QuartosDisponiveis;
            }

            //Caso não dê
            return -1;
            
        }
        
        // POST: api/Hospedagem
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Hospedagem/5
        public void Put(int id, [FromBody]string value)
        {
           
        }

        // DELETE: api/Hospedagem/5
        public void Delete(int id)
        {
        }
    }
}
