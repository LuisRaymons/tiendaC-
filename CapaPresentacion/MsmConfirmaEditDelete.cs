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
    public partial class MsmConfirmaEditDelete : Form
    {
        public int ismodif = 0;
        public MsmConfirmaEditDelete()
        {
            InitializeComponent();
        }

        // btn modificar
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            this.ismodif = 1;
            this.Close();
        }

        // btn cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            this.ismodif = 0;
            this.Close();
        }

        // btn eliminar
        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.ismodif = 2;
            this.Close();
        }

        // btn cerrar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.ismodif = 0;
            this.Close();
        }
    }
}
