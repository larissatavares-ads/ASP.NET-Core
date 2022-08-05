using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        /*Esta classe agora só contém os métodos de inicialização, pois os outros métodos 
          foram transferidos para as classes CadastroLogica e LivrosLogica */
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();          
        }        
    }
}