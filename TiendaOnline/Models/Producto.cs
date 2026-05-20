class Producto : Nodo
{
    public Producto(string nombre) : base(nombre) {}

    public override void Tipo()
    {
        System.Console.WriteLine("Producto");
    }
}