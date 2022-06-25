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
        private int iduser;
        public FrmPrincipal(int iduser,string nombre,string type)
        {
            InitializeComponent();
            this.iduser = iduser;
            this.labelnameuser.Text = nombre;

            if (type == "Administrador")
            {
                this.loadingadminuser();
            } else if (type == "Ventas")
            {
                this.loadingventasuser();
            } else if (type == "Almacen")
            {
                this.loadingalmacenuser();
            } else if (type == "Cliente")
            {
                this.loadingclienteuser();
            }            
        }

        public void loadingadminuser()
        {
            this.btnCategorias.Enabled = true;
            this.btnProductos.Enabled = true;
            this.btncliente.Enabled = true;
            this.btnusuario.Enabled = true;
            this.btnpromotor.Enabled = true;
            this.btncompra.Enabled = true;
            this.btnventa.Enabled = true;
            this.btnprecio.Enabled = true;
        }
        public void loadingventasuser()
        {
            this.btnCategorias.Enabled = true;
            this.btnProductos.Enabled = true;
            this.btncliente.Enabled = false;
            this.btnusuario.Enabled = false;
            this.btnpromotor.Enabled = true;
            this.btncompra.Enabled = false;
            this.btnventa.Enabled = true;
            this.btnprecio.Enabled = false;
        }
        public void loadingalmacenuser()
        {
            this.btnCategorias.Enabled = false;
            this.btnProductos.Enabled = true;
            this.btncliente.Enabled = false;
            this.btnusuario.Enabled = false;
            this.btnpromotor.Enabled = true;
            this.btncompra.Enabled = true;
            this.btnventa.Enabled = false;
            this.btnprecio.Enabled = false;
        }
        public void loadingclienteuser()
        {
            this.btnCategorias.Enabled = false;
            this.btnProductos.Enabled = false;
            this.btncliente.Enabled = false;
            this.btnusuario.Enabled = false;
            this.btnpromotor.Enabled = false;
            this.btncompra.Enabled = false;
            this.btnventa.Enabled = false;
            this.btnprecio.Enabled = false;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslider_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 250)
            {
                menuVertical.Width = 50;
                icontienda.Width = 50;
                this.labelnameuser.Width = 50;
            }
            else
            {
                menuVertical.Width = 250;
                icontienda.Width = 250;
                this.labelnameuser.Width = 250;
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
            this.AbrirFormInPanel(new PVenta(iduser));
        }

        private void btnpromotor_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PPromotor());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.AbrirFormInPanel(new PPrecioProducto());
        }

        private void btncerrarsession_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Application.Exit();
            PLogin loginfrm = new PLogin();
            loginfrm.ShowDialog();   
        }
    }
}
