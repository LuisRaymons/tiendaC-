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
    public partial class PUsuarioEdit : Form
    {
        private int idEdit = 0;
        public PUsuarioEdit(int id)
        {
            InitializeComponent();
            this.txteditpassword.Visible = false;
            this.txteditconfirpassword.Visible = false;
            this.labelpassuser.Visible = false;
            this.labelconfirmpassuser.Visible = false;
            this.asignadatos(id);
            this.idEdit = id;
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

        public void asignadatos(int id)
        {
            // getUserId
            IDataReader datos = NUsuario.getUserId(id);

            while (datos.Read())
            {
                this.txtnameedit.Text = Convert.ToString(datos["name"]);
                this.txtemailedit.Text = Convert.ToString(datos["email"]);
                this.comboBoxedittypeuser.Text = Convert.ToString(datos["type"]);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxcangepassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxcangepassword.Checked == true)
            {
                this.txteditpassword.Visible = true;
                this.txteditconfirpassword.Visible = true;
                this.labelpassuser.Visible = true;
                this.labelconfirmpassuser.Visible = true;
            }
            else
            {
                this.txteditpassword.Visible = false;
                this.txteditconfirpassword.Visible = false;
                this.labelpassuser.Visible = false;
                this.labelconfirmpassuser.Visible = false;
            }
        }

        private void btnguardaredit_Click(object sender, EventArgs e)
        {
            if (this.txtnameedit.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmedituser.SetError(this.txtnameedit, "Ingresa el nombre del usuario");
            }
            else if (this.comboBoxedittypeuser.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmedituser.SetError(this.comboBoxedittypeuser, "Seleccione el tipo de usuario");
            }
            else
            {
                MemoryStream ms = new MemoryStream();

                if (this.pictureBoxedituser.Image != null)
                {
                    this.pictureBoxedituser.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NUsuario.peticiones("Modificar",this.idEdit,this.txtnameedit.Text,this.txtemailedit.Text,this.txteditpassword.Text, ms.GetBuffer(),this.comboBoxedittypeuser.Text,"");

                if (responde.Equals("1"))
                {
                    this.mensajeok("El registro se modifico con exito");
                    this.Close();
                }
                else
                {
                    this.mensajeerror("Error al modificar el registro, intente mas tarde");
                }
            }
        }

        private void btnselectimgedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoxedituser.Image != null)
                {
                    this.pictureBoxedituser.Image.Dispose();
                }
                this.pictureBoxedituser.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoxedituser.Image = Image.FromFile(oft.FileName);
                    this.pictureBoxedituser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }
    }
}
