using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Peliculas_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas_API
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeliculasActores>().HasKey(x => new { x.ActorId, x.PeliculaId });
            modelBuilder.Entity<PeliculasGeneros>().HasKey(x => new { x.PeliculaId, x.GeneroId });
            modelBuilder.Entity<PeliculasCines>().HasKey(x => new { x.PeliculaId, x.CineId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Genero> Generos { get; set; } //DbSet son cuales tablas tendremos en nuestra base de datos
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<Pelicula> Peliculas{ get; set; }
        public DbSet<PeliculasActores> PeliculasActores { get; set; }
        public DbSet<PeliculasGeneros> PeliculasGeneros { get; set; }
        public DbSet<PeliculasCines> PeliculasCines { get; set; }
        public DbSet<Rating> Ratings { get; set; }


    }
}
