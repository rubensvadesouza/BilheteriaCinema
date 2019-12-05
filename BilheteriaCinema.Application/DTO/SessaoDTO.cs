using System;

namespace BilheteriaCinema.Application.DTO
{
    public class SessaoDTO
    {
        public string Descricao { get; set; }
        public int Codigo { get; set; }
        public DateTime Horario { get; set; }
        public decimal Valor { get; set; }
        public int CodigoSala { get; set; }
        public int CodigoFilme { get; set; }
    }
}
