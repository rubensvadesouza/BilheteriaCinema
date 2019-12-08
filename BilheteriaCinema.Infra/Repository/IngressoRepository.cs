using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public class IngressoRepository : IIngressoRepository
    {
        public Task<List<IngressoModel>> BuscarIngressos(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task<IngressoModel> CriarIngresso(IngressoModel ingresso)
        {
            throw new NotImplementedException();
        }

        public Task DeletarIngresso(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
