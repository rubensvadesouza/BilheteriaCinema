using System;

namespace BilheteriaCinema.Infra.EF.Model
{
    public class IngressoModel
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorPago { get; set; }
        public string Observacao { get; set; }
        public int CodigoSessao { get; set; }
        public SessaoModel Sessao { get; set; }
    }
}
