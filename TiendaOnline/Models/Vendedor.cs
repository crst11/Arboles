class Vendedor : Usuario
{
    public Vendedor(string nombre) : base(nombre) {}

    public override void Tipo()
    {
        System.Console.WriteLine("Vendedor");
    }
}