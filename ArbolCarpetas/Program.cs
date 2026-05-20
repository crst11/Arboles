using System;

class Program
{
    static void Main()
    {
        CarpetaSistema discoC = new CarpetaSistema("Disco C");

        CarpetaUsuario documentos = new CarpetaUsuario("Documentos");
        CarpetaUsuario imagenes = new CarpetaUsuario("Imagenes");
        CarpetaSistema windows = new CarpetaSistema("Windows");

        CarpetaUsuario tareas = new CarpetaUsuario("Tareas");
        CarpetaUsuario fotos = new CarpetaUsuario("Fotos");

        discoC.Agregar(documentos);
        discoC.Agregar(imagenes);
        discoC.Agregar(windows);

        documentos.Agregar(tareas);
        imagenes.Agregar(fotos);

        CarpetaService.Mostrar(discoC);
    }
}