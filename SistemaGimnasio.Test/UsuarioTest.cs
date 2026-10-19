using Xunit;
using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class UsuarioTest
    {
        [Fact]
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            //Arrange

            var usuario = new Usuario("Gael", 20, "Definir");
            var rutina = new Rutina("YoPuedo", 120);

            //Act

            usuario.AsignarRutina(rutina);

            //Assert

            Assert.Equal("YoPuedo", usuario.RutinaAsignada.Nombre);

        }
    }
}