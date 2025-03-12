public class Membresia {
    public string Tipo { get; private set; }
    public double Costo { get; private set; }
    public DateTime FechaExpiracion { get; private set; }
    
    public Membresia(string tipo, double costo, DateTime fechaExpiracion) {
        if (string.IsNullOrWhiteSpace(tipo))
            throw new ArgumentException("El tipo de membresía no puede estar vacío.");
        if (costo < 0)
            throw new ArgumentException("El costo no puede ser negativo.");
        
        Tipo = tipo;
        Costo = costo;
        FechaExpiracion = fechaExpiracion;
    }
    
    public void MostrarDetalles() {
        Console.WriteLine($"Membresía: {Tipo}, Costo: {Costo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}, Expira: {FechaExpiracion.ToShortDateString()}" +"\n");
    }
}