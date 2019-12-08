using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Application.DTO;
using BilheteriaCinema.Infra.EF.Model;
using BilheteriaCinema.Infra.EF.Repository;

namespace BilheteriaCinema.Application.Application
{
    public class SalaApplication : ISalaApplication
    {
        private readonly ISalaRepository _salaRepository;

        public SalaApplication(ISalaRepository salaRepository)
        {
            _salaRepository = salaRepository;
        }

        public async Task<List<SalaDTO>> BuscarSalas()
        {
            var models = await _salaRepository.BuscarSalas();

            var dtos = new List<SalaDTO>();

            foreach (var model in models)
            {
                var dto = new SalaDTO
                {
                    Descricao = model.Descricao,
                    Codigo = model.Codigo,
                    Lugares = model.Lugares,
                    Disponivel = model.Disponivel,
                };

                dtos.Add(dto);
            }

            return dtos;
        }

        public async Task<SalaDTO> BuscarSala(int codigo)
        {
            var model = await _salaRepository.BuscarSala(codigo);

            if (model == null)
                return null;

            var dto = new SalaDTO
            {
                Descricao = model.Descricao,
                Codigo = model.Codigo,
                Lugares = model.Lugares,
                Disponivel = model.Disponivel,
            };

            return dto;
        }

        public async Task<SalaDTO> CadastrarSala(SalaDTO dto)
        {
            var model = new SalaModel
            {
                Descricao = dto.Descricao,
                Lugares = dto.Lugares,
                Disponivel = dto.Disponivel,
            };

            model = await _salaRepository.CriarSala(model);

            dto.Codigo = model.Codigo;

            return dto;
        }
    }
}
