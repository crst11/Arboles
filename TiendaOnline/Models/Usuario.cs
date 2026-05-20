class Usuario : Nodo
{
    public Usuario(string nombre) : base(nombre) {}

    public override void Tipo()
    {
        System.Console.WriteLine("Usuario");
    }
}