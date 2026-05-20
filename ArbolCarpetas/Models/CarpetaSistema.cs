class CarpetaSistema : Carpeta
{
    public CarpetaSistema(string nombre) : base(nombre)
    {
    }

    public override void Tipo()
    {
        System.Console.WriteLine("Sistema");
    }
}