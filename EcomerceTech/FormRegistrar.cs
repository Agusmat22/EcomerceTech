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
    public partial class FormRegistrar : Form
    {

        private string nombre;
        private double precio;
        private int stock;
        private ETipo tipo;

        private Producto producto;


        public FormRegistrar()
        {
            InitializeComponent();
        }
        public Producto Producto { get => producto; set => producto = value; }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if ( nombre != "" && precio > -1)
            {
                this.producto = new Producto(nombre, precio, tipo, stock);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            string textValido = "";


            foreach (char c in textBox.Text)
            {
                if ((c > 64 && c < 91 || c > 96 && c < 123) || c == 32)
                {
                    textValido += c;
                }
            }

            textBox.Text = textValido;

            this.nombre = textValido;

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            string textValido = "";


            foreach (char c in textBox.Text)
            {
                if (char.IsDigit(c) || c == 44)
                {
                    textValido += c;
                }
            }

            textBox.Text = textValido;

            if (double.TryParse(textValido, out double num  ))
            {
                this.precio = num;
            }

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            string textValido = "";


            foreach (char c in textBox.Text)
            {
                if (char.IsDigit(c))
                {
                    textValido += c;
                }
            }

            textBox.Text = textValido;

            if (int.TryParse(textValido, out int num))
            {
                this.stock = num;
            }
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {
            //Obtengo los elementos del ENUM y los casteo a una list
            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo)).Cast<ETipo>();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.tipo = (ETipo)this.cmbTipo.SelectedItem;
        }
    }
}
