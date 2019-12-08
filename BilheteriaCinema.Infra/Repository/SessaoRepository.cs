using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public class SessaoRepository : ISessaoRepository
    {
        public Task<List<SessaoModel>> BuscarSessoes(DateTime? inicio, DateTime? fim, int? sala, int? filme)
        {
            throw new NotImplementedException();
        }

        public Task<SessaoModel> BuscarSessao(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<SessaoModel> CriarSessao(SessaoModel sessao)
        {
            throw new NotImplementedException();
        }

        public Task DeletarSessao(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
