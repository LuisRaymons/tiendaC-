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
    public partial class msminputnumer : Form
    {
        public int cantidadesinput = 0;
        public msminputnumer()
        {
            InitializeComponent();
        }

        private void txtnumerproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtnumerproduct.Text, "  ^ [0-9]"))
            {
                txtnumerproduct.Text = "";
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            this.cantidadesinput = Convert.ToInt32(this.txtnumerproduct.Text);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
