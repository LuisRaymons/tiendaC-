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

namespace CapaPresentacion.Usuario
{
    public partial class PUsuario : Form
    {
        private LoadingTienda loadings = new LoadingTienda();
        public PUsuario()
        {
            InitializeComponent();
            this.loadingDataTable();
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

        public void loadingDataTable()
        {
            this.loadings.Show();
            byte[] imgn = { 0, 0, 0, 0 };
            this.dataGridViewUsuario.DataSource = NUsuario.peticionesData("Obtener",0,"","","", imgn,"","");
            this.loadings.Hide();
        }

        private void btnnewusuario_Click(object sender, EventArgs e)
        {
            PUsuarioNew newuser = new PUsuarioNew();
            newuser.ShowDialog();
            this.loadingDataTable();
        }

        private void dataGridViewUsuario_DoubleClick(object sender, EventArgs e)
        {
            MsmConfirmaEditDelete msmconfirm = new MsmConfirmaEditDelete();
            msmconfirm.ShowDialog();

            int confirm = msmconfirm.ismodif;
            int idselect = Convert.ToInt32(this.dataGridViewUsuario.CurrentRow.Cells["id"].Value);

            if (confirm == 1)
            {
                PUsuarioEdit ue = new PUsuarioEdit(idselect);
                ue.ShowDialog();
                this.loadingDataTable();

            } else if (confirm == 2)
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres eliminar al cliente seleccionada?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                    byte[] imgn = { 0, 0, 0, 0 };
                    string responde = NUsuario.peticiones("Eliminar", idselect,"","","", imgn,"","");

                    if (responde.Equals("1"))
                    {
                        this.mensajeok("El usuario fue eliminado con exito");
                        this.loadingDataTable();
                    }
                    else
                    {
                        this.mensajeerror("Tubimos un error al eliminar al usuario");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.txtbusqueda.Text != String.Empty)
            {
                this.loadings.Show();
                byte[] imgn = { 0, 0, 0, 0 };
                this.dataGridViewUsuario.DataSource = NUsuario.peticionesData("TextoBuscar", 0, Convert.ToString(this.txtbusqueda.Text), "", "", imgn, "", ""); ;
                this.loadings.Hide();
            }
            else
            {
                this.loadings.Show();
                byte[] imgn = { 0, 0, 0, 0 };
                this.dataGridViewUsuario.DataSource = NUsuario.peticionesData("Obtener", 0, "", "", "", imgn, "", "");
                this.loadings.Hide();
            }
        }
    }
}
