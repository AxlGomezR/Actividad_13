class Estudiante
{
    string nombre;
    double nota1;
    double nota2;
    double nota3;

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