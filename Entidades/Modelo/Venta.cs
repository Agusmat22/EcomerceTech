using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Venta
    {

        private int id;
        private int productoId;
        private int cantidad;
        private Producto productoAsociado;
        DateTime fecha;

        public Venta(int id, int productoId, DateTime fecha, Producto producto, int cantidad)
        {
            this.id = id;
            this.productoId = productoId;
            this.fecha = fecha;
            this.productoAsociado = producto;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public int ProductoId { get => productoId; set => productoId = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Producto ProductoAsociado { get => productoAsociado; set => productoAsociado = value;}
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public double Precio { get => productoAsociado.Precio * this.cantidad; }
        public string Nombre { get => productoAsociado.Nombre; }

        public static bool operator ==(Venta ven1, Venta ven2 )
        {
            return ven1.Id == ven2.Id;
        }

        public static bool operator !=(Venta ven1, Venta ven2)
        {
            return !(ven1.Id == ven2.Id);
        }
    }
}
