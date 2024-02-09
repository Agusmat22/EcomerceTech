using Entidades.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Comercio
    {
        private List<Producto> productos;
        private List<Venta> ventas;


        public Comercio(List<Producto> productos, List<Venta> ventas)
        {
            this.productos = productos;
            this.ventas = ventas;
        }
        public List<Producto> Productos { get => productos; set => productos = value; }
        public List<Venta> Ventas { get => ventas; set => ventas = value; }

        /// <summary>
        /// Agrega un producto
        /// </summary>
        /// <param name="prod"></param>
        public void Agregar(Producto prod)
        {
            this.productos.Add(prod);
            ADOProducto.Guardar(prod);
        }

        /// <summary>
        /// Elimina un producto que se encuentre en stock
        /// </summary>
        /// <param name="prod"></param>
        public void Eliminar(Producto prod)
        {
            this.productos.Remove(prod);
        }

    }
}
