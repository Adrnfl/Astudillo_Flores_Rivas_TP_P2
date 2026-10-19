using Xunit;
using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class EntrenadorTest
    {
        [Fact]
        public void AsiganrUsuario_DebeAgregarUsuarioALista()
        {
            //Arrange

            var usuario1 = new Usuario("Gael", 20, "Definir");
            var usuario2 = new Usuario("Sebastian", 20, "Aumentar masa muscular");

            var entrenador = new Entrenador("Pepe", "Licuados proteicos");

            //Act

            entrenador.AsignarUsuario(usuario1);
            entrenador.AsignarUsuario(usuario2);

            //Assert

            Assert.NotEmpty(entrenador.ObtenerUsuariosAsignados());
            Assert.Contains(usuario2, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
