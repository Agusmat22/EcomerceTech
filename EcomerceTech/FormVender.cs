using Entidades.Db;
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
    public partial class FormVender : Form
    {
        private Comercio comercio;
        private Menu menu;
        private Venta venta;
        private Producto producto;


        public FormVender(Comercio comercio, Menu menu)
        {
            InitializeComponent();
            this.comercio = comercio;
            this.menu = menu;
        }

        private void FormVender_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));
            this.cmbTipo.SelectedIndex = 0;
            this.ActualizarLstb();

        }

        private void ActualizarLstb()
        {
            this.lstbProductos.DataSource = null;
            this.lstbProductos.DataSource = this.FiltrarProductos();


        }

        private List<Producto> FiltrarProductos()
        {
            List<Producto> productoFiltrados = new List<Producto>();

            foreach (Producto item in this.comercio.Productos)
            {
                if (item.Tipo == (ETipo)this.cmbTipo.SelectedItem)
                {
                    productoFiltrados.Add(item);
                }
            }

            return productoFiltrados;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.menu.Show();
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarLstb();

        }

        private void FormVender_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.menu.Show();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

            this.MostrarTicket();

        }

        private void lstbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.producto = (Producto)this.lstbProductos.SelectedItem;
            this.nudCantidad.Value = 0;


        }

        private void MostrarTicket()
        {
            this.venta = new Venta(this.comercio.Ventas.Count, this.producto.Id, DateTime.Now.Date, this.producto, (int)this.nudCantidad.Value);

            this.rtbTicket.Text = this.comercio.Ticket(this.venta);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                ADOVenta.Guardar(venta);

                MessageBox.Show("Venta exitosa, desea imprimir el ticket?");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
