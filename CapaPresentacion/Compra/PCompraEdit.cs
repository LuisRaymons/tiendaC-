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
    public partial class PCompraEdit : Form
    {
        private int idEdit = 0;
        public PCompraEdit(int id)
        {
            InitializeComponent();
            this.loadingproducto();
            this.loadingpromotor();
            this.idEdit = id;
            this.asignadatos(id);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadingproducto()
        {
            byte[] imgn = { 0, 0, 0, 0 };
            DataTable productos = NProducto.peticionesData("SELECTPRODUCT", 0, "", "", "", imgn, 0);
            this.selecteditproduct.Items.Clear();

            this.selecteditproduct.DisplayMember = "nombre";
            this.selecteditproduct.ValueMember = "id";
            this.selecteditproduct.DataSource = productos;
        }
        private void loadingpromotor()
        {
            byte[] imgn = { 0, 0, 0, 0 };
            DataTable proveedores = NPromotor.peticionesData("SELECTPROMOTOR", 0, "", "", "", "", imgn);
            this.selecteditpromotor.Items.Clear();

            this.selecteditpromotor.DisplayMember = "nombre";
            this.selecteditpromotor.ValueMember = "id";
            this.selecteditpromotor.DataSource = proveedores;
        }
        private void asignadatos(int id)
        {
            IDataReader datos = NCompra.compraByid(id);

            while (datos.Read())
            {
                this.txteditcantidad.Text = Convert.ToString(datos["cantidad_stock"]);
                this.txtedittotal.Text = Convert.ToString(datos["precio_total"]);
                this.selecteditproduct.SelectedValue = Convert.ToInt32(datos["id_producto"]);
                this.selecteditpromotor.SelectedValue = Convert.ToInt32(datos["id_promotor"]);
            
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoxeditimg.Image != null)
                {
                    this.pictureBoxeditimg.Image.Dispose();
                }
                this.pictureBoxeditimg.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoxeditimg.Image = Image.FromFile(oft.FileName);
                    this.pictureBoxeditimg.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.txteditcantidad.Text == String.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.txteditcantidad, "Ingresa el numero de productos comprados");
            }
            else if (this.selecteditproduct.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.selecteditproduct, "Selecciona el producto comprado");
            }

            else if (this.selecteditpromotor.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.selecteditpromotor, "Selecciona el promotor de la compra");
            }
            else if (this.txtedittotal.Text == String.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsm.SetError(this.txtedittotal, "Ingresa el precio de la venta");
            }
            else
            {
                MemoryStream ms = new MemoryStream();

                if (this.pictureBoxeditimg.Image != null)
                {
                    this.pictureBoxeditimg.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NCompra.peticiones("Modificar", this.idEdit, "factura-gdfgdgdfg", Convert.ToInt32(this.txteditcantidad.Text), Convert.ToDouble(this.txtedittotal.Text), ms.GetBuffer(), Convert.ToInt32(selecteditproduct.SelectedValue), Convert.ToInt32(selecteditpromotor.SelectedValue));

                if (responde.Equals("2"))
                {
                    this.mensajeok("El registro de compra fue actualizado con exito");
                    this.Close();
                }
                else
                {
                    this.mensajeerror("El registrode compra no se pudo actualizar, intente mas tarde");
                }
            }
        }
    }
}
