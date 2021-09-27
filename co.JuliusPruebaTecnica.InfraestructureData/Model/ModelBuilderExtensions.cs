using Microsoft.EntityFrameworkCore;


namespace co.JuliusPruebaTecnica.InfraestructureData.Model
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder model)
        {

            //model.Entity<PostNoticias>().HasData(
            //       new PostNoticias { ProductName = "Producto 1", UnitsInStock = 2, UnitPrice = (decimal?)3.5 },
            //       new PostNoticias { ProductName = "Producto 2", UnitsInStock = 1, UnitPrice = (decimal?)5.5 },
            //       new PostNoticias { ProductName = "Producto 3", UnitsInStock = 50, UnitPrice = (decimal?)6.5 },
            //       new PostNoticias { ProductName = "Producto 4", UnitsInStock = 1, UnitPrice = (decimal?)32.5 });

        }
    }
}
