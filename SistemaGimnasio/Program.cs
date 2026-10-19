using SistemaGimnasio.Modelos;
using SistemaGimnasio.Gestores;
using SistemaGimnasio.Servicios;

Console.WriteLine("Sistema de gestion de gimnasio");

//Crear usuario
Console.Write("Ingresa el nombre del usuario: ");
var nombreUsuario = Console.ReadLine() ?? "";

Console.Write("Ingresa el edad del usuario: ");
int usuarioEdad = int.Parse(Console.ReadLine() ?? "");
Console.Write("Ingresa el objetivo del usuario: ");
var objetivoUsuario = Console.ReadLine() ?? "";

var usuario = new Usuario(nombreUsuario, usuarioEdad, objetivoUsuario);

//crear entrenador 
Console.Write("Ingresa el nombre del entrenador: ");
var nombreEntrenador = Console.ReadLine() ?? "";

Console.Write("Ingresa la especialidad del entrenador: ");
var especialidadEntrenador = Console.ReadLine() ?? "";
var entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//crear rutina 
Console.Write("Ingresa el nombre de la rutina: ");
var nombreRutina = Console.ReadLine() ?? "";

Console.Write("Ingresa la duracion de la rutina: ");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

var rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutina
Console.WriteLine("Cuantos ejercicios va a tener la rutina:");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= numEjercicios; i++)
{
    Console.WriteLine($"Ejercicio # {i}");

    Console.Write("Nombre dle ejercicio:");
    var nombreEjercicio = Console.ReadLine() ?? "";
    Console.Write("Numero de repeticiones: ");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Numero de series: ");
    int series = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Ingresa tiempo de descanso en segundos: ");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    var ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);
    rutina.AgregarEjercicio(ejercicio);
}

//Asignar rutina al usuario

var asignador = new AsignadorRutinas();
asignador.AsignarRutinaUsuario(usuario, rutina);
asignador.AsignarUsuarioEntrenador(usuario, entrenador);

Console.WriteLine("Resumen de asignaciones");
Console.WriteLine($"Usuarios {usuario.Nombre} rutina: {usuario.RutinaAsignada.Nombre}");
Console.WriteLine($"Entrenador asignado {entrenador.Nombre}");
Console.WriteLine("Ejercicios de la rutina");
foreach ( var item in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{item.Nombre}| Series: {item.Series} x {item.Repeticiones} | Descansos: {item.Descanso}");
}
