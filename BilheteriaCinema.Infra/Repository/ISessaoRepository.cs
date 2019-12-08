using System;
using BilheteriaCinema.Infra.EF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public interface ISessaoRepository
    {
        Task<List<SessaoModel>> BuscarSessoes(DateTime? inicio, DateTime? fim, int? sala, int? filme);
        Task<SessaoModel> BuscarSessao(int codigo);
        Task<SessaoModel> CriarSessao(SessaoModel sessao);
        Task DeletarSessao(int codigo);
    }
}
