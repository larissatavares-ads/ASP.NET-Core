using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class LivrosController : Controller
    {
        public IEnumerable<Livro> livros { get; set; }
        public static string CarregaLista(IEnumerable<Livro> livros)
        {
            var conteudoArquivo = HTMLUtils.CarregaArquivoHTML("lista");
            
            return conteudoArquivo.Replace("#NOVO-ITEM#", "");
        }
        public IActionResult ParaLer()
        {
            // Este código vai ser executado quando a requisição chegar

            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros; 
            return View("lista");
        }
        public IActionResult Lendo()
        {
            // Este código vai ser executado quando a requisição chegar

            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }
        public IActionResult Lidos()
        {
            // Este código vai ser executado quando a requisição chegar

            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lista");
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
