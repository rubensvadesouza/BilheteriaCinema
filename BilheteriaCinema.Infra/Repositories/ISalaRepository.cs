using BilheteriaCinema.Infra.EF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Infra.EF.Repositories
{
    public interface ISalaRepository
    {
        Task<List<SalaModel>> BuscarSalas();
        Task<SalaModel> BuscarSala(int codigo);
        Task<SalaModel> CriarSala(SalaModel sala);
    }
}
