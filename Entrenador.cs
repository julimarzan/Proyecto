public class Entrenador : Persona {
    public string Especialidad { get; private set; }
    public string Horario { get; private set; }
    
    public Entrenador(string nombre, int edad, string especialidad, string horario)
        : base(nombre, edad) {
        if (string.IsNullOrWhiteSpace(especialidad) || string.IsNullOrWhiteSpace(horario))
            throw new ArgumentException("Especialidad y horario no pueden estar vacíos.");
        
        Especialidad = especialidad;
        Horario = horario;
    }
    
    public void CrearRutina() {
        Console.WriteLine($"Entrenador {Nombre} ha creado una nueva rutina.");
    }
}