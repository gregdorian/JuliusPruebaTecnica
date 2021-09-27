using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.JuliusPruebaTecnica.Domain.Entities
{
    public class PostNoticias
    {
        [Key]
        public int Id { get; set; }
        public int ImagenPost { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaCreacion { get; set; }
     
    }
}
