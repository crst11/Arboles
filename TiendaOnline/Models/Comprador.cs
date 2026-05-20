class Comprador : Usuario
{
    public Comprador(string nombre) : base(nombre) {}

    public override void Tipo()
    {
        System.Console.WriteLine("Comprador");
    }
}