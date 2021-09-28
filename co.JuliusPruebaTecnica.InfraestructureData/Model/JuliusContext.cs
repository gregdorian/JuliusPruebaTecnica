using co.JuliusPruebaTecnica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //**** Solo para Realizarel Primer Initial-Migration  ****
            if (!optionsBuilder.IsConfigured)
            {
                //IConfigurationRoot configuration = new ConfigurationBuilder()
                //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                //    .AddJsonFile("appsettings.json")
                //    .Build();
                //Directory.GetCurrentDirectory() configuration.GetConnectionString("JuliusConn")
                //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=JuliusDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();

        }
    }
}
