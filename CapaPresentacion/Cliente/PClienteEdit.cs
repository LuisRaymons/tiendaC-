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
using Nancy.Json;

namespace CapaPresentacion.Cliente
{
    public partial class PClienteEdit : Form
    {
        private int idedit = 0;
        private bool ismodif = false;
        private string coloniaset = "";

        public PClienteEdit(int id)
        {
            InitializeComponent();
            this.asignaedit(id);
            this.idedit = id;
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private async void getcp(string cpsearch)
        {
            string url = "http://lrvatienda.xyz/api/codigo/postal";
            using var client = new HttpClient();
            var data = new Dictionary<string, string>
            {
                {"CP", cpsearch}
            };

            var res = await client.PostAsync(url, new FormUrlEncodedContent(data));
            var content = await res.Content.ReadAsStringAsync();
            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic cps = js.Deserialize<dynamic>(content);

            if (cps["code"] == 200)
            {
                this.comboBoxcoloniaseedit.Items.Clear();

                foreach (var cp in cps["data"])
                {
                    this.comboBoxcoloniaseedit.Items.Add(cp.colonia);
                    //this.comboBoxcolonias.Items.Insert(cp.id,cp.colonia);
                }

                
                if (!this.ismodif)
                {
                    this.comboBoxcoloniaseedit.SelectedText = this.coloniaset;
                }
                else
                {
                    this.comboBoxcoloniaseedit.Items.Insert(0, "SELECCIONE UNA COLONIA");
                    this.comboBoxcoloniaseedit.SelectedIndex = 0;
                }
                
            }

        }

        private void txteditcp_TextChanged(object sender, EventArgs e)
        {
            string cp = this.txteditcp.Text;
            this.getcp(cp);
        }

        private void asignaedit(int id)
        {
            IDataReader datos = NCliente.consultarclientebyid(id);

            while (datos.Read())
            {
                this.txteditname.Text = Convert.ToString(datos["nombre"]);
                this.txteditlastname.Text = Convert.ToString(datos["apellidos"]);
                this.txteditphone.Text = Convert.ToString(datos["telefono"]);

                this.txteditadress.Text = Convert.ToString(datos["direccion"]);
                this.txteditcp.Text = Convert.ToString(datos["cp"]);
                this.coloniaset = Convert.ToString(datos["colonia"]);
                this.comboBoxcoloniaseedit.SelectedText = Convert.ToString(datos["colonia"]); 
                /*
                if (datos["img"] != "")
                {
                    //byte[] archivo = (byte[])datos["img"]);
                    //byte[] archivo = (byte[]) datos["img"];
                    //MemoryStream ms = new MemoryStream(archivo);
                    //pictureBoximgeditproduct.Image = Image.FromStream(ms);
                }
                */
            }
        }

        private void txteditcp_Click(object sender, EventArgs e)
        {
            this.ismodif = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(this.txteditname.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmeditclient.SetError(this.txteditname, "Ingresa el nombre del cliente");
            }else if(this.txteditlastname.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmeditclient.SetError(this.txteditlastname, "Ingresa el apellidos del cliente");
            } else if(this.txteditphone.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmeditclient.SetError(this.txteditphone, "Ingresa el telefono del cliente");
            } else if(this.txteditadress.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmeditclient.SetError(this.txteditadress, "Ingresa el doicilio del cliente");
            } else if(this.txteditcp.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmeditclient.SetError(this.txteditcp, "Ingresa el codigo postal del cliente");
            } else if (this.comboBoxcoloniaseedit.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmeditclient.SetError(this.comboBoxcoloniaseedit, "Ingresa la colonia del cliente");
            }
            else
            {
                MemoryStream ms = new MemoryStream();

                if (this.pictureBox1.Image != null)
                {
                    this.pictureBox1.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NCliente.peticiones("Modificar", this.idedit, this.txteditname.Text.Trim(), this.txteditlastname.Text.Trim(), this.txteditphone.Text.Trim(), ms.GetBuffer(), this.txteditadress.Text.Trim(), Convert.ToInt32(this.txteditcp.Text.Trim()), this.comboBoxcoloniaseedit.Text);


                if (responde.Equals("1"))
                {
                    this.mensajeok("El cliente fue modificado con exito");
                    this.Close();
                }
                else
                {
                    this.mensajeerror("El cliente no se pudo modificar, intente mas tarde");
                }
            }
        }

        private void btnselectimg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoxclientedit.Image != null)
                {
                    this.pictureBoxclientedit.Image.Dispose();
                }
                this.pictureBoxclientedit.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoxclientedit.Image = Image.FromFile(oft.FileName);
                    this.pictureBoxclientedit.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }
    }
}
