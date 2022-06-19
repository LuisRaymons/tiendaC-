using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

// ventanas
using CapaPresentacion.Categoria;
using CapaPresentacion.Producto;
using CapaPresentacion.Cliente;
using CapaPresentacion.Usuario;
using CapaPresentacion.Promotor;
using CapaPresentacion.Compra;
using CapaPresentacion.Venta;
using CapaPresentacion.PrecioProducto;


namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        private int widthslidenormal = 1050;
        private int widthslidemaimizar = 1280;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslider_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
                icontienda.Width = 70;
                // modificar el pannel container
                panelcontenedor.Width = this.widthslidenormal;
            }
            else
            {
                menuVertical.Width = 250;
                icontienda.Width = 250;
                // modificar el pannel conainer maximizar
                panelcontenedor.Width = this.widthslidemaimizar;
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconminimizar.Visible = false;
            //this.panelcontenedor.Width = 330;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconminimizar.Visible = true;
        }

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if(this.panelcontenedor.Controls.Count > 0)
            {
                this.panelcontenedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        
        /*------------------------------btn menu-----------------------------*/
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PCategoria(panelcontenedor.Width));
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PProducto());
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PCliente());
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PUsuario());
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PCompra());
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PVenta());
        }

        private void btnpromotor_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PPromotor());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PPrecioProducto());
        }
    }
}
