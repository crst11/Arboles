class CarpetaUsuario : Carpeta
{
    public CarpetaUsuario(string nombre) : base(nombre)
    {
    }

    public override void Tipo()
    {
        System.Console.WriteLine("Usuario");
    }
}