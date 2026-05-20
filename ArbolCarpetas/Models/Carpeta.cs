using System.Collections.Generic;

class Carpeta
{
    public string Nombre;
    public List<Carpeta> Hijos = new();

    public Carpeta(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void Tipo()
    {
        System.Console.WriteLine("Carpeta");
    }

    public void Agregar(Carpeta carpeta)
    {
        Hijos.Add(carpeta);
    }
}