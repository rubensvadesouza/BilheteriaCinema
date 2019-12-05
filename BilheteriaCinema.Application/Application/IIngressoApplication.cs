using BilheteriaCinema.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Application.Application
{
    public interface IIngressoApplication
    {
        Task<List<IngressoDTO>> BuscarIngressos();
        Task<IngressoDTO> ComprarIngresso(IngressoDTO ingresso);
        Task CancelarCompra(int codigo);
    }
}
