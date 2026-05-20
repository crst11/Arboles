using System.Collections.Generic;

class Nodo
{
    public string Nombre;
    public List<Nodo> Hijos = new();

    public Nodo(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void Tipo()
    {
        System.Console.WriteLine("Nodo tienda online");
    }

    public void Agregar(Nodo n)
    {
        Hijos.Add(n);
    }
}