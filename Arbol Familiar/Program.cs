using System;

class Program
{
    static void Main()
    {
        Padre padre = new Padre("Carlos");

        Hijo hijo1 = new Hijo("Ana");
        Hijo hijo2 = new Hijo("Luis");

        padre.AgregarHijo(hijo1);
        padre.AgregarHijo(hijo2);

        FamiliaService.Mostrar(padre);
    }
}