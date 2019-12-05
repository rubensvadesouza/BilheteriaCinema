namespace BilheteriaCinema.Infra.EF.Model
{
    public class SalaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Codigo { get; set; }
        public int Lugares { get; set; }
        public bool Disponivel { get; set; }
    }
}
