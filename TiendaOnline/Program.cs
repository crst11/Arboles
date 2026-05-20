class Program
{
    static void Main()
    {
        Nodo tienda = new Nodo("TiendaOnline");

        Nodo productos = new Nodo("Productos");
        Nodo carrito = new Nodo("Carrito");
        Nodo usuarios = new Nodo("Usuarios");

        Nodo electronicos = new Nodo("Electronicos");
        Nodo hogar = new Nodo("Hogar");

        Nodo celulares = new Nodo("Celulares");
        Nodo pc = new Nodo("Computadores");

        Comprador c1 = new Comprador("Cliente1");
        Vendedor v1 = new Vendedor("Vendedor1");

        electronicos.Agregar(celulares);
        electronicos.Agregar(pc);

        productos.Agregar(electronicos);
        productos.Agregar(hogar);

        usuarios.Agregar(c1);
        usuarios.Agregar(v1);

        tienda.Agregar(productos);
        tienda.Agregar(carrito);
        tienda.Agregar(usuarios);

        TiendaService.Mostrar(tienda);
    }
}