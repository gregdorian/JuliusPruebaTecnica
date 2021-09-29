using co.JuliusPruebaTecnica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace co.JuliusPruebaTecnica.InfraestructureData.Model
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder model)
        {

            //model.Entity<PostNoticias>().HasData(
            //       new PostNoticias { ImagenPost =null,Titulo = "Titulo99", Contenido = "Contenido 14", FechaCreacion = DateTime.Now.AddDays(3) },
                     //new PostNoticias { ImagenPost = null, Titulo = "Titulo10", Contenido = "Contenido 24", FechaCreacion = DateTime.Now.AddDays(23) },
                     //new PostNoticias { ImagenPost = null, Titulo = "Titulo53", Contenido = "Contenido 33", FechaCreacion = DateTime.Now.AddDays(13) },
                     //new PostNoticias { ImagenPost = null, Titulo = "Titulo94", Contenido = "Contenido 43", FechaCreacion = DateTime.Now.AddDays(43) });

        }
    }
}
