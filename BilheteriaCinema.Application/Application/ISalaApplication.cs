using BilheteriaCinema.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Application.Application
{
    public interface ISalaApplication
    {
        Task<List<SalaDTO>> BuscarSalas(bool? disponivel, int? min, int? max);
        Task<SalaDTO> BuscarSala(int codigo);
        Task<SalaDTO> CadastrarSala(SalaDTO sala);
    }
}
