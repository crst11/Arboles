class Program
{
    static void Main()
    {
        Nodo sistema = new Nodo("Sistema");

        Nodo usuarios = new Nodo("Usuarios");
        Nodo logs = new Nodo("Logs");

        Nodo admins = new Nodo("Administradores");
        Nodo clientes = new Nodo("Clientes");

        Administrador a1 = new Administrador("Admin1");
        Administrador a2 = new Administrador("Admin2");

        Cliente c1 = new Cliente("Cliente1");
        Cliente c2 = new Cliente("Cliente2");

        admins.Agregar(a1);
        admins.Agregar(a2);

        clientes.Agregar(c1);
        clientes.Agregar(c2);

        usuarios.Agregar(admins);
        usuarios.Agregar(clientes);

        sistema.Agregar(usuarios);
        sistema.Agregar(logs);

        UsuarioService.Mostrar(sistema);
    }
}