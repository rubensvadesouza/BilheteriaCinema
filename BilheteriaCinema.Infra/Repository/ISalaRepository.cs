using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public interface ISalaRepository
    {
        Task<List<SalaModel>> BuscarSalas();
        Task<SalaModel> BuscarSala(int codigo);
        Task<SalaModel> CriarSala(SalaModel sala);
    }
}
