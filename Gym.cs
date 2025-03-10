using System;
using System.Collections.Generic;

// Interfaz para inscripción
public interface IInscribible
{
    void Inscribirse();
}

// Clase base Persona
public class Persona
{
    public string Nombre { get; private set; }
    public int Edad { get; private set; }
}

// Clase Membresia
public class Membresia
{
    public string Tipo { get; private set; }
    public double Costo { get; private set; }
    public DateTime FechaExpiracion { get; private set; }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Membresía: {Tipo}, Costo: {Costo}, Expira: {FechaExpiracion.ToShortDateString()}");
    }
}

// Cliente hereda de Persona
public class Cliente : Persona, IInscribible
{
    public double Peso { get; private set; }
    public double Altura { get; private set; }
    public Membresia Membresia { get; private set; }

    public void Inscribirse()
    {
        Console.WriteLine($"Cliente {Nombre} inscrito al gimnasio con membresía {Membresia.Tipo}.");
    }
}

// Entrenador hereda de Persona
public class Entrenador : Persona
{
    public string Especialidad { get; private set; }
    public string Horario { get; private set; }

    public void CrearRutina()
    {
        Console.WriteLine($"Entrenador {Nombre} ha creado una nueva rutina.");
    }
}

// Clase Clase (entrenamiento impartido por los entrenadores)
public class Clase
{
    public string Nombre { get; private set; }
    public Entrenador Instructor { get; private set; }
    public string Horario { get; private set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Clase: {Nombre}, Instructor: {Instructor.Nombre}, Horario: {Horario}");
    }
}

// Clase Gimnasio
public class Gimnasio
{
    private List<Cliente> clientes = new List<Cliente>();
    private List<Entrenador> entrenadores = new List<Entrenador>();
    private List<Clase> clases = new List<Clase>();
    private List<Membresia> membresias = new List<Membresia>();
}

// Programa principal
class Program
{
    static void Main() { }
}

