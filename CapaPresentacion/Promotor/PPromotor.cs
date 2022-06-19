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

namespace CapaPresentacion.Promotor
{
    public partial class PPromotor : Form
    {
        private LoadingTienda loadings = new LoadingTienda();
        public PPromotor()
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
            this.dataGridViewpromotor.DataSource = NPromotor.peticionesData("Obtener",0,"","","","",imgn);
            this.loadings.Hide();
        }

        private void btnnewpromotor_Click(object sender, EventArgs e)
        {
            PPromotorNew ppn = new PPromotorNew();
            ppn.ShowDialog();
            this.loadingtable();
        }

        private void dataGridViewpromotor_DoubleClick(object sender, EventArgs e)
        {
            MsmConfirmaEditDelete msmconfirm = new MsmConfirmaEditDelete();
            msmconfirm.ShowDialog();

            int confirm = msmconfirm.ismodif;
            int idselect = Convert.ToInt32(this.dataGridViewpromotor.CurrentRow.Cells["id"].Value);

            if (confirm == 1)
            {
                PPromotorEdit pe = new PPromotorEdit(idselect);
                pe.ShowDialog();
                this.loadingtable();

            } else if(confirm == 2)
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres eliminar al cliente seleccionada?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                    byte[] imgn = { 0, 0, 0, 0 };

                    string responde = NPromotor.peticiones("Eliminar", idselect, "", "", "", "", imgn);

                    if (responde.Equals("1"))
                    {
                        this.mensajeok("El registro fue elimiinado con exito");
                        this.loadingtable();
                    }
                    else
                    {
                        this.mensajeerror("Error all eliminar el registro");
                    }
                }
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            if(this.txtbusqueda.Text != String.Empty)
            {
                this.loadings.Show();
                byte[] imgn = { 0, 0, 0, 0 };
                this.dataGridViewpromotor.DataSource = NPromotor.peticionesData("TextoBuscar", 0, Convert.ToString(this.txtbusqueda.Text), "", "", "", imgn);
                this.loadings.Hide();
            }
            else
            {
                this.loadings.Show();
                byte[] imgn = { 0, 0, 0, 0 };
                this.dataGridViewpromotor.DataSource = NPromotor.peticionesData("Obtener", 0, "", "", "", "", imgn);
                this.loadings.Hide();
            }
        }
    }
}
