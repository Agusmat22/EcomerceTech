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
        private Producto productoAsociado;
        DateTime fecha;

        public Venta(int id, int productoId, DateTime fecha, Producto producto)
        {
            this.id = id;
            this.productoId = productoId;
            this.fecha = fecha;
            this.productoAsociado = producto;
        }

        public int Id { get => id; set => id = value; }
        public int ProductoId { get => productoId; set => productoId = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Producto ProductoAsociado { get => productoAsociado; set => productoAsociado = value;}
    }
}
