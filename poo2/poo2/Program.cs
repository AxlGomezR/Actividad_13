class Inventario
{
    public string nombre;
    public double precio;
    public int cantidad;

    public double PrecioTotal()
    {
        return precio * cantidad;
    }
    public string Existencias()
    {
        if (cantidad > 30)
        {
            return "Stock suficiente";
        }else if(cantidad>0 && cantidad < 30)
        {
            return "Stock bajo";
        }
        else
        {
            return "Sin stock";
        }
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre del producto: {nombre}");
        Console.WriteLine($"Precio unitario: {precio}");
        Console.WriteLine($"Número de existencias: {cantidad}");
        Console.WriteLine($"Precio total: {PrecioTotal()}");
        Console.WriteLine($"Estado de stock: {Existencias()}\n");
    }
}
