using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaInventarioV7.Modelos;
using System.Reflection;

namespace SistemaInvenatrioV7.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //mapeamos la clase debset ala abse de datos
        public DbSet<Bodega>Bodegas { get; set; }

        //mnetodo cambia base y actualiza Fluen API
        //este metodo ya existe solo los obrescribimos
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
