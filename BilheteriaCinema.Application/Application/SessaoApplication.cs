using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Application.DTO;
using BilheteriaCinema.Infra.EF.Model;
using BilheteriaCinema.Infra.EF.Repository;

namespace BilheteriaCinema.Application.Application
{
    public class SessaoApplication : ISessaoApplication
    {
        private readonly ISessaoRepository _sessaoRepository;
        private readonly IFilmeRepository _filmeRepository;
        private readonly ISalaRepository _salaRepository;

        public SessaoApplication(ISessaoRepository sessaoRepository, IFilmeRepository filmeRepository, ISalaRepository salaRepository)
        {
            _sessaoRepository = sessaoRepository;
            _filmeRepository = filmeRepository;
            _salaRepository = salaRepository;
        }

        public async Task<List<SessaoDTO>> BuscarSessoes(DateTime? inicio, DateTime? fim, int? sala, int? filme)
        {
            var models = await _sessaoRepository.BuscarSessoes( inicio, fim, sala, filme);

            var dtos = new List<SessaoDTO>();

            foreach (var model in models)
            {
                var dto = new SessaoDTO
                {
                    Descricao = model.Descricao,
                    Codigo = model.Codigo,
                    Horario = model.Horario,
                    Valor = model.Valor,
                    CodigoSala = model.CodigoSala,
                    CodigoFilme = model.CodigoFilme
                };

                dtos.Add(dto);
            }

            if (dtos.Count == 0)
                throw new Exception("Erro");

            return dtos;
        }    

        public async Task CancelarSessao(int codigo)
        {
            await _sessaoRepository.DeletarSessao(codigo);
        }
    }
}
