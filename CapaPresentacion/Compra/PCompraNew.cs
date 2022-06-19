using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Compra
{
    public partial class PCompraNew : Form
    {
        public PCompraNew()
        {
            InitializeComponent();
            this.loadingproducto();
            this.loadingpromotor();
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

        private void loadingproducto()
        {
            byte[] imgn = { 0, 0, 0, 0 };
            DataTable productos = NProducto.peticionesData("SELECTPRODUCT", 0,"","","", imgn,0);
            this.selectproducto.Items.Clear();

            this.selectproducto.DisplayMember = "nombre";
            this.selectproducto.ValueMember = "id";
            this.selectproducto.DataSource = productos;
        }
        private void loadingpromotor()
        {
            byte[] imgn = { 0, 0, 0, 0 };
            DataTable proveedores = NPromotor.peticionesData("SELECTPROMOTOR", 0,"","","","", imgn);
            this.selectpromotor.Items.Clear();
   
            this.selectpromotor.DisplayMember = "nombre";
            this.selectpromotor.ValueMember = "id";
            this.selectpromotor.DataSource = proveedores;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(this.txtcantidad.Text == String.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.txtcantidad, "Ingresa el numero de productos comprados");
            }
            else if (this.selectproducto.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.selectproducto, "Selecciona el producto comprado");
            } 
            
            else if(this.selectpromotor.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.selectpromotor, "Selecciona el promotor de la compra");
            }
            else if (this.txtpreciototal.Text == String.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.txtpreciototal, "Ingresa el precio de la venta");
            }
            else
            {
                MemoryStream ms = new MemoryStream();

                if (this.pictureBoximg.Image != null)
                {
                    this.pictureBoximg.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NCompra.peticiones("Insertar",0,"factura-gdfgdgdfg",Convert.ToInt32(this.txtcantidad.Text),Convert.ToDouble(this.txtpreciototal.Text), ms.GetBuffer(),Convert.ToInt32(selectproducto.SelectedValue), Convert.ToInt32(selectpromotor.SelectedValue));

                if (responde.Equals("2"))// regresa dos por que realiza dos inserciones
                {
                    this.mensajeok("El registro de la compra fue registrado con exito");
                    this.limpiarinput();
                    this.Close();
                }
                else
                {
                    this.mensajeerror("Error al guardar la compra, intente mas tarde");
                }
            }
        }

        public void limpiarinput()
        {
            this.txtcantidad.Clear();
            this.txtpreciototal.Clear();
            //this.loadingproducto();
            //this.loadingpromotor();
        }

        private void btnselectimg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoximg.Image != null)
                {
                    this.pictureBoximg.Image.Dispose();
                }
                this.pictureBoximg.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoximg.Image = Image.FromFile(oft.FileName);
                    this.pictureBoximg.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpreciototal_KeyPress(object sender, KeyPressEventArgs e)
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
