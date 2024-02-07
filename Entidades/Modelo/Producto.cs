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
        private float precio;
        private ETipo tipo;
        private int stock;

        public Producto(int id, string nombre, float precio, ETipo tipo)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.tipo = tipo;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Id { get => id; set => id = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public int Stock { get => stock; set => stock = value; }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Producto prod && prod.id == this.id;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
