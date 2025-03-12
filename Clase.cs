public class Clase {
    public string Nombre { get; private set; }
    public Entrenador Instructor { get; private set; }
    public string Horario { get; private set; }
    
    public Clase(string nombre, Entrenador instructor, string horario) {
        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(horario))
            throw new ArgumentException("Nombre y horario de la clase no pueden estar vacíos.");
        
        Nombre = nombre;
        Instructor = instructor ?? throw new ArgumentNullException("El instructor no puede ser nulo.");
        Horario = horario;
    }
    
    public void MostrarInformacion() {
        Console.WriteLine($"Clase: {Nombre}, Instructor: {Instructor.Nombre}, Horario: {Horario}" + "\n");
    }
}
