using Biblioteca.Dominio.Entidades;
using Biblioteca.Infraestructura.Datos.Mapeos;
using System.Data.Entity;

namespace Biblioteca.Infraestructura.Datos
{
    public class BibliotecaContexto : DbContext
    {
        public BibliotecaContexto() : base("BiblioBD")
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UsuarioMapeo());
            modelBuilder.Configurations.Add(new LibroMapeo());
            modelBuilder.Configurations.Add(new ReservaMapeo());
            modelBuilder.Configurations.Add(new PrestamoMapeo());
        }
    }
}
