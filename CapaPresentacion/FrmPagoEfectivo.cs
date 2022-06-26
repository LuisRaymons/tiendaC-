using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPagoEfectivo : Form
    {
        public bool pagobandera = false;
        private decimal ventatotal = 0.00m;
        public FrmPagoEfectivo(decimal preciototal)
        {
            InitializeComponent();
            this.txttotalventa.Text = Convert.ToString(preciototal);
            this.txttotalventa.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            if(this.txtpago.Text == string.Empty)
            {
                MessageBox.Show("Ingresa el dinero que recibes", "Sistema de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.ventatotal = Convert.ToDecimal(txtpago.Text) - Convert.ToDecimal(txttotalventa.Text);

                if (ventatotal >= 0)
                {
                    if (ventatotal > 0)
                    {
                        MessageBox.Show("Tu cambio es de $" + Convert.ToString(ventatotal) , "Sistema de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.pagobandera = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Necesita mas dinero para cubrir la venta", "Sistema de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            this.ventatotal = Convert.ToDecimal(txtpago.Text) - Convert.ToDecimal(txttotalventa.Text);

        }
    }
}
