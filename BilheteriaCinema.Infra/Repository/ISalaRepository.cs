using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public interface ISalaRepository
    {
        Task<List<SalaModel>> BuscarSalas(bool? disponivel, int? min, int? max);
        Task<SalaModel> BuscarSala(int codigo);
        Task<SalaModel> CriarSala(SalaModel sala);
    }
}
