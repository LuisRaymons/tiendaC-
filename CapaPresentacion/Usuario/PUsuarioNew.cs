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

namespace CapaPresentacion.Usuario
{
    public partial class PUsuarioNew : Form
    {
        public PUsuarioNew()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiarinput();
            this.Close();
        }


        private void limpiarinput()
        {
            this.txtname.Clear();
            this.txtemail.Clear();
            this.txtpassword.Clear();
            this.txtconfirmpassword.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(this.txtname.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmuser.SetError(this.txtname, "Ingresa el nombre del usuario");
            } else if(this.txtemail.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmuser.SetError(this.txtemail, "Ingresa el correo del usuario");
            } else if (this.validaemail(this.txtemail.Text) == false)
            {
                mensajeerror("El correo ingresado no es correcto ejemp. uncorreo@hotmail.com");
                errormsmuser.SetError(this.txtemail, "El correo ingresado no tiene un formato valido");
            }
            else if(this.txtpassword.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmuser.SetError(this.txtpassword, "Ingresa la contraseña del usuario");
            } else if(this.txtconfirmpassword.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmuser.SetError(this.txtconfirmpassword, "Ingresa la confnirmacion de la contraseña del usuario");
            } else if(this.txtpassword.Text != this.txtconfirmpassword.Text)
            {
                mensajeerror("Las contraseñas no cohiciden");
                errormsmuser.SetError(this.txtpassword, "Contraseña no cohiciden");
                errormsmuser.SetError(this.txtconfirmpassword, "Contraseña no cohicide");
            } else if (this.comboBoxtipouser.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmuser.SetError(this.comboBoxtipouser, "Seleccione el tipo de usuario");
            }
            else
            {
                MemoryStream ms = new MemoryStream();

                if (this.pictureBoxiconuser.Image != null)
                {
                    this.pictureBoxiconuser.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NUsuario.peticiones("Insertar",0,this.txtname.Text,this.txtemail.Text,this.txtpassword.Text, ms.GetBuffer(),this.comboBoxtipouser.Text, "fdsafewffvfdgds");

                if (responde.Equals("1"))
                {
                    mensajeok("El registro fue insertado con exito");
                    this.limpiarinput();
                    this.Close();
                }
                else
                {
                    mensajeerror("NO se pudo insertar el registro de usuario, intente mas tarde");
                    this.limpiarinput();
                }
            }
        }

        private bool validaemail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnselectimg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoxiconuser.Image != null)
                {
                    this.pictureBoxiconuser.Image.Dispose();
                }
                this.pictureBoxiconuser.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoxiconuser.Image = Image.FromFile(oft.FileName);
                    this.pictureBoxiconuser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }
    }
}
