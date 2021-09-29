using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.JuliusPruebaTecnica.Domain.Entities
{
    [Keyless]
    public class PostNoticias
    {
        public byte[] ImagenPost { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaCreacion { get; set; }
     
    }
}
