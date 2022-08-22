using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas_API.Filtros
{
    public class FiltroDeExcepcion : ExceptionFilterAttribute
    {
       
        public FiltroDeExcepcion()
        {

        }

        public override void OnException(ExceptionContext context)
        {
            
            base.OnException(context);
        }
    }
}
