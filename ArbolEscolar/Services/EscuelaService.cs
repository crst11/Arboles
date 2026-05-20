using System;

class EscuelaService
{
    public static void Mostrar(PersonaEscuela p, string esp = "")
    {
        Console.WriteLine(esp + p.Nombre);

        foreach (var h in p.Hijos)
        {
            Mostrar(h, esp + "--");
        }
    }
}