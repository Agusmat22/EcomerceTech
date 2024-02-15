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
    public partial class FormModificar : Form
    {

        private Producto producto;

        public FormModificar(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        public Producto Producto { get => producto; set => producto = value; }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.producto.Nombre = this.txtNombre.Text;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtPrecio.Text, out int numero))
            {
                this.producto.Precio = numero;
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtPrecio.Text, out int numero))
            {
                this.producto.Stock = numero;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            ETipo tipo = (ETipo)Enum.Parse(typeof(ETipo), this.cmbTipo.Text);

            if (this.producto.Tipo != tipo)
            {
                this.producto.Tipo = tipo;

            }

        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.producto.Nombre;
            this.txtPrecio.Text = this.producto.Precio.ToString();
            this.txtStock.Text = this.producto.Stock.ToString();

            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));

            int numTipo = (int)this.producto.Tipo;

            this.cmbTipo.SelectedIndex = numTipo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
