﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;

namespace BilheteriaCinema.Infra.EF.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        public Task<List<SalaModel>> BuscarSalas()
        {
            throw new System.NotImplementedException();
        }

        public Task<SalaModel> BuscarSala(int codigo)
        {
            throw new System.NotImplementedException();
        }

        public Task<SalaModel> CriarSala(SalaModel sala)
        {
            throw new System.NotImplementedException();
        }
    }
}