using System;
using System.Collections.Generic;
//transformé program en Gym

class Gym {
    static void Main() {
        Gimnasio gimnasio = new Gimnasio();
        Membresia membresia1 = new Membresia("Premium", 50.0, DateTime.Now.AddMonths(1));
        Cliente cliente1 = new Cliente("Juan Alberto", 25, 70.5, 1.75, membresia1);
        Entrenador entrenador1 = new Entrenador("Carlos", 30, "Musculación", "8:00 - 12:00");
        Clase clase1 = new Clase("CrossFit", entrenador1, "10:00 - 11:00");
        
        gimnasio.AgregarMembresia(membresia1);
        gimnasio.AgregarCliente(cliente1);
        gimnasio.AgregarEntrenador(entrenador1);
        gimnasio.AgregarClase(clase1);
        
        cliente1.Inscribirse();
        entrenador1.CrearRutina();
        clase1.MostrarInformacion();
        membresia1.MostrarDetalles();
    }
}
