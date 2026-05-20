class Administrador : Usuario
{
    public Administrador(string nombre) : base(nombre) {}

    public override void Tipo()
    {
        System.Console.WriteLine("Administrador del sistema");
    }
}