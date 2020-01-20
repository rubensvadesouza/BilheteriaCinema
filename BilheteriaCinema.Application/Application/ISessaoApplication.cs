using System;
using BilheteriaCinema.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Application.Application
{
    public interface ISessaoApplication
    {
        Task<List<SessaoDTO>> BuscarSessoes(DateTime? inicio, DateTime? fim, int? sala, int? filme);
        Task CancelarSessao(int codigo);
    }
}
