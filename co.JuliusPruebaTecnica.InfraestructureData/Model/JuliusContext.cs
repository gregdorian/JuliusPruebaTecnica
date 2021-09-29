using co.JuliusPruebaTecnica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.JuliusPruebaTecnica.InfraestructureData.Model
{
    public partial class JuliusContext : DbContext
    {
        public JuliusContext()
        {

        }

        public JuliusContext(DbContextOptions<JuliusContext> options)
                  : base(options)
        {
        }
        public virtual DbSet<PostNoticias> PostNoticias { get; set; }
        public virtual DbSet<UsuarioLogin> UsuarioLogin { get; set; }
        public virtual DbSet<UsuarioInfo> UsuarioInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //**** Solo para Realizarel Primer Initial-Migration  ****
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=JuliusDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PostNoticias>(builder => {
                builder.HasNoKey();
                builder.ToTable("PostNoticias");
            });

            builder.Seed();
            
                   
        }
    }
}
