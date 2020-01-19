using BilheteriaCinema.Application.DTO;
using System.Threading.Tasks;

namespace BilheteriaCinema.Application.Application
{
    public interface IIngressoApplication
    {
        Task<IngressoDTO> BuscarIngresso(int codigo);
        Task<IngressoDTO> ComprarIngresso(IngressoDTO ingresso);
        Task CancelarCompra(int codigo);
    }
}
