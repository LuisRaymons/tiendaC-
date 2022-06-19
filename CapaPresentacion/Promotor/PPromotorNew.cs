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

namespace CapaPresentacion.Promotor
{
    public partial class PPromotorNew : Form
    {
        public PPromotorNew()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(this.txtname.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                this.errorProvidermsm.SetError(this.txtname,"Se requiere de un nombrbe de promotor");
            } else if(this.txtaddress.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                this.errorProvidermsm.SetError(this.txtaddress,"Se requiere la direcccion del promotor");
            } else if(this.txtphone.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                this.errorProvidermsm.SetError(this.txtphone, "Se requiere del telefono del promotor");
            }
            else
            {
                MemoryStream ms = new MemoryStream();

                if (this.pictureBoximgpromotor.Image != null)
                {
                    this.pictureBoximgpromotor.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NPromotor.peticiones("Insertar",0,this.txtname.Text,this.txtaddress.Text,this.txtphone.Text,this.txtwebsite.Text, ms.GetBuffer());

                if (responde.Equals("1"))
                {
                    this.mensajeok("El registro de promotor ya fue registrado con exito");
                    this.limpiarinput();
                    this.Close();
                }
                else
                {
                    this.mensajeerror("Error al guardar el nuevo promotor");
                }
            }
            
        }

        private void limpiarinput()
        {
            this.txtname.Clear();
            this.txtaddress.Clear();
            this.txtphone.Clear();
            this.txtwebsite.Clear();
        }

        private void btnselecimg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoximgpromotor.Image != null)
                {
                    this.pictureBoximgpromotor.Image.Dispose();
                }
                this.pictureBoximgpromotor.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoximgpromotor.Image = Image.FromFile(oft.FileName);
                    this.pictureBoximgpromotor.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }
    }
}
