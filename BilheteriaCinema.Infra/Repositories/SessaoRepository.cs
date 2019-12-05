using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repositories
{
    public class SessaoRepository : ISessaoRepository
    {
        public Task<List<SessaoModel>> BuscarSessoes()
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
