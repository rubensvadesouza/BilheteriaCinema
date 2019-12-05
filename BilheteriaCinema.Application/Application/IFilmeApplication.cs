using BilheteriaCinema.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Application.Application
{
    public interface IFilmeApplication
    {
        Task<List<FilmeDTO>> BuscarFilmes();
        Task<FilmeDTO> BuscarFilme(int codigo);
    }
}
