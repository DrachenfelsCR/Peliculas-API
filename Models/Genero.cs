using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas_API.Models
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:10)]
       
        public string Nombre { get; set; }

        public List<PeliculasGeneros> PeliculasGeneros { get; set; }
    }
}
