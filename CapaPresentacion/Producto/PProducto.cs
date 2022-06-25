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

namespace CapaPresentacion.Producto
{
    public partial class PProducto : Form
    {
        private LoadingTienda loadings = new LoadingTienda();
        public PProducto()
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
            this.dataGridViewProductos.DataSource = NProducto.peticionesData("Obtener", 0, "", "", "", imgn, 0);
            this.loadings.Hide();
        }

        private void btnnewproduct_Click(object sender, EventArgs e)
        {
            PProductoNew pn = new PProductoNew();
            pn.ShowDialog();
            this.loadingtable();
        }

        private void dataGridViewProductos_DoubleClick(object sender, EventArgs e)
        {
            MsmConfirmaEditDelete msmconfirm = new MsmConfirmaEditDelete();
            msmconfirm.ShowDialog();

            int confirm = msmconfirm.ismodif;
            int idselect = Convert.ToInt32(this.dataGridViewProductos.CurrentRow.Cells["id"].Value);

            if (confirm == 1)
            {
                PProductoEdit pe = new PProductoEdit(idselect);
                pe.ShowDialog();
                this.loadingtable();
            } else if (confirm == 2)
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres Eliminar al producto seleccionada?", "Eliminar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                    byte[] imgn = { 0, 0, 0, 0 };
                    string responde = NProducto.peticiones("DELETE", idselect,"","","",imgn,0);

                    if (responde.Equals("1"))
                    {
                        this.mensajeok("El producto fue eliminado con exito");
                        this.loadingtable();
                    }
                    else
                    {
                        this.mensajeerror("Tubimos un error al eliminar al producto");
                    }
                }
            }
        }

        private void txtbusquedaproducto_TextChanged(object sender, EventArgs e)
        {
            byte[] imgn = { 0, 0, 0, 0 };
            this.dataGridViewProductos.DataSource = NProducto.peticionesData("TextoBuscar",0,this.txtbusquedaproducto.Text,"","", imgn,0);
        }

        private void PProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
