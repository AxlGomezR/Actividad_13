using System;
using System.Collections.Generic;

List<Estudiante> estudiantes = new List<Estudiante>();
int cantidad;
do
{
    Console.WriteLine("Cunántos estudiantes desea ingresar?");
    cantidad = int.Parse(Console.ReadLine());
    Console.Clear();
    if (cantidad <= 0)
    {
        Console.WriteLine("Debe ingresar al menos un estudiante");
    }
    else
    {
        for (int i = 0; i < cantidad; i++)
        {
            Estudiante e = new Estudiante();
            Console.WriteLine($"Datos de estudiante {i + 1}:");
            Console.WriteLine($"Nombre: "); e.nombre = Console.ReadLine();
            Console.WriteLine($"Nota 1: "); e.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota 2: "); e.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota 3: "); e.nota3 = double.Parse(Console.ReadLine());
            estudiantes.Add(e);
            Console.Clear();
        }
        Estudiante mejor = estudiantes[0];
        Console.WriteLine("Listado de estudiantes:\n");
        foreach (Estudiante e in estudiantes)
        {
            e.MostrarInfo();
            if (e.CalcularPromedio() > mejor.CalcularPromedio())
            {
                mejor = e;
            }
        }
        Console.WriteLine($"El estudiante con el mejor promedio es: {mejor.nombre}");
    }
} while (cantidad<=0);
class Estudiante
{
    public string nombre;
    public double nota1;
    public double nota2;
    public double nota3;

    public double CalcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }
    public string Resultado()
    {
        if (CalcularPromedio() > 60)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Nota 1: {nota1} | Nota 2: {nota2} | Nota 3: {nota3}");
        Console.WriteLine($"Promedio: {CalcularPromedio()}");
        Console.WriteLine($"Resultado: {Resultado()}\n");
    }
}