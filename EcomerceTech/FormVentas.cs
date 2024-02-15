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
    public partial class FormVentas : Form
    {

        private readonly Comercio comercio;
        private Menu menu;

        public FormVentas(Comercio comercio, Menu menu)
        {
            InitializeComponent();
            this.comercio = comercio;
            this.menu = menu;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));
            this.ActualizarDgv((venta) => venta.ProductoAsociado.Tipo == (ETipo)this.cmbTipo.SelectedItem);

        }

        private void LimpiarDgv()
        {
            this.dgvVentas.DataSource = null;
            this.dgvVentas.Rows.Clear();

        }

        private void ActualizarDgv(Predicate<Venta> condicionTipo)
        {

            this.LimpiarDgv();

            foreach (Venta item in this.comercio.Ventas)
            {
                if (condicionTipo(item))
                {
                    this.dgvVentas.Rows.Add(

                        item.ProductoAsociado.Nombre,
                        "$ " + item.ProductoAsociado.Precio.ToString(),
                        item.ProductoAsociado.Tipo,
                        item.Fecha.ToString("dd/MM/yyyy")

                    );

                }


            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarDgv((venta) => venta.ProductoAsociado.Tipo == (ETipo)this.cmbTipo.SelectedItem);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.menu.Show();
            this.Close();

        }

        private void FormVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.menu.Show();
        }
    }
}
