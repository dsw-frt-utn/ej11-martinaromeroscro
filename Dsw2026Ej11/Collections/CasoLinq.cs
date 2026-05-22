using Dsw2026Ej11.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    public static Libro GetPrimero()
    {
        return Libro.CrearLista().First();
    }


    public static Libro GetUltimo()
    {
        return Libro.CrearLista().Last();
    }

    public static decimal GetTotalPrecio()
    {
        decimal total = 0;
        Libro.CrearLista().ForEach(libro => { total = libro.Precio + total; });
        return total;
    }

    public static decimal GetPromedioPrecios()
    {
        decimal total = 0;
        Libro.CrearLista().ForEach(libro => { total = libro.Precio + total; });
        return total / Libro.CrearLista().Count();
    }

    public static List<Libro> GetListById()
    {
        return Libro.CrearLista().Where(p => p.Id >= 15).ToList();

    }

    public static List<string> GetLibros()
    {
        List<string> list = new List<string>();
        Libro.CrearLista().ForEach(libro => { list.Add($"titulo: {libro.Titulo}, precio: {libro.Precio}$") });
        return list;
    }

    public static decimal GetMayorPrecio()
    {
        return Libro.CrearLista().OrderBy(p => p.Precio >= p.Precio).First().Precio;
    }

    public static decimal GetMenorPrecio()
    {
        return Libro.CrearLista().OrderBy(p => p.Precio >= p.Precio).Last().Precio;
    }

    public static List<Libro> GetMayorPromedio()
    {
        CasoLinq.GetPromedioPrecios();

        return Libro.CrearLista().Where(p => p.Precio >= CasoLinq.GetPromedioPrecios()).ToList();


    }

    public static List<Libro> Ordenar()
    {
        return Libro.CrearLista().OrderByDescending(p => p.Titulo).ToList();

    }
}

