using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas_API.Models
{
    public class PeliculasGeneros
    {
     public int PeliculaId { get; set; }
     public int GeneroId { get; set; }
    public Pelicula Pelicula { get; set; }
     public Genero Genero { get; set; }
    }
}
