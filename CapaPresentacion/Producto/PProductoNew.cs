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

namespace CapaPresentacion.Producto
{
    public partial class PProductoNew : Form
    {
        public PProductoNew()
        {
            InitializeComponent();
            this.loadingcategoria();
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

        private void loadingcategoria()
        {
            this.selectcategoria.Items.Clear();
            IDataReader datos = NCategoria.categoriasselect();

            while (datos.Read())
            {
                this.selectcategoria.Items.Add(datos.GetString(1));
                this.selectcategoria.DisplayMember = "nombre";
                this.selectcategoria.ValueMember = "id";
            }
            
            this.selectcategoria.Items.Insert(0, "SELECCIONE UNA CATEGORIA");
            this.selectcategoria.SelectedIndex = 0;

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnselectimg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoxproductnew.Image != null)
                {
                    this.pictureBoxproductnew.Image.Dispose();
                }
                this.pictureBoxproductnew.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoxproductnew.Image = Image.FromFile(oft.FileName);
                    this.pictureBoxproductnew.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            } catch(OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(this.txtnewnameproducto.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmnewproduct.SetError(this.txtnewnameproducto, "Ingresa el nombre del producto");
            } else if(this.txtnewdescripcion.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmnewproduct.SetError(this.txtnewdescripcion, "Ingresa la descripcion del producto");
            }
            else if (this.selectcategoria.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmnewproduct.SetError(this.selectcategoria, "Seleccione una catwegoria valida");
            }
            else
            {
                string isporkilo = (this.checkBoxpreciokilo.Checked) ? "true" : "false";
                MemoryStream ms = new MemoryStream();

                if (this.pictureBoxproductnew.Image != null)
                {
                    this.pictureBoxproductnew.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NProducto.peticiones("Insertar", 0, this.txtnewnameproducto.Text.Trim(), this.txtnewdescripcion.Text.Trim(), isporkilo, ms.GetBuffer(), this.selectcategoria.SelectedIndex);
                if (responde.Equals("1"))
                {
                    this.limpiarinput();
                    this.mensajeok("El nuevo producto fue insertado con exito");
                    this.Close();
                }
                else
                {
                    this.mensajeerror("El producto no se pudo registrar, intente mas tarde");
                }
            }
        }

        private void limpiarinput()
        {
            this.txtnewnameproducto.Clear();
            this.txtnewdescripcion.Clear();

            this.pictureBoxproductnew.ImageLocation = "";
            this.pictureBoxproductnew.Image = null;
        }
    }
}
