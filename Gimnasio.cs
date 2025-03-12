public class Gimnasio {
    private List<Cliente> clientes = new List<Cliente>();
    private List<Entrenador> entrenadores = new List<Entrenador>();
    private List<Clase> clases = new List<Clase>();
    private List<Membresia> membresias = new List<Membresia>();
    
    public void AgregarCliente(Cliente cliente) {
        if (cliente == null) throw new ArgumentNullException("El cliente no puede ser nulo.");
        clientes.Add(cliente);
        Console.WriteLine($"Cliente {cliente.Nombre} agregado al gimnasio.");
    }
    
    public void AgregarEntrenador(Entrenador entrenador) {
        if (entrenador == null) throw new ArgumentNullException("El entrenador no puede ser nulo.");
        entrenadores.Add(entrenador);
        Console.WriteLine($"Entrenador {entrenador.Nombre} agregado al gimnasio.");
    }
    
    public void AgregarClase(Clase clase) {
        if (clase == null) throw new ArgumentNullException("La clase no puede ser nula.");
        clases.Add(clase);
        Console.WriteLine($"Clase {clase.Nombre} agregada al gimnasio."+ "\n");
    }
    
    public void AgregarMembresia(Membresia membresia) {
        if (membresia == null) throw new ArgumentNullException("La membresía no puede ser nula.");
        membresias.Add(membresia);
        Console.WriteLine($"Membresía {membresia.Tipo} agregada al gimnasio.");
    }
}
