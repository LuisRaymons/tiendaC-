namespace CapaPresentacion
{
    public partial class MsmConfirmaDetalleEliminar : Form
    {
        public int isdetalle = 0;
        public MsmConfirmaDetalleEliminar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            this.isdetalle = 1;
            this.Close();
        }

        private void btnEliminiar_Click(object sender, EventArgs e)
        {
            this.isdetalle = 2;
            this.Close();
        }
    }
}
