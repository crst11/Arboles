using System.Collections.Generic;

class PersonaEscuela
{
    public string Nombre;
    public List<PersonaEscuela> Hijos = new();

    public PersonaEscuela(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void Rol()
    {
        System.Console.WriteLine("Persona escuela");
    }

    public void Agregar(PersonaEscuela p)
    {
        Hijos.Add(p);
    }
}