public class Cliente : Persona, IInscribible {
    public double Peso { get; private set; }
    public double Altura { get; private set; }
    public Membresia Membresia { get; private set; }
    
    public Cliente(string nombre, int edad, double peso, double altura, Membresia membresia)
        : base(nombre, edad) {
        if (peso <= 0 || altura <= 0)
            throw new ArgumentException("El peso y la altura deben ser mayores a 0.");
        
        Peso = peso;
        Altura = altura;
        Membresia = membresia ?? throw new ArgumentNullException("La membresía no puede ser nula.");
    }
    
    public void Inscribirse() {
        Console.WriteLine($"Cliente {Nombre} inscrito al gimnasio con membresía {Membresia.Tipo}.");
    }
}