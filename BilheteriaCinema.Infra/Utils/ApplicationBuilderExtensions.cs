using BilheteriaCinema.Infra.EF.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BilheteriaCinema.Infra.EF.Utils
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<DbBilheteriaCinemaContext>();

                if (!context.Database.EnsureCreated())
                    context.Database.Migrate();
            }
        }

        public static void UseDatabaseSeed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<DbBilheteriaCinemaContext>();

                var filmes = new List<FilmeModel>
                {
                    new FilmeModel
                    {
                        Codigo = 1,
                        Nome = "Velozes & Furiosos 8",
                        Duracao = TimeSpan.FromMinutes(149),
                        FaixaEtaria = 14,
                        Genero = "Ação"
                    },
                    new FilmeModel
                    {
                        Codigo = 2,
                        Nome = "Star Wars: A Ascensão Skywalker",
                        Duracao = TimeSpan.FromMinutes(142),
                        FaixaEtaria = 14,
                        Genero = "Aventura"
                    },
                    new FilmeModel
                    {
                        Codigo = 2,
                        Nome = "Star Wars: A Ascensão Skywalker",
                        Duracao = TimeSpan.FromMinutes(142),
                        FaixaEtaria = 12,
                        Genero = "Aventura"
                    },
                    new FilmeModel
                    {
                        Codigo = 3,
                        Nome = "Coringa",
                        Duracao = TimeSpan.FromMinutes(121),
                        FaixaEtaria = 16,
                        Genero = "Ação"
                    },
                    new FilmeModel
                    {
                        Codigo = 4,
                        Nome = "Toy Story 4",
                        Duracao = TimeSpan.FromMinutes(100),
                        FaixaEtaria = 0,
                        Genero = "Animação"
                    },
                    new FilmeModel
                    {
                        Codigo = 5,
                        Nome = "Homem-Aranha Longe de Casa",
                        Duracao = TimeSpan.FromMinutes(130),
                        FaixaEtaria = 10,
                        Genero = "Aventura"
                    },
                    new FilmeModel
                    {
                        Codigo = 6,
                        Nome = "Era Uma Vez Em... Hollywood",
                        Duracao = TimeSpan.FromMinutes(161),
                        FaixaEtaria = 16,
                        Genero = "Drama"
                    },
                    new FilmeModel
                    {
                        Codigo = 7,
                        Nome = "IT - Capítulo 2",
                        Duracao = TimeSpan.FromMinutes(169),
                        FaixaEtaria = 16,
                        Genero = "Terror"
                    },
                    new FilmeModel
                    {
                        Codigo = 8,
                        Nome = "Pokémon - Detetive Pikachu",
                        Duracao = TimeSpan.FromMinutes(105),
                        FaixaEtaria = 0,
                        Genero = "Aventura"
                    }
                };

                var databaseFilmes = context.Filmes.Where(x => filmes.Select(y => y.Codigo).Contains(x.Codigo)).ToList();

                if (databaseFilmes.Count != filmes.Count)
                    context.AddRange(filmes);
            }
        }
    }
}
