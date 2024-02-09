using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo

{
    public enum ETipo
    {
        notebook,
        smartphone,
        tv,
        pc
    }


    public class Producto
    {
        private int id;
        private string nombre;
        private double precio;
        private ETipo tipo;
        private int stock;


        public Producto()
        {

        }

        public Producto(string nombre, double precio, ETipo tipo, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.tipo = tipo;
            this.stock = stock;



        }

        public Producto(int id, string nombre, double precio, ETipo tipo, int stock): this(nombre,precio,tipo,stock) 
        {
            this.id = id;

        }


        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Id { get => id; set => id = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public int Stock { get => stock; set => stock = value; }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Producto prod && prod.id == this.id;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Precio: {this.precio}");
            stringBuilder.AppendLine($"Stock: {this.stock}");
            stringBuilder.AppendLine($"Tipo: {this.tipo}");


            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
