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

namespace CapaPresentacion.PrecioProducto
{
    public partial class PPrecioProductoEdit : Form
    { 
        private int idEdit = 0;
        public PPrecioProductoEdit(int id)
        {
            InitializeComponent();
            this.txtproductedit.Enabled = false;
            this.idEdit = id;
            this.loadingdatos(id);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadingdatos(int id)
        {
            IDataReader datos = NPrecioProducto.obtenerpreciobyid(id);

            while (datos.Read())
            {
                this.txtproductedit.Text = Convert.ToString(datos["nombre"]);
                this.txtprecioedit.Text = Convert.ToString(datos["precio"]);
            }
        }

        private void btnguardaredit_Click(object sender, EventArgs e)
        {
            if(this.txtprecioedit.Text == String.Empty)
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                errorProvidermsmedit.SetError(this.txtprecioedit, "Seleccione un producto");
            }
            else
            {
                string responde = NPrecioProducto.peticiones("Modificar",this.idEdit,Convert.ToDouble(txtprecioedit.Text),0,"");
                if (responde.Equals("1"))
                {
                    mensajeok("El registro se actualizo con exito");
                    this.Close();
                }
                else
                {
                    mensajeerror("El registro no se pudo actualizar, intente mas tarde");
                }
            }
        }
    }
}
