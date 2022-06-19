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

namespace CapaPresentacion.Compra
{
    public partial class PCompra : Form
    {
        private LoadingTienda loadings = new LoadingTienda();
        public PCompra()
        {
            InitializeComponent();
            this.loadingtable();
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

        public void loadingtable()
        {
            this.loadings.Show();
            byte[] imgn = { 0, 0, 0, 0 };
            this.dataGridViewcompra.DataSource = NCompra.peticionesData("Obtener",0,"",0,0.00,imgn,0,0);
            this.loadings.Hide();
        }

        private void btnagregarcompra_Click(object sender, EventArgs e)
        {
            PCompraNew pcn = new PCompraNew();
            pcn.ShowDialog();
            this.loadingtable();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            if(this.txtbusqueda.Text != String.Empty)
            {
                this.loadings.Show();
                byte[] imgn = { 0, 0, 0, 0 };
                this.dataGridViewcompra.DataSource = NCompra.peticionesData("TextoBuscar", 0, "", 0, 0.00, imgn, 0, 0);
                this.loadings.Hide();
            }
            else
            {
                this.loadings.Show();
                byte[] imgn = { 0, 0, 0, 0 };
                this.dataGridViewcompra.DataSource = NCompra.peticionesData("Obtener", 0, Convert.ToString(this.txtbusqueda.Text), 0, 0.00, imgn, 0, 0);
                this.loadings.Hide();
            }
        }

        private void dataGridViewcompra_DoubleClick(object sender, EventArgs e)
        {
            MsmConfirmaEditDelete msmconfirm = new MsmConfirmaEditDelete();
            msmconfirm.ShowDialog();

            int confirm = msmconfirm.ismodif;
            int idselect = Convert.ToInt32(this.dataGridViewcompra.CurrentRow.Cells["id"].Value);

            if (confirm == 1)
            {
                PCompraEdit pce = new PCompraEdit(idselect);
                pce.ShowDialog();
                this.loadingtable();
            } else if(confirm == 2)
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres eliminar la compra seleccionada?", "Eliminar Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                    byte[] imgn = { 0, 0, 0, 0 };
                    string responde = NCompra.peticiones("Eliminar", idselect,"",0,0.00, imgn,0,0);

                    if (responde.Equals("1"))
                    {
                        this.mensajeok("El registro de compra fue eliminado con exito");
                        this.loadingtable();
                    }
                    else
                    {
                        this.mensajeerror("Error al eliminar el registro de compra, intente mas tarde");
                    }
                }
            }
        }
    }
}
