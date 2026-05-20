class Cliente : Usuario
{
    public Cliente(string nombre) : base(nombre) {}

    public override void Tipo()
    {
        System.Console.WriteLine("Cliente del sistema");
    }
}