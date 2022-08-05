using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.MVC
{
    public class RoteamentoPadrao
    {
        public static Task TratamentoPadrao(HttpContext context)   //Default Handler
        {
            //Rota padrão: /<Classe>Logica/Metodo
            //{classe}/{metodo}
            //Os tipos abaixo fazem parte de uma API do .NET chamada reflection

            var classe = Convert.ToString(context.GetRouteValue("classe"));
            var nomeMetodo = Convert.ToString(context.GetRouteValue("metodo"));

            var nomeCompleto = $"Alura.ListaLeitura.App.Logica.{classe}Logica";

            var tipo = Type.GetType(classe);
            var metodo = tipo.GetMethods().Where(m => m.Name == nomeMetodo).First();
            var requestDelegate = (RequestDelegate)Delegate.CreateDelegate(typeof(RequestDelegate), metodo);

            return requestDelegate.Invoke(context);
        }
    }
}
