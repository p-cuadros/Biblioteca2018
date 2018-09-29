using Biblioteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    public class UsuarioMapeo : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapeo()
        {
            ToTable("TBL_USUARIO");
            HasKey(p => p.IdUsuario);
            Property(p => p.IdUsuario).HasColumnName("ID_USUARIO");
            Property(p => p.CodigoUsuario).HasColumnName("COD_USUARIO").HasMaxLength(20);
            Property(p => p.NombreUsuario).HasColumnName("NOM_USUARIO").HasMaxLength(100);
        }
    }
}
