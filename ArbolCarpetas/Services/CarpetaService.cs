using System;

class CarpetaService
{
    public static void Mostrar(Carpeta carpeta, string espacio = "")
    {
        Console.WriteLine(espacio + carpeta.Nombre);

        foreach (var hijo in carpeta.Hijos)
        {
            Mostrar(hijo, espacio + "--");
        }
    }
}