using Biblioteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    public class PrestamoMapeo : EntityTypeConfiguration<Prestamo>
    {
        public PrestamoMapeo()
        {
            ToTable("TBL_PRESTAMO");
            HasKey(p => p.IdPrestamo);
            Property(p => p.IdPrestamo).HasColumnName("ID_PRESTAMO");
            Property(p => p.IdReserva).HasColumnName("ID_RESERVA");
            Property(p => p.FechaPrestamo).HasColumnName("FEC_PRESTAMO");
            Property(p => p.IdLibro).HasColumnName("ID_LIBRO");
            Property(p => p.IdUsuario).HasColumnName("ID_USUARIO");
            Property(p => p.EstadoPrestamo).HasColumnName("IND_ESTADO").HasMaxLength(1);

            HasRequired(m => m.LibroPrestado).WithMany().HasForeignKey(f => f.IdLibro);
            HasRequired(m => m.Lector).WithMany().HasForeignKey(f => f.IdUsuario);
        }
    }
}
