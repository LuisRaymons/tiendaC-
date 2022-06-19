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

namespace CapaPresentacion.Promotor
{
    public partial class PPromotorEdit : Form
    {
        private int idEdit = 0;
        public PPromotorEdit(int id)
        {
            InitializeComponent();
            this.idEdit = id;
            this.asignaredit(id);
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

        private void asignaredit(int id)
        {
            IDataReader datos = NPromotor.promotorbyid(id);

            while (datos.Read())
            {
                this.txteditname.Text = Convert.ToString(datos["nombre"]);
                this.txteditaddress.Text = Convert.ToString(datos["direccion"]);
                this.txteditphone.Text = Convert.ToString(datos["telefono"]);
                this.txteditwebsite.Text = Convert.ToString(datos["sitioWeb"]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelaredit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardaredit_Click(object sender, EventArgs e)
        {
            if(this.txteditname.Text == String.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                this.errorProvidereditmsm.SetError(this.txteditname, "Se requiere de un nombrbe de promotor");
            } else if(this.txteditaddress.Text == String.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                this.errorProvidereditmsm.SetError(this.txteditaddress, "Se requiere la direcccion del promotor");
            } else if(this.txteditphone.Text == String.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                this.errorProvidereditmsm.SetError(this.txteditphone, "Se requiere del telefono del promotor");
            }
            else
            {
                byte[] imgn = { 0, 0, 0, 0 };
                string responde = NPromotor.peticiones("Modificar",this.idEdit,this.txteditname.Text,this.txteditaddress.Text,this.txteditphone.Text,this.txteditwebsite.Text, imgn);

                if (responde.Equals("1"))
                {
                    this.mensajeok("El registro de promotor se actualizo con exito");
                    this.Close();
                }
                else
                {
                    this.mensajeerror("Error al actualizar el registro, intente mas tarde");
                }
            }
        }

        private void btnseleccionarimg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoximgedit.Image != null)
                {
                    this.pictureBoximgedit.Image.Dispose();
                }
                this.pictureBoximgedit.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoximgedit.Image = Image.FromFile(oft.FileName);
                    this.pictureBoximgedit.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }
    }
}
