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
    public partial class PCategoriaNew : Form
    {
        public PCategoriaNew()
        {
            InitializeComponent();
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(this.txtnamecategoria.Text != String.Empty)
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres agregar la nueva categoria?", "Agregar nueva categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                     string responde = NCategoria.peticiones("Insertar", 0, this.txtnamecategoria.Text);

                    if (responde.Equals("1"))
                    {
                        PCategoria cateogiatab = new PCategoria();

                        this.txtnamecategoria.Clear();
                        this.Close();
                        this.mensajeok("La categoria fue creada con exito");

                    }
                    else
                    {
                        this.mensajeerror("Ocurrio un problema al crear la nueva categoria");
                    }
                }  
            }
            else
            {
                mensajeerror("Faltan ingresar algunos datos, seran remarcados");
                erromsmcategoriane.SetError(txtnamecategoria, "Ingrese el nombre de la categoria");
            }
        }
    }
}
