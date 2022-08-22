using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;
namespace Peliculas_API.Models
{
    public class Cine
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 75)]
        public string Nombre { get; set; }
        public Point Ubicacion { get; set; } //Latitud y longitud del punto en el planeta tierra
        public List<PeliculasCines> PeliculasCines { get; set; }
    }
}
