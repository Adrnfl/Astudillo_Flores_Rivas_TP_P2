using SistemaGimnasio.Modelos;
using System.Diagnostics.CodeAnalysis;

namespace SistemaGimnasio.Gestores
{
    public class GestorRutinas
    {
        private List<Rutina> rutinas;

        public GestorRutinas()
        {
            rutinas = new List<Rutina>();
        }

        public void CrearRutina(string nombre, int duración)
        {
            rutinas.Add(new Rutina(nombre, duración));
        }

        public Rutina BuscarRutina(string nombre)
        {
            return rutinas.FirstOrDefault(r => r.Nombre == nombre);
        }
    }
}
