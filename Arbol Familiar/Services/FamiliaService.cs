using System;

class FamiliaService
{
    public static void Mostrar(Persona persona, string espacio = "")
    {
        Console.WriteLine(espacio + persona.Nombre);

        foreach (var hijo in persona.Hijos)
        {
            Mostrar(hijo, espacio + "--");
        }
    }
}