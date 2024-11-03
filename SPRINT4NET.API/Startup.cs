using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SPRINT4NET.Application.Interfaces;
using SPRINT4NET.Infrastructure.Data;
using SPRINT4NET.Infrastructure.Repositories;

namespace SPRINT4NET.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Método chamado pelo runtime para adicionar serviços à aplicação.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Adicione outras configurações, como serviços de autenticação e dependências
            services.AddSwaggerGen();
            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IURLAnaliseRepository, URLAnaliseRepository>();
            // Outras configurações de serviços
        }


        // Método chamado pelo runtime para configurar o pipeline de requisições HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SPRINT4NET.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            // Configuração de autorização e autenticação, se necessário
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

