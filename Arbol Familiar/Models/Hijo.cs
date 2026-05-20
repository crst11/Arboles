class Hijo : Persona
{
    public Hijo(string nombre) : base(nombre)
    {
    }

    public override void MostrarTipo()
    {
        System.Console.WriteLine("Soy un hijo");
    }
}