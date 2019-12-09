using System;
using System.Collections.Generic;

namespace BilheteriaCinema.Infra.EF.Model
{
    public class SessaoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Codigo { get; set; }
        public DateTime Horario { get; set; }
        public decimal Valor { get; set; }
        public int CodigoSala { get; set; }
        public SalaModel Sala { get; set; }
        public int CodigoFilme { get; set; }
        public FilmeModel Filme { get; set; }
        public List<IngressoModel> Ingressos { get; set; }
    }
}
