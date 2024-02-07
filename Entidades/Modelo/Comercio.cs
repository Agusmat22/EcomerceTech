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

        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

    }
}
