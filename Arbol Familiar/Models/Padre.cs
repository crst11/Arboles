class Padre : Persona
{
    public Padre(string nombre) : base(nombre)
    {
    }

    public override void MostrarTipo()
    {
        System.Console.WriteLine("Soy un padre");
    }
}