using System;

class UsuarioService
{
    public static void Mostrar(Nodo n, string esp = "")
    {
        Console.WriteLine(esp + n.Nombre);

        foreach (var h in n.Hijos)
        {
            Mostrar(h, esp + "--");
        }
    }
}