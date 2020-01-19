using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public interface IIngressoRepository
    {       
        Task<IngressoModel> BuscarIngresso(int codigo);
        Task<IngressoModel> CriarIngresso(IngressoModel ingresso);
        Task DeletarIngresso(int codigo);
    }
}
