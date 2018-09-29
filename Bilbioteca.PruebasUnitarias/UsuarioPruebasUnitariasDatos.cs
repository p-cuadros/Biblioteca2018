using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio.Entidades;
using Biblioteca.Infraestructura.Datos.Repositorio;

namespace Bilbioteca.PruebasUnitarias
{
    [TestClass]
    public class UsuarioPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearUsuarioSatisfactoriamente()
        {
            var loUsuario = Usuario.Registrar("2018_00000", "Renzo Condori");
            var loRepositorio = new Repositorio();
            loRepositorio.Adicionar<Usuario>(loUsuario);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loUsuario);
            Assert.IsTrue(loUsuario.CodigoUsuario == "2018_00000");
        }

        [TestMethod]
        public void CambiarNombreUsuarioSatisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loUsuario = loRepositorio.ObtenerPorCodigo<Usuario>(1);
            loUsuario.CambiarNombre("Jorge Sotelo");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loUsuario.NombreUsuario == "Jorge Sotelo");
        }

        [TestMethod]
        public void CambiarNombreUsuario02Satisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loUsuario = loRepositorio.Listar<Usuario>().FirstOrDefault(p => p.NombreUsuario == "Renzo Condori");
            loUsuario.CambiarNombre("Nelson Moreno");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loUsuario);
        }
    }
}
