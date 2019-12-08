using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Application.DTO;
using BilheteriaCinema.Infra.EF.Model;
using BilheteriaCinema.Infra.EF.Repository;

namespace BilheteriaCinema.Application.Application
{
    public class IngressoApplication : IIngressoApplication
    {
        private readonly IIngressoRepository _ingressoRepository;
        private readonly ISessaoRepository _sessaoRepository;

        public IngressoApplication(IIngressoRepository ingressoRepository, ISessaoRepository sessaoRepository)
        {
            _ingressoRepository = ingressoRepository;
            _sessaoRepository = sessaoRepository;
        }

        public async Task<List<IngressoDTO>> BuscarIngressos(DateTime? inicio, DateTime? fim, string cpf, int? sessao)
        {
            var models = await _ingressoRepository.BuscarIngressos(inicio, fim, cpf, sessao);

            var dtos = new List<IngressoDTO>();

            foreach (var model in models)
            {
                var dto = new IngressoDTO
                {
                    Codigo = model.Codigo,
                    CPF = model.CPF,
                    DataCompra = model.DataCompra,
                    ValorPago = model.ValorPago,
                    Observacao = model.Observacao,
                    CodigoSessao = model.CodigoSessao,
                };

                dtos.Add(dto);
            }

            return dtos;
        }
        
        public async Task<IngressoDTO> BuscarIngresso(int codigo)
        {
            var model = await _ingressoRepository.BuscarIngresso(codigo);
            
            if (model == null)
                return null;
            
            var dto = new IngressoDTO
            {
                Codigo = model.Codigo,
                CPF = model.CPF,
                DataCompra = model.DataCompra,
                ValorPago = model.ValorPago,
                Observacao = model.Observacao,
                CodigoSessao = model.CodigoSessao,
            };
            
            return dto;
        }

        public async Task<IngressoDTO> ComprarIngresso(IngressoDTO dto)
        {
            var sessao = await _sessaoRepository.BuscarSessao(dto.CodigoSessao);

            if (sessao == null)
                throw new Exception();

            var model = new IngressoModel
            {
                Codigo = dto.Codigo,
                CPF = dto.CPF,
                DataCompra = dto.DataCompra,
                ValorPago = dto.ValorPago,
                Observacao = dto.Observacao,
                CodigoSessao = dto.CodigoSessao,
            };

            model = await _ingressoRepository.CriarIngresso(model);

            dto.Codigo = model.Codigo;

            return dto;
        }

        public async Task CancelarCompra(int codigo)
        {
            await _ingressoRepository.DeletarIngresso(codigo);
        }
    }
}
