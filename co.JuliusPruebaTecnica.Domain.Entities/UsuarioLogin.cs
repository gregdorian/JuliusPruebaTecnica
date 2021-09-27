using System;
using System.ComponentModel.DataAnnotations;


namespace co.JuliusPruebaTecnica.Domain.Entities
{
    public class UsuarioLogin
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

        public string GetFullName()
        {
            return $"{Nombres}, {Apellidos}";
        }
    }
}
