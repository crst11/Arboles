class Profesor : PersonaEscuela
{
    public Profesor(string nombre) : base(nombre) {}

    public override void Rol()
    {
        System.Console.WriteLine("Profesor");
    }
}