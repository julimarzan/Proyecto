using System;
using System.Collections.Generic;
//transformé program en Gym

class Gym {
    static void Main() {
        try {
            Gimnasio gimnasio = new Gimnasio();
            Membresia membresia1 = new Membresia("Premium", 80.000, DateTime.Now.AddMonths(1));
            Cliente cliente1 = new Cliente("Juan Duque", 26, 70.5, 1.75, membresia1);
            Entrenador entrenador1 = new Entrenador("Carlos Marzan", 30, "Musculación", "8:00 - 12:00");
            Clase clase1 = new Clase("CrossFit", entrenador1, "10:00 - 11:00");
            
            gimnasio.AgregarMembresia(membresia1);
            gimnasio.AgregarCliente(cliente1);
            gimnasio.AgregarEntrenador(entrenador1);
            gimnasio.AgregarClase(clase1);
            
            cliente1.Inscribirse();
            membresia1.MostrarDetalles();
            entrenador1.CrearRutina();
            clase1.MostrarInformacion();
            
        }
        catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
