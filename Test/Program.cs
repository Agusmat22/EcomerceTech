﻿using Entidades.Modelo;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto(1,"Motorala",1154,"2gb");
            Producto p2 = new Producto(2,"Motorala",1154,"2gb");
            /*
            ETipo[] lista = (ETipo[])Enum.GetValues(typeof(ETipo));

            foreach (ETipo item in lista)
            {
                Console.WriteLine((int)item);
            }*/
        }
    }
}