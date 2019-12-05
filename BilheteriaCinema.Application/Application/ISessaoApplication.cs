using BilheteriaCinema.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Application.Application
{
    public interface ISessaoApplication
    {
        Task<List<SessaoDTO>> BuscarSessoes();
        Task<SessaoDTO> CadastrarSessao(SessaoDTO sessao);
        Task CancelarSessao(int codigo);
    }
}
