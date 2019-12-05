using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Application.DTO;
using BilheteriaCinema.Infra.EF.Model;
using BilheteriaCinema.Infra.EF.Repositories;

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

        public async Task<List<SessaoDTO>> BuscarSessoes()
        {
            var models = await _sessaoRepository.BuscarSessoes();

            var dtos = new List<SessaoDTO>();

            foreach (SessaoModel model in models)
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

            return dtos;
        }

        public async Task<SessaoDTO> CadastrarSessao(SessaoDTO dto)
        {
            var filme = await _filmeRepository.BuscarFilme(dto.CodigoFilme);

            if (filme == null)
                throw new Exception();

            var sala = await _salaRepository.BuscarSala(dto.CodigoSala);

            if (sala == null)
                throw new Exception();

            var model = new SessaoModel
            {
                Descricao = dto.Descricao,
                Horario = dto.Horario,
                Valor = dto.Valor,
                CodigoSala = dto.CodigoSala,
                CodigoFilme = dto.CodigoFilme,
            };

            model = await _sessaoRepository.CriarSessao(model);

            dto.Codigo = model.Codigo;

            return dto;
        }

        public async Task CancelarSessao(int codigo)
        {
            await _sessaoRepository.DeletarSessao(codigo);
        }
    }
}
