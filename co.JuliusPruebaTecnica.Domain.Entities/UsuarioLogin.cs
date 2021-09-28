using System;
using System.ComponentModel.DataAnnotations;


namespace co.JuliusPruebaTecnica.Domain.Entities
{
    public class UsuarioLogin
    {
        [Key]
        public int id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
