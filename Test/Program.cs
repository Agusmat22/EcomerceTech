using Entidades.Db;
using Entidades.Modelo;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto("Dell I7",1154.44,ETipo.notebook,4);

            List<Producto> productos = ADOProducto.Obtener();

            Console.WriteLine(productos.Count);
        }
    }
}
