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
    public partial class PCategoriaEdit : Form
    {
        int id = 0;

        public PCategoriaEdit(int id, string nombre)
        {
            InitializeComponent();
            this.id = id;
            this.txteditcategoria.Text = nombre;
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

        private void btnguardaeditcategoria_Click(object sender, EventArgs e)
        {
            DialogResult modificarcate = MessageBox.Show("¿Quieres modificar la categoria seleccionada?", "Modificar categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (modificarcate == DialogResult.OK)
            {
                string responde = NCategoria.peticiones("Modificar", id,this.txteditcategoria.Text);

                if (responde.Equals("1"))
                {
                    this.mensajeok("La categoria fue modificado con exito");
                    this.Close();
                }
                else
                {
                    this.mensajeerror("Ocurrio un problema al modificar la nueva categoria");
                }
            }
        }

        private void btncancelaredit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
