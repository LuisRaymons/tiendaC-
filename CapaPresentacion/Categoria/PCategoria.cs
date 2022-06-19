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

namespace CapaPresentacion.Categoria
{
    public partial class PCategoria : Form
    {
        private LoadingTienda loadings = new LoadingTienda();

        public PCategoria(int anchowindows = 1080)
        {
            InitializeComponent();
            this.loadingdatatable();
            this.Width = anchowindows;
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

        public void loadingdatatable()
        {
            this.loadings.Show();
            this.datagridviewcategoria.DataSource = null;
            this.datagridviewcategoria.DataSource = NCategoria.peticionesData("Obtener", 0,"");
            this.loadings.Hide();
        }

        private void btnagregarcategoria_Click(object sender, EventArgs e)
        {
            PCategoriaNew frmnewcategoria = new PCategoriaNew();
            frmnewcategoria.ShowDialog();
            this.loadingdatatable();
        }

        private void txtbuscarcategoria_TextChanged(object sender, EventArgs e)
        {
            if(txtbuscarcategoria.Text != string.Empty)
            {
                this.datagridviewcategoria.DataSource = NCategoria.peticionesData("TextoBuscar", 0, this.txtbuscarcategoria.Text);
            }
            else
            {
                this.datagridviewcategoria.DataSource = NCategoria.peticionesData("Obtener", 0, "");
            }
        }

        private void datagridviewcategoria_DoubleClick(object sender, EventArgs e)
        {
            MsmConfirmaEditDelete msmconfirm = new MsmConfirmaEditDelete();
            msmconfirm.ShowDialog();
            int confirm = msmconfirm.ismodif;
            int idselect = Convert.ToInt32(this.datagridviewcategoria.CurrentRow.Cells["id"].Value);
            string namecategoria = Convert.ToString(this.datagridviewcategoria.CurrentRow.Cells["nombre"].Value);

            if (confirm == 1)
            {
                PCategoriaEdit editcate = new PCategoriaEdit(idselect, namecategoria);
                editcate.ShowDialog();
                this.loadingdatatable();
            } else if (confirm == 2)
            {

                DialogResult Eliminarcate = MessageBox.Show("¿Quieres Eliminar la categoria seleccionada?", "Eliminar categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)

                {
                    string response = NCategoria.peticiones("Eliminar", idselect, "");

                    if (response.Equals("1"))
                    {
                        this.mensajeok("La categoria fue eliminado con exito");
                        this.loadingdatatable();
                    }
                    else
                    {
                        this.mensajeerror("Tubimos un error al eliminar la categoria");
                    }
                }
            }


        }
    }
}
