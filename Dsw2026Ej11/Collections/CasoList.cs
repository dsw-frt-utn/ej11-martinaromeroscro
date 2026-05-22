using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno> alumnos = new List<Alumno> { };

    public void addAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public List<Alumno> retornarAlumnos()
    {
        return alumnos;
    }

    public Alumno buscarPorNombre(string nombre)
    {
        return alumnos.Find(p => p.Nombre == nombre);
        //DEVUELVE UN ELEMENTO DE TODDDAAAA LA LISTA
    }

    public void eliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }


    public void eliminarAlumnoIndex(int index)
    {
        alumnos.RemoveAt(index);

    }

}

