using System.Threading.Channels;

List<Inventario> productos = new List<Inventario>();
int cantidad;
do
{
    Console.WriteLine("Cuántos productos desea ingresar?");
    cantidad = int.Parse(Console.ReadLine());
    Console.Clear();
    if (cantidad <= 0)
    {
        Console.WriteLine("Debe ingresar al menos un producto");
    }
    else
    {
        for(int i =0; i<cantidad; i++)
        {
            Console.WriteLine($"Datos producto {i+1}\n");
            Inventario inven = new Inventario();
            Console.WriteLine("Nombre del producto: "); inven.nombre = Console.ReadLine();
            Console.WriteLine("Precio: "); inven.precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Existencias: "); inven.cantidad = int.Parse(Console.ReadLine());
            productos.Add(inven);
            Console.Clear();
        }
        Inventario mayor = productos[0];
        double total=0;
        Console.WriteLine("Listado de productos:\n");
        foreach(Inventario inven in productos)
        {
            inven.MostrarInfo();
            total += inven.PrecioTotal();
            if (inven.precio > mayor.precio)
            {
                mayor = inven;
            }
        }
        Console.WriteLine($"El precio valor de todo el inventario es: {total}");
        Console.WriteLine($"El producto con el mayor precio es: {mayor.nombre}");
    }
} while (cantidad<=0);
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
