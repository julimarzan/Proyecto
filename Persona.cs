public class Persona {
    public string Nombre { get; private set; }
    public int Edad { get; private set; }
    
    public Persona(string nombre, int edad) {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío.");
        if (edad <= 0)
            throw new ArgumentException("La edad debe ser mayor a 0.");
        
        Nombre = nombre;
        Edad = edad;
    }
}