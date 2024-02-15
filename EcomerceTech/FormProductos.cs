using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcomerceTech
{
    public partial class FormProductos : Form
    {
        private List<Producto> productos;
        private Menu formMenu;
        private Producto productoSeleccionado;
        private AgregarProducto agregarProducto;
        private EliminarProducto eliminarProducto;
        private ActualizarProducto actualizarProducto;

        public FormProductos(List<Producto> producto, Menu formMenu,
                             AgregarProducto agregarProducto, EliminarProducto eliminarProducto, ActualizarProducto actualizarProducto )
        {
            InitializeComponent();
            this.productos = producto;
            this.formMenu = formMenu;
            this.agregarProducto = agregarProducto;
            this.eliminarProducto = eliminarProducto;
            this.actualizarProducto = actualizarProducto;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.ActualizarListBox();

            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo)).Cast<ETipo>();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMenu.Show();
        }

        private void lstTiposProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.productoSeleccionado = (Producto)this.lstTiposProductos.SelectedItem;

            ActualizarCampos();




        }

        private void ActualizarCampos()
        {
            if (this.productoSeleccionado is not null)
            {
                this.txtProducto.Text = this.productoSeleccionado.Nombre;
                this.txtTipo.Text = this.productoSeleccionado.Tipo.ToString();
                this.txtPrecio.Text = this.productoSeleccionado.Precio.ToString();
                this.txtStock.Text = this.productoSeleccionado.Stock.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormRegistrar formRegistrar = new FormRegistrar();

            DialogResult result = formRegistrar.ShowDialog();

            if (result == DialogResult.OK)
            {
                //guardo el producto en mi delegate
                this.agregarProducto(formRegistrar.Producto);

                this.ActualizarListBox();


            }
            else
            {
                MessageBox.Show("Cancelo");

            }
        }


        private void ActualizarListBox()
        {
            this.lstTiposProductos.DataSource = null;

            this.lstTiposProductos.DataSource = this.productos;

            this.lstTiposProductos.SelectedIndex = -1;


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.lstTiposProductos.SelectedIndex != -1)
            {
                this.eliminarProducto((Producto)this.lstTiposProductos.SelectedItem);

                this.ActualizarListBox();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificar formModificar = new FormModificar(this.productoSeleccionado);
  
            DialogResult result = formModificar.ShowDialog();
            
            if (result == DialogResult.OK) 
            {
                this.actualizarProducto( formModificar.Producto );
                this.ActualizarListBox();
            }
        }
    }
}
