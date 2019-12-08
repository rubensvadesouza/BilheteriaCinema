using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public interface IFilmeRepository
    {
        Task<List<FilmeModel>> BuscarFilmes();
        Task<FilmeModel> BuscarFilme(int codigo);
    }
}
