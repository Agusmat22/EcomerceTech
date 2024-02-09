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


        public Comercio(List<Producto> productos)
        {
            this.productos = productos;
        }
        public List<Producto> Productos { get => productos; set => productos = value; }

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
