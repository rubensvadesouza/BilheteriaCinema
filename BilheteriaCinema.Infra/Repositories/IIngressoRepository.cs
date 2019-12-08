using BilheteriaCinema.Infra.EF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Infra.EF.Repositories
{
    public interface IIngressoRepository
    {
        Task<List<IngressoModel>> BuscarIngressos(string cpf);
        Task<IngressoModel> CriarIngresso(IngressoModel ingresso);
        Task DeletarIngresso(int codigo);
    }
}
