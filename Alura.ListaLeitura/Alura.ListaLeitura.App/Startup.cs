using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(Roteamento);
        }
        public Task Roteamento(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            var caminhosAtendidos = new Dictionary<string, string>
            {
                { "/Livros/ParaLer", _repo.ParaLer.ToString() },
                { "/Livros/Lendo", _repo.Lendo.ToString() },
                { "/Livros/Lidos", _repo.Lidos.ToString() }
            };
            /*
            /Livros/ParaLer
            /Livros/Lendo
            /Livros/Lidos
            */
            if(Path == )
            {

            }

            return context.Response.WriteAsync(context.Request.Path);
        }
        public Task LivrosParaLer(HttpContext context)
        {
            // Este código vai ser executado quando a requisição chegar

            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.ParaLer.ToString());
        }
    }
}