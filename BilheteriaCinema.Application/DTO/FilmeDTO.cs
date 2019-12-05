using System;

namespace BilheteriaCinema.Application.DTO
{
    public class FilmeDTO
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public TimeSpan Duracao { get; set; }
        public int FaixaEtaria { get; set; }
        public string Genero { get; set; }
    }
}
