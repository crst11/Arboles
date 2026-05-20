using System.Collections.Generic;

class Persona
{
    public string Nombre;
    public List<Persona> Hijos = new();

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void MostrarTipo()
    {
        System.Console.WriteLine("Persona");
    }

    public void AgregarHijo(Persona hijo)
    {
        Hijos.Add(hijo);
    }
}