using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public class SalaRepository : ISalaRepository
    {
        public Task<List<SalaModel>> BuscarSalas(bool? disponivel, int? min, int? max)
        {
            throw new System.NotImplementedException();
        }

        public Task<SalaModel> BuscarSala(int codigo)
        {
            throw new System.NotImplementedException();
        }

        public Task<SalaModel> CriarSala(SalaModel sala)
        {
            throw new System.NotImplementedException();
        }
    }
}
