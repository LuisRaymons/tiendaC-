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

namespace CapaPresentacion.Venta
{
    public partial class PVentaDetalle : Form
    {
        public PVentaDetalle(string factura)
        {
            InitializeComponent();
            this.loadingdatosventadetail(factura);
        }

        private void loadingdatosventadetail(string factura)
        {
            DataTable datos = NVentas.peticionesData("ObtenerDetalle", 0, factura, 0.00, 0, 0, 0);
            this.dataGridViewdetailventa.DataSource = datos;
            this.dataGridViewdetailventa.Columns["id_venta"].Visible = false;
            this.dataGridViewdetailventa.Columns["factura"].Visible = false;
            this.dataGridViewdetailventa.Columns["precio_total"].Visible = false;
            this.dataGridViewdetailventa.Columns["tipopago"].Visible = false;
            this.dataGridViewdetailventa.Columns["cliente"].Visible = false;
            this.dataGridViewdetailventa.Columns["usuario"].Visible = false;

            this.txtfactura.Text = Convert.ToString(datos.Rows[0]["factura"]);
            this.txtpreciototal.Text = Convert.ToString(datos.Rows[0]["precio_total"]);
            this.txtpago.Text = Convert.ToString(datos.Rows[0]["tipopago"]);
            this.txtcliente.Text = Convert.ToString(datos.Rows[0]["cliente"]);
            this.txtatendidouser.Text = Convert.ToString(datos.Rows[0]["usuario"]);

            this.txtfactura.Enabled = false;
            this.txtpreciototal.Enabled = false;
            this.txtpago.Enabled = false;
            this.txtcliente.Enabled = false;
            this.txtatendidouser.Enabled = false;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
