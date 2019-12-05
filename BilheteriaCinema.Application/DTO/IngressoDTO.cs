using System;

namespace BilheteriaCinema.Application.DTO
{
    public class IngressoDTO
    {
        public int Codigo { get; set; }
        public string CPF { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorPago { get; set; }
        public string Observacao { get; set; }
        public int CodigoSessao { get; set; }
    }
}
