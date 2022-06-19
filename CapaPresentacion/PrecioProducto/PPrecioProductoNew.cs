using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.PrecioProducto
{
    public partial class PPrecioProductoNew : Form
    {
        public PPrecioProductoNew()
        {
            InitializeComponent();
            this.loadingproduct();
        }

        // Mostrar mensaje de cinfirmacion
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Mostrar mensaje de error
        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void loadingproduct()
        {
            DataTable productos = NPrecioProducto.peticionesData("OBTENERPRODUCTFALTANTE",0,0.00,0,"");
            this.selectproducts.Items.Clear();

            this.selectproducts.DisplayMember = "nombre";
            this.selectproducts.ValueMember = "id";
            this.selectproducts.DataSource = productos;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(this.selectproducts.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.selectproducts, "Seleccione un producto");
            } else if(this.txtprecio.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.txtprecio, "Ingresa el precio del producto");
            }
            else
            {
                string responde = NPrecioProducto.peticiones("Insertar",0,Convert.ToDouble(this.txtprecio.Text),Convert.ToInt32(this.selectproducts.SelectedValue),"");

                if (responde.Equals("1"))
                {
                    this.mensajeok("El precio del producto fue guardado con exito");
                    this.txtprecio.Clear();
                    this.Close();
                }
                else
                {
                    this.mensajeerror("El registro del precio del producto no se pudo guardar, intente otra vez");
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
