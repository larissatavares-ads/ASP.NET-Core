using Alura.ListaLeitura.App.MVC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
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
            app.UseMvcWithDefaultRoute();
            
            
            /*Roteamento do ASP.NET Core
            var builder = new RouteBuilder(app);
            builder.MapRoute("{controller}/{action}", RoteamentoPadrao.TratamentoPadrao);

            builder.MapRoute("{classe}/{metodo}", RoteamentoPadrao.TratamentoPadrao);
            builder.MapRoute("Livros/ParaLer", LivrosLogica.ParaLer);
            builder.MapRoute("Livros/Lendo", LivrosLogica.Lendo);
            builder.MapRoute("Livros/Lidos", LivrosLogica.Lidos);
            builder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.Detalhes);
            builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivro);
            builder.MapRoute("Cadastro/ExibeFormulario", CadastroLogica.ExibeFormulario);
            builder.MapRoute("Cadastro/Incluir", CadastroLogica.Incluir);

            var rotas = builder.Build();*/
        }        
    }
}