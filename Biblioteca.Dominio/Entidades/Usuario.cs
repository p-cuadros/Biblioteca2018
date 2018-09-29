using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }

        public static Usuario Registrar(string asCodigoUsuario, string asNombreUsuario)
        {
            return new Usuario()
            {
                CodigoUsuario = asCodigoUsuario,
                NombreUsuario = asNombreUsuario
            };
        }

        public void CambiarNombre(string asNuevoNombre)
        {
            NombreUsuario = asNuevoNombre;
        }
    }
}
