using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public interface IIngressoRepository
    {
        Task<List<IngressoModel>> BuscarIngressos(string cpf);
        Task<IngressoModel> CriarIngresso(IngressoModel ingresso);
        Task DeletarIngresso(int codigo);
    }
}
