using _2024__1C_Estacionamiento.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _2024__1C_Estacionamiento.Data
{
    public class EstacionamientoContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>//el Tkey es el ultimo parametro, o pongo como parametro como entero para facilitar la materia. si no lo pone como String 
    {
        public EstacionamientoContext(DbContextOptions options) : base(options)
        {

        }

       
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<Direccion> Direccion { get; set; }


        public DbSet<ClienteVehiculo> ClientesVehiculos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefono> Telefono { get; set; }

        public DbSet<Empleado> Empleado { get; set; }

        public DbSet<ClienteVehiculo> ClientesVehiculo { get; set; }

        public DbSet<Pago> Pagos { get; set; }

        public DbSet<Estancia> estancias { get; set; }

        public DbSet<Rol> rRoles { get; set; }

        //Defino algunas restricciones en mi BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //// lo agrego para la precicion en la BD con Fuelt Api.-
            //modelBuilder.Entity<Estancia>().Property(est => est.Monto).HasPrecision(38, 18);
            //modelBuilder.Entity<Pago>().Property(pag => pag.Monto).HasPrecision(38, 18);

            //Creo la clave para mucho a muchos

            modelBuilder.Entity<ClienteVehiculo>().HasKey(cv => new { cv.ClienteId, cv.VehiculoId });

            modelBuilder.Entity<ClienteVehiculo>()
                .HasOne(cv => cv.Cliente)
                .WithMany(v => v.VehiculosAutorizados)
                .HasForeignKey(cv => cv.ClienteId);

            modelBuilder.Entity<ClienteVehiculo>()
               .HasOne(cv => cv.Vehiculo)
               .WithMany(v => v.PersonasAutorizadas)
               .HasForeignKey(cv => cv.VehiculoId);

            #region Establecer Nombres para los Identity Stores
            ////Modifico la Entidad Identity User para que guarde en Las tablas que yo quiero
            modelBuilder.Entity<IdentityUser<int>>().ToTable("Personas");
            modelBuilder.Entity<IdentityRole<int>>().ToTable("Roles");
            ////Relacion Muchos a Muchos
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("PersonasRoles");

            #endregion

            #region Unique
            modelBuilder.Entity<Vehiculo>().HasIndex(v => v.Patente).IsUnique();

            #endregion

        }
      
      

    }


}

