using System;
using System.Linq;
using Biblioteca.Dominio.Repositorios;

namespace Biblioteca.Infraestructura.Datos.Repositorio
{
    public class Repositorio : IRepositorio
    {
        readonly BibliotecaContexto ioContexto;
        public Repositorio()
        {
            ioContexto = new BibliotecaContexto();
        }
        public T ObtenerPorCodigo<T>(params object[] aoLLaves) where T :class
        {
            return ioContexto.Set<T>().Find(aoLLaves);
        }
        public IQueryable<T> Listar<T>(string asPropiedades = "") where T : class
        {
            return ioContexto.Set<T>();
        }
        public void Adicionar<T>(T aoEntidad) where T : class
        {
            ioContexto.Set<T>().Add(aoEntidad);
        }
        public void GuardarCambios()
        {
            ioContexto.SaveChanges();
        }
    }
}
