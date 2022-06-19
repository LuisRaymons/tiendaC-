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

namespace CapaPresentacion.Cliente
{
    public partial class PCliente : Form
    {
        private LoadingTienda loadings = new LoadingTienda();
        public PCliente()
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

        public async void loadingDataTable()
        {
            this.loadings.Show();
            byte[] imgn = {0, 0, 0, 0};
            this.dataGridViewCliente.DataSource = NCliente.peticionesData("Obtener",0,"","","", imgn,"",0,"");
            this.loadings.Hide();
        }

        private void btnaddclient_Click(object sender, EventArgs e)
        {
            PPClienteNew ce = new PPClienteNew();
            ce.ShowDialog();
            this.loadingDataTable();
        }

        private void dataGridViewCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dataGridViewCliente.Columns[e.ColumnIndex].Name)
            {
                case "img":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = e.Value; //Image.FromFile(e.Value.ToString());
                        } catch(System.IO.FileNotFoundException ex)
                        {
                            e.Value = null;
                        }
                        catch (NotSupportedException)
                        {
                            e.Value = null;
                        }
                    }
                break;
            }
        }

        private void dataGridViewCliente_DoubleClick(object sender, EventArgs e)
        {
            MsmConfirmaEditDelete msmconfirm = new MsmConfirmaEditDelete();
            msmconfirm.ShowDialog();

            int confirm = msmconfirm.ismodif;
            int idselect = Convert.ToInt32(this.dataGridViewCliente.CurrentRow.Cells["id"].Value);

            if (confirm == 1)
            {
                PClienteEdit pce = new PClienteEdit(idselect);
                pce.ShowDialog();
                this.loadingDataTable();
            } else if(confirm == 2)
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres eliminar al cliente seleccionada?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                    byte[] imgn = { 0, 0, 0, 0 };
                    //string responde = NProducto.peticiones("DELETE", idselect, "", "", "", imgn, 0);
                    string responde = NCliente.peticiones("Eliminar", idselect, "", "", "", imgn, "", 0, "");

                    if (responde.Equals("1"))
                    {
                        this.mensajeok("El cliente fue eliminado con exito");
                        this.loadingDataTable();
                    }
                    else
                    {
                        this.mensajeerror("Tubimos un error al eliminar al cliente");
                    }
                }
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            if(this.txtbusqueda.Text != string.Empty)
            {
                this.loadings.Show();
                byte[] imgn = { 0, 0, 0, 0 };
                this.dataGridViewCliente.DataSource = NCliente.peticionesData("TextoBuscar", 0, Convert.ToString(this.txtbusqueda.Text), "", "", imgn, "", 0, "");
                this.loadings.Hide();
            }
            else
            {
                this.loadings.Show();
                byte[] imgn = { 0, 0, 0, 0 };
                this.dataGridViewCliente.DataSource = NCliente.peticionesData("Obtener", 0, "", "", "", imgn, "", 0, "");
                this.loadings.Hide();
            }
        }
    }
}
