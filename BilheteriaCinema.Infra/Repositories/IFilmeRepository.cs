using BilheteriaCinema.Infra.EF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Infra.EF.Repositories
{
    public interface IFilmeRepository
    {
        Task<List<FilmeModel>> BuscarFilmes();
        Task<FilmeModel> BuscarFilme(int codigo);
    }
}
