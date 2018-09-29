using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdReserva { get; private set; }
        public DateTime FechaPrestamo { get; private set; }
        public int IdLibro { get; private set; }
        public int IdUsuario { get; private set; }
        public Libro LibroPrestado { get; private set; }
        public Usuario Lector { get; private set; }
        public string EstadoPrestamo { get; private set; }
    }
}
