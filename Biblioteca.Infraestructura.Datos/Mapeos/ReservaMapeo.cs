using Biblioteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    public class ReservaMapeo : EntityTypeConfiguration<Reserva>
    {
        public ReservaMapeo()
        {
            ToTable("TBL_RESERVA");
            HasKey(p => p.IdReserva);
            Property(p => p.IdReserva).HasColumnName("ID_RESERVA");
            Property(p => p.FechaReserva).HasColumnName("FEC_RESERVA");
            Property(p => p.IdLibro).HasColumnName("ID_LIBRO");
            Property(p => p.IdUsuario).HasColumnName("ID_USUARIO");
            Property(p => p.EstadoReserva).HasColumnName("IND_ESTADO").HasMaxLength(1);

            HasRequired(m => m.LibroReservado).WithMany().HasForeignKey(f => f.IdLibro);
            HasRequired(m => m.Lector).WithMany().HasForeignKey(f => f.IdUsuario);
        }
    }
}
