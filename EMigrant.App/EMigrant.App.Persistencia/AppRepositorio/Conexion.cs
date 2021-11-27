using EMigrant.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace  EMigrant.App.Persistencia{

    public class Conexion : DbContext
    {
        
        public DbSet<migrante> migrantes {get;set;}
        public DbSet<Institucion> Instituciones {get;set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = JustScript");
            }
        }



    }


}