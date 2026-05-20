class Program
{
    static void Main()
    {
        PersonaEscuela escuela = new PersonaEscuela("Escuela");

        PersonaEscuela director = new PersonaEscuela("Director");

        Profesor mate = new Profesor("Matematicas");
        Profesor esp = new Profesor("Español");

        PersonaEscuela estudiantes = new PersonaEscuela("Estudiantes");

        escuela.Agregar(director);
        escuela.Agregar(mate);
        escuela.Agregar(esp);
        escuela.Agregar(estudiantes);

        EscuelaService.Mostrar(escuela);
    }
}