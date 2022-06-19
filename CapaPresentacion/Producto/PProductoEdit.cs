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
using System.Drawing.Imaging;

namespace CapaPresentacion.Producto
{
    public partial class PProductoEdit : Form
    {
        private int idEdit = 0;
        public PProductoEdit(int id)
        {
            InitializeComponent();
            this.loadingcategoria();
            this.asignaedit(id);
            this.idEdit = id;
        }

        private void asignaedit(int id)
        {
            IDataReader datos = NProducto.consultarproductbyid(id);

            while (datos.Read())
            {
                this.txtnameeditproduct.Text = Convert.ToString(datos["nombre"]); //datos.GetString(1);
                this.txtdescripcioneditproduct.Text = Convert.ToString(datos["descripcion"]); //datos.GetString(2);
                this.comboBoxcategoriaedit.Text = Convert.ToString(datos["categoria"]);

                if (Convert.ToBoolean(datos["precioPorKilo"]))
                {
                    this.checkBoxpreciokiloeditproduct.Checked = true;
                }
                else
                {
                    this.checkBoxpreciokiloeditproduct.Checked = false;
                }
            }

            //byte[] archivo = (byte[])datos["img"]);
            //byte[] archivo = (byte[]) datos["img"];
            //MemoryStream ms = new MemoryStream(archivo);
            //pictureBoximgeditproduct.Image = Image.FromStream(ms);
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
            this.comboBoxcategoriaedit.Items.Clear();
            IDataReader datos = NCategoria.categoriasselect();

            while (datos.Read())
            {
                this.comboBoxcategoriaedit.Items.Add(datos.GetString(1));
                this.comboBoxcategoriaedit.DisplayMember = "nombre";
                this.comboBoxcategoriaedit.ValueMember = "id";
            }

            this.comboBoxcategoriaedit.Items.Insert(0, "SELECCIONE UNA CATEGORIA");
            this.comboBoxcategoriaedit.SelectedIndex = 0;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncanceleditproduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnselectimgproductedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoximgeditproduct.Image != null)
                {
                    this.pictureBoximgeditproduct.Image.Dispose();
                }
                this.pictureBoximgeditproduct.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoximgeditproduct.Image = Image.FromFile(oft.FileName);
                    this.pictureBoximgeditproduct.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }

        private void btnguardaeditproduct_Click(object sender, EventArgs e)
        {
            if(this.txtnameeditproduct.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmedit.SetError(this.txtnameeditproduct, "Ingresa el nombre del producto");
            } else if(this.txtdescripcioneditproduct.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmedit.SetError(this.txtdescripcioneditproduct, "Ingresa la descripcion del producto");
            } else if(this.comboBoxcategoriaedit.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmedit.SetError(this.comboBoxcategoriaedit, "Seleccione una categoria");
            }
            else
            {
                string isporkilo = (this.checkBoxpreciokiloeditproduct.Checked) ? "true" : "false";
                MemoryStream ms = new MemoryStream();

                if (this.checkBoxpreciokiloeditproduct.Image != null)
                {
                    this.checkBoxpreciokiloeditproduct.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NProducto.peticiones("Modificar", this.idEdit, this.txtnameeditproduct.Text, this.txtdescripcioneditproduct.Text, isporkilo, ms.GetBuffer(), this.comboBoxcategoriaedit.SelectedIndex);

                if (responde.Equals("1"))
                {
                    this.mensajeok("El registro fue modificado con exito");
                    this.Close();
                }
                else
                {
                    this.mensajeerror("Error al modificar el producto, intente mas tarde");
                }
            }
        }
    }
}
