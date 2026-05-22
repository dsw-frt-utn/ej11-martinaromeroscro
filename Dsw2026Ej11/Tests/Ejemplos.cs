using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;


namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList alumnos = new CasoList();
        alumnos.addAlumno(new Alumno(1000, "Luciana", 8));
        alumnos.addAlumno(new Alumno(1001, "Lucia", 7));
        alumnos.addAlumno(new Alumno(1002, "Santino", 10));
        foreach (var item in alumnos.retornarAlumnos())
        {
            Console.WriteLine(item.ToString());
        }

        var alumno = alumnos.buscarPorNombre("Luciana");
        if (alumno == null) Console.WriteLine("No existe");
        else Console.WriteLine(alumno.ToString());

        alumno = alumnos.buscarPorNombre("Harry");
        if (alumno == null) Console.WriteLine("No existe");
        else Console.WriteLine(alumno.ToString());

        alumno = alumnos.buscarPorNombre("Santino");
        alumnos.eliminarAlumno(alumno);
        foreach (var item in alumnos.retornarAlumnos())
        {
            Console.WriteLine(item.ToString());
        }

        alumnos.eliminarAlumnoIndex(0);
        foreach (var item in alumnos.retornarAlumnos())
        {
            Console.WriteLine(item.ToString());
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary alumnos = new CasoDictionary();
        alumnos.agregarAlumno(new Alumno(1000, "Luciana", 8), 58199);
        alumnos.agregarAlumno(new Alumno(1001, "Lucia", 7), 58200);
        alumnos.agregarAlumno(new Alumno(1002, "Santino", 10), 58201);
        foreach (var item in alumnos.retornarDiccionario())
        {
            Console.WriteLine(item.ToString());
        }

        var alumno = alumnos.buscarAlumno(58199);
        if (alumno == null) Console.WriteLine("No existe");
        else Console.WriteLine(alumno.ToString());

        alumno = alumnos.buscarAlumno(39400);
        if (alumno == null) Console.WriteLine("No existe");
        else Console.WriteLine(alumno.ToString());

        alumnos.eliminarAlumno(58200);
        foreach (var item in alumnos.retornarDiccionario())
        {
            Console.WriteLine(item.ToString());
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

        Console.WriteLine("Total de precios: " + CasoLinq.GetTotalPrecio());
        Console.WriteLine("Primer libro: " + CasoLinq.GetPrimero().ToString());
        Console.WriteLine("Último libro: " + CasoLinq.GetUltimo().ToString());
        Console.WriteLine("Menor precio: " + CasoLinq.GetMenorPrecio());
        Console.WriteLine("Mayor precio: " + CasoLinq.GetMayorPrecio());
        Console.WriteLine("Promedio precios: " + CasoLinq.GetPromedioPrecios());
        Console.WriteLine("Libros mayor al promedio: ");
        foreach (var item in CasoLinq.GetMayorPromedio())
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("Libro con ID > 15: ");
        foreach (var item in CasoLinq.GetListById())
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("Libros: ");
        foreach (var item in CasoLinq.GetLibros())
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("Libros ordenados descendentemente: ");
        foreach (var item in CasoLinq.Ordenar())
        {
            Console.WriteLine(item.ToString());
        }
    }
}
