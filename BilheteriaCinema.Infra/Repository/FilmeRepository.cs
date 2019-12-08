using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        public Task<List<FilmeModel>> BuscarFilmes()
        {
            throw new NotImplementedException();
        }

        public Task<FilmeModel> BuscarFilme(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
