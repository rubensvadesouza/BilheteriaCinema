using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Application.DTO;
using BilheteriaCinema.Infra.EF.Model;
using BilheteriaCinema.Infra.EF.Repositories;

namespace BilheteriaCinema.Application.Application
{
    public class FilmeApplication : IFilmeApplication
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeApplication(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public async Task<List<FilmeDTO>> BuscarFilmes()
        {
            var models = await _filmeRepository.BuscarFilmes();

            var dtos = new List<FilmeDTO>();

            foreach (FilmeModel model in models)
            {
                var dto = new FilmeDTO
                {
                    Nome = model.Nome,
                    Codigo = model.Codigo,
                    Duracao = model.Duracao,
                    FaixaEtaria = model.FaixaEtaria,
                    Genero = model.Genero
                };

                dtos.Add(dto);
            }

            return dtos;
        }

        public async Task<FilmeDTO> BuscarFilme(int codigo)
        {
            var model = await _filmeRepository.BuscarFilme(codigo);

            if (model == null)
                return null;

            var dto = new FilmeDTO
            {
                Nome = model.Nome,
                Codigo = model.Codigo,
                Duracao = model.Duracao,
                FaixaEtaria = model.FaixaEtaria,
                Genero = model.Genero
            };

            return dto;
        }
    }
}
