using Xunit;
using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

namespace SistemaGimnasio.Test
{
    public class AsignadorTest
    {
        [Fact]
        public void AsignarRutinaUsuario_DebeAsignarCorrectamente()
        {
            //Arrange

            var usuario = new Usuario("Gael", 20, "Definir");
            var rutina = new Rutina("YoPuedo", 120);
            var asignador = new AsignadorRutinas();

            //Act

            asignador.AsignarRutinaUsuario(usuario, rutina);

            //Assert

            Assert.Equal(rutina, usuario.RutinaAsignada);
        }

        [Fact]
        public void AsignarUsuarioEntrenador_DebeIncluirUsuario()
        {
            //Arrange

            var usuario = new Usuario("Gael", 20, "Definir");
            var entrenador = new Entrenador("Pepe", "Licuados proteicos");
            var asignador = new AsignadorRutinas();

            //Act

            asignador.AsignarUsuarioEntrenador(usuario, entrenador);

            //Assert

            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
