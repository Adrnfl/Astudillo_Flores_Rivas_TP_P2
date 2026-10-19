using Xunit;
using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public class RutinaTest
    {
        [Fact]
        public void AgregarEjercicio_DebeAgregarALista()
        {
            //Arrange

            var rutina = new Rutina("YoPuedo", 120);
            var ejercicio1 = new Ejercicio("Levanta", 15, 5, 90);
            var ejercicio2 = new Ejercicio("Press", 12, 4, 30);

            //Act

            rutina.AgregarEjercicio(ejercicio1);
            rutina.AgregarEjercicio(ejercicio2);

            //Assert

            Assert.NotEmpty(rutina.ObtenerEjercicios());
            Assert.Equal(rutina.ObtenerEjercicios()[0].Nombre, "Levanta");
        }
    }
}
