using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public interface IIngressoRepository
    {
        Task<List<IngressoModel>> BuscarIngressos(DateTime? inicio, DateTime? fim, string cpf, int? sessao);
        Task<IngressoModel> BuscarIngresso(int codigo);
        Task<IngressoModel> CriarIngresso(IngressoModel ingresso);
        Task DeletarIngresso(int codigo);
    }
}
