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
    public partial class PVenta : Form
    {
        private int iduser;
        public PVenta(int iduser)
        {
            this.iduser = iduser;
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
            this.dataGridViewventas.DataSource = NVentas.peticionesData("Obtener",0,"",0.00,0,0,0);
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            if(this.txtbusqueda.Text != string.Empty)
            {
                this.dataGridViewventas.DataSource = NVentas.peticionesData("Obtenerfactura",0,this.txtbusqueda.Text,0.00,0,0,0);
            }
            else
            {
                this.dataGridViewventas.DataSource = NVentas.peticionesData("Obtener", 0, "", 0.00, 0, 0, 0);
            }
        }

        private void btnnuevaventa_Click(object sender, EventArgs e)
        {
            PVentaNew pvn = new PVentaNew(iduser);
            pvn.ShowDialog();
            this.loadingtable();
        }

        private void dataGridViewventas_DoubleClick(object sender, EventArgs e)
        {
            MsmConfirmaDetalleEliminar msm = new MsmConfirmaDetalleEliminar();
            msm.ShowDialog();

            int confirm = msm.isdetalle;
            int idselect = Convert.ToInt32(this.dataGridViewventas.CurrentRow.Cells["id"].Value);
            string facturaselect = Convert.ToString(this.dataGridViewventas.CurrentRow.Cells["factura"].Value);

            if (confirm == 1)
            {
                PVentaDetalle pVentaDetalle = new PVentaDetalle(facturaselect);
                pVentaDetalle.ShowDialog();
            }
            else if (confirm == 2)
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres eliminar la venta seleccionada?", "Eliminar venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                    string responde = NVentas.peticiones("Eliminar", idselect, "", 0.00, 0, 0, 0);

                    if (responde.Equals("2"))
                    {
                        this.mensajeok("Se elimino la venta con exito");
                        this.loadingtable();
                    }
                    else
                    {
                        this.mensajeerror("No se pudo eliminar la venta intente mas tarde");
                    }

                }
            }
        }
    }
}
