using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using CapaNegocio;
using RestSharp;
using Newtonsoft.Json.Linq;
using Nancy.Json;
using System.Drawing.Imaging;

namespace CapaPresentacion.Cliente
{
    public partial class PPClienteNew : Form
    {
        public LoadingTienda loadings = new LoadingTienda();
        public PPClienteNew()
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(this.txtname.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmclientnew.SetError(this.txtname, "Ingresa el nombre del cliente");
            } else if(this.txtlasname.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmclientnew.SetError(this.txtlasname, "Ingresa el apellidos del cliente");
            }
            else if(this.txtphone.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmclientnew.SetError(this.txtphone, "Ingresa el telefono del cliente");
            } else if (this.txtaddres.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmclientnew.SetError(this.txtaddres, "Ingresa el doicilio del cliente");
            } else if(this.txtcp.Text == string.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmclientnew.SetError(this.txtcp, "Ingresa el codigo postal del cliente");
            } else if(this.comboBoxcolonias.SelectedIndex == 0)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errormsmclientnew.SetError(this.comboBoxcolonias, "Ingresa la colonia del cliente");
            }
            else
            {
                MemoryStream ms = new MemoryStream();

                if (this.pictureBoximgclient.Image != null)
                {
                    this.pictureBoximgclient.Image.Save(ms, ImageFormat.Bmp);
                }

                string responde = NCliente.peticiones("Insertar",0,this.txtname.Text.Trim(),this.txtlasname.Text.Trim(),this.txtphone.Text.Trim(), ms.GetBuffer(), this.txtaddres.Text.Trim(),Convert.ToInt32(this.txtcp.Text.Trim()),this.comboBoxcolonias.Text);


                if (responde.Equals("1"))
                {
                    this.limpiarinput();
                    this.mensajeok("El nuevo cliente fue insertado con exito");
                    this.Close();
                }
                else
                {
                    this.mensajeerror("El cliente no se pudo registrar, intente mas tarde");
                }
            }
        }

        public void limpiarinput()
        {
            this.txtname.Clear();
            this.txtlasname.Clear();
            this.txtphone.Clear();
            this.txtaddres.Clear();
            this.txtcp.Clear();
            this.comboBoxcolonias.Items.Clear();
            this.pictureBoximgclient.Image = null;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // web api request para codigo postal
        private async void getcp(string cpsearch)
        {

            if (cpsearch.Length == 5)
            {
                this.loadings.Show();
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
                    this.comboBoxcolonias.Items.Clear();

                    foreach (var cp in cps["data"])
                    {
                        this.comboBoxcolonias.Items.Add(cp.colonia);
                        //this.comboBoxcolonias.Items.Insert(cp.id,cp.colonia);
                    }

                    this.comboBoxcolonias.Items.Insert(0, "SELECCIONE UNA COLONIA");
                    this.comboBoxcolonias.SelectedIndex = 0;
                }
                //this.loadings.Close();
                this.loadings.Hide();

            }
            
        }

        private void txtcp_TextChanged(object sender, EventArgs e)
        {
            string textsearch = this.txtcp.Text;
            this.getcp(textsearch);
        }

        private void btnselectimg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pictureBoximgclient.Image != null)
                {
                    this.pictureBoximgclient.Image.Dispose();
                }
                this.pictureBoximgclient.Image = null;
                OpenFileDialog oft = new OpenFileDialog();
                oft.Filter = "Image files|*.jpg;*.jpeg;*.png;";

                if (DialogResult.OK == oft.ShowDialog())
                {
                    this.pictureBoximgclient.Image = Image.FromFile(oft.FileName);
                    this.pictureBoximgclient.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("Out of Memory: {0}", ex.Message);
            }
        }

        private void PPClienteNew_Load(object sender, EventArgs e)
        {
        }
    }



    public class cp
    {
        public int CP {get; set;}
    }
}
