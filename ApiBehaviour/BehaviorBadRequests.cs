using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Peliculas_API.ApiBehaviour
{
    public static class BehaviorBadRequests
    {
        public static void Parsear(ApiBehaviorOptions options)
        {
            options.InvalidModelStateResponseFactory = ActionContext =>
            {
                var respuesta = new List<string>();
                foreach (var llave in ActionContext.ModelState.Keys)
                {
                    foreach (var error in ActionContext.ModelState[llave].Errors)
                    {
                        respuesta.Add($"{llave}: {error.ErrorMessage}");
                    }
                }
                return new BadRequestObjectResult(respuesta);
            };
        }
    }
}
