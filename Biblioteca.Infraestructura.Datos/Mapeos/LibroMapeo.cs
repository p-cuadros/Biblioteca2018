using Biblioteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    public class LibroMapeo : EntityTypeConfiguration<Libro>
    {
        public LibroMapeo()
        {
            ToTable("TBL_LIBRO");
            HasKey(p => p.IdLibro);
            Property(p => p.IdLibro).HasColumnName("ID_LIBRO");
            Property(p => p.TituloLibro).HasColumnName("TITULO_LIBRO").HasMaxLength(100);
            Property(p => p.AutorLibro).HasColumnName("NOM_AUTOR").HasMaxLength(100);
            Property(p => p.EstaDisponible).HasColumnName("IND_ACTIVO");
        }
    }
}
