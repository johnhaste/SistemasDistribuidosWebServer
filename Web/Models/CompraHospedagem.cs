//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourismWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public class CompraHospedagem
    {
        public CompraHospedagem()
        {

        }
    
        public int Id { get; set; }
        //public System.DateTime DataEntrada { get; set; }
        //public System.DateTime DataSaida { get; set; }
        public int NumQuartos { get; set; }
        public int QtdPessoas { get; set; }
        public int Parcelamento { get; set; }
        public int NumeroCartao { get; set; }
        public int CodCartao { get; set; }
        public int IdHospedagem { get; set; }

        public CompraHospedagem[] RetornaComprasHospedagens()
        {
            var compraHospedagens = new CompraHospedagem[]
            {
               
            };
            return compraHospedagens;
        }
    }

        
}
