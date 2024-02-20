using Entidades.Db;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Comercio: IAfip
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
            ADOProducto.Eliminar(prod); 
        }

        public void Modificar(Producto prod)
        {
            try
            {
                ADOProducto.Actualizar(prod);

            }
            catch (Exception) 
            {
                throw;
            }
        }

        
        //FALTA TERMINAR LA LOGICA
        public string Ticket(Venta venta)
        {
      
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Producto: {venta.Nombre}");
            sb.AppendLine($"Cantidad: {venta.Cantidad}");
            sb.AppendLine($"Precio neto: ${venta.Precio}");
            sb.AppendLine($"Impuesto 21%: ${this.CalcularIva(venta.Precio)}");
            sb.AppendLine($"Precio total: ${venta.Precio + this.CalcularIva(venta.Precio)}");

            return sb.ToString();
                     
        }

        public double CalcularIva(double precio)
        {
            return precio * 0.21;
        }

        public void Vender(Venta venta)
        {
            this.ventas.Add(venta);
            ADOVenta.Guardar(venta);
        }
    }
}
