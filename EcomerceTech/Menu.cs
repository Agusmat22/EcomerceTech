using Entidades.Db;
using Entidades.Modelo;

namespace EcomerceTech
{
    public delegate void AgregarProducto(Producto prod);
    public delegate void EliminarProducto(Producto prod);


    public partial class Menu : Form
    {
        private Comercio comercio;
        private AgregarProducto agregarProducto;
        private EliminarProducto eliminarProducto;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                List<Producto> productos = ADOProducto.Obtener();
                this.comercio = new Comercio(productos);

                //agrego mi metodo agregar al delegado para pasar este delegado entre las clases
                this.agregarProducto = comercio.Agregar;
                this.eliminarProducto = comercio.Eliminar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al leer la DB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cerrar", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos(this.comercio.Productos, this,
                                                            this.agregarProducto, this.eliminarProducto);

            this.Hide();

            formProductos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();

           formVentas.Show();
            this.Hide();
        }
    }
}
