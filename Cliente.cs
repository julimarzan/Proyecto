public class Cliente : Persona, IInscribible {
    public double Peso { get; private set; }
    public double Altura { get; private set; }
    public Membresia Membresia { get; private set; }
    
    public Cliente(string nombre, int edad, double peso, double altura, Membresia membresia)
        : base(nombre, edad) {
        Peso = peso;
        Altura = altura;
        Membresia = membresia;
    }
    
    public void Inscribirse() {
        Console.WriteLine($"Cliente {Nombre} inscrito al gimnasio con membresía {Membresia.Tipo}.");
    }
}