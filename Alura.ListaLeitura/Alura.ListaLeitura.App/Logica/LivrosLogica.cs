using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    //Os métodos com as funcionalidades de exibição de livro foram movidos para esta classe
    //Trocar LivrosLogica por LivrosController
    public class LivrosController
    {
        public static string CarregaLista(IEnumerable<Livro> livros)
        {
            var conteudoArquivo = HTMLUtils.CarregaArquivoHTML("lista");
            foreach (var livro in livros)
            {
                conteudoArquivo = conteudoArquivo
                    .Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
            }
            return conteudoArquivo.Replace("#NOVO-ITEM#", "");
        }
        public static Task ParaLer(HttpContext context)
        {
            // Este código vai ser executado quando a requisição chegar

            var _repo = new LivroRepositorioCSV();
            var conteudoArquivo = HTMLUtils.CarregaArquivoHTML("para-ler");

            foreach (var livro in _repo.ParaLer.Livros)
            {
                conteudoArquivo = conteudoArquivo
                    .Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
            }
            conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", "");

            return context.Response.WriteAsync(conteudoArquivo);
        }
        public static Task Lendo(HttpContext context)
        {
            // Este código vai ser executado quando a requisição chegar

            var _repo = new LivroRepositorioCSV();
            var conteudoArquivo = HTMLUtils.CarregaArquivoHTML("lendo");

            foreach (var livro in _repo.Lendo.Livros)
            {
                conteudoArquivo = conteudoArquivo
                    .Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
            }
            conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", "");

            return context.Response.WriteAsync(conteudoArquivo);
        }
        public static Task Lidos(HttpContext context)
        {
            // Este código vai ser executado quando a requisição chegar

            var _repo = new LivroRepositorioCSV();
            var conteudoArquivo = HTMLUtils.CarregaArquivoHTML("lidos");

            foreach (var livro in _repo.Lidos.Livros)
            {
                conteudoArquivo = conteudoArquivo
                    .Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
            }
            conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", "");

            return context.Response.WriteAsync(conteudoArquivo);
        }
        public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }
        public string Teste()
        {
            return "Nova funcionalidade implementada!";
        }
    }
}
