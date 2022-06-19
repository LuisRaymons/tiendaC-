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
    public partial class PPrecioProducto : Form
    {
        private LoadingTienda loadings = new LoadingTienda();
        public PPrecioProducto()
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

        private void loadingtable()
        {
            this.loadings.Show();
            this.dataGridViewprecioproduct.DataSource = NPrecioProducto.peticionesData("Obtener",0,0.00,0,"");
            this.loadings.Hide();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            this.dataGridViewprecioproduct.DataSource = NPrecioProducto.peticionesData("PRODUCTONAME",0,0.00,0,Convert.ToString(this.txtbusqueda.Text));
        }

        private void btnprrecioproductnew_Click(object sender, EventArgs e)
        {
            PPrecioProductoNew ppn = new PPrecioProductoNew();
            ppn.ShowDialog();
            this.loadingtable();
        }

        private void dataGridViewprecioproduct_DoubleClick(object sender, EventArgs e)
        {
            MsmConfirmaEditDelete msmconfirm = new MsmConfirmaEditDelete();
            msmconfirm.ShowDialog();

            int confirm = msmconfirm.ismodif;
            int idselect = Convert.ToInt32(this.dataGridViewprecioproduct.CurrentRow.Cells["id"].Value);

            if (confirm == 1)
            {
                PPrecioProductoEdit ppe = new PPrecioProductoEdit(idselect);
                ppe.ShowDialog();
                this.loadingtable();
            } else if(confirm == 2)
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres eliminar el precio de producto seleccionado?", "Eliminar precio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                    string responde = NPrecioProducto.peticiones("Eliminar", idselect, 0.00, 0, "");

                    if (responde.Equals("1"))
                    {
                        this.mensajeok("El registro se elimino con exito");
                        this.loadingtable();
                    }
                    else
                    {
                        this.mensajeerror("No se pudo eliminar el precio del producto, intente mas tarde");
                    }
                }
            }
        }
    }
}
