using BilheteriaCinema.Application.Application;
using BilheteriaCinema.Infra.EF;
using BilheteriaCinema.Infra.EF.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BilheteriaCinema
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("SqlConnection");
            services.AddDbContext<DbBilheteriaCinemaContext>(options => options.UseSqlServer(connectionString));
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            AddApplications(services);
            AddRepositories(services);
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        public void AddApplications(IServiceCollection services)
        {
            services.AddScoped<IFilmeApplication, FilmeApplication>();
            services.AddScoped<IIngressoApplication, IngressoApplication>();
            services.AddScoped<ISalaApplication, SalaApplication>();
            services.AddScoped<ISessaoApplication, SessaoApplication>();
        } 
        
        public void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IFilmeRepository, FilmeRepository>();
            services.AddScoped<IIngressoRepository, IngressoRepository>();
            services.AddScoped<ISalaRepository, SalaRepository>();
            services.AddScoped<ISessaoRepository, SessaoRepository>();
        } 
    }
}
