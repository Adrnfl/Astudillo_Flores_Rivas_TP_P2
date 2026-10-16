namespace SistemaGimnasio.Modelos
{
    public class Rutina
    {
        public string Nombre { get; set; }
        public int Duración { get; set; }
        private List<Ejercicio> ejercicios;

        public Rutina(string nombre, int duración)
        {
            Nombre = nombre;
            Duración = duración;
            ejercicios = new List<Ejercicio>();
        }

        public void AgregarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Add(ejercicio);
        }

        public List<Ejercicio> ObtenerEjercicios()
        {
            return ejercicios;
        }
    }
}
