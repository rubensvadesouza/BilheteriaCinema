using BilheteriaCinema.Infra.EF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Infra.EF.Repositories
{
    public interface ISessaoRepository
    {
        Task<List<SessaoModel>> BuscarSessoes();
        Task<SessaoModel> BuscarSessao(int codigo);
        Task<SessaoModel> CriarSessao(SessaoModel sessao);
        Task DeletarSessao(int codigo);
    }
}
