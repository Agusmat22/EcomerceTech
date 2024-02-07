using Entidades.Modelo;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto(1,"Motorala",1154,ETipo.notebook);
            Producto p2 = new Producto(2,"Motorala",1154,ETipo.tv);
            /*
            ETipo[] lista = (ETipo[])Enum.GetValues(typeof(ETipo));

            foreach (ETipo item in lista)
            {
                Console.WriteLine((int)item);
            }*/
        }
    }
}
