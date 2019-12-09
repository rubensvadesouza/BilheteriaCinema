using System;
using System.Collections.Generic;

namespace BilheteriaCinema.Infra.EF.Model
{
    public class FilmeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public TimeSpan Duracao { get; set; }
        public int FaixaEtaria { get; set; }
        public string Genero { get; set; }
        public List<SessaoModel> Sessoes { get; set; }
    }
}
