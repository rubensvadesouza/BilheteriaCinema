using System;
using BilheteriaCinema.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilheteriaCinema.Application.Application
{
    public interface IIngressoApplication
    {
        Task<List<IngressoDTO>> BuscarIngressos(DateTime? inicio, DateTime? fim, string cpf, int? sessao);
        Task<IngressoDTO> BuscarIngresso(int codigo);
        Task<IngressoDTO> ComprarIngresso(IngressoDTO ingresso);
        Task CancelarCompra(int codigo);
    }
}
