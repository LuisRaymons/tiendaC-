using System.Data;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class PLogin : Form
    {
        public LoadingTienda loadings = new LoadingTienda();
        public PLogin()
        {
            InitializeComponent();
        }

        // Mostrar mensaje de error
        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtemail.Text == string.Empty)
            {
                this.mensajeerror("Debe ingresar un correo");
                errorProvidermsm.SetError(this.txtemail, "Ingrese un corro");
            }
            else if(this.txtpassword.Text == string.Empty)
            {
                this.mensajeerror("Debes ingresar tu contraseña");
                errorProvidermsm.SetError(this.txtpassword,"Ingrese una contraseña");
            } else if(this.txtpassword.TextLength < 8)
            {
                this.mensajeerror("Debes ingresar una contraseña con 8 caracteres como minimo");
                errorProvidermsm.SetError(this.txtpassword,"Ingresa una contraseña mas de 8 caracteres");
            }
            else
            {
                byte[] imgn = {0, 0, 0, 0};
                this.loadings.Show();
                DataTable datos = NUsuario.peticionesData("login",0,"",this.txtemail.Text,this.txtpassword.Text, imgn,"","");

                if(datos.Rows.Count > 0)
                {
                    int iduser = Convert.ToInt32(datos.Rows[0]["id"]);
                    string type = Convert.ToString(datos.Rows[0]["type"]);
                    string nombre = Convert.ToString(datos.Rows[0]["name"]);
                    this.loadings.Hide();
                    FrmPrincipal frmp = new FrmPrincipal(iduser,nombre, type);
                    frmp.Show();
                    this.Hide();
                    //PLogin login = new PLogin();
                    //login.Close();
                }
                else
                {
                    this.mensajeerror("Las contraseñas son incorrectas");
                    this.loadings.Hide();
                }
                
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(this.txtname.Text == string.Empty)
            {
                this.mensajeerror("Debes ingresar tu nombre");
                errorProvidermsm.SetError(this.txtname, "Ingrese un nombre");
            } else if(this.textemail.Text == string.Empty)
            {
                this.mensajeerror("Debes ingresar tu correo electronico");
                errorProvidermsm.SetError(this.textemail, "Ingrese una correo electronico");
            } else if(this.txtpassw.Text == string.Empty)
            {
                this.mensajeerror("Debes ingresar tu contraseña");
                errorProvidermsm.SetError(this.txtpassw, "Ingresa una contraseña");
            } else if(this.txtconfirmpassword.Text == string.Empty)
            {
                this.mensajeerror("Debes ingresar confirmacion de contraseña");
                errorProvidermsm.SetError(this.txtconfirmpassword, "Ingrese la confirmacion de contraseña");
            } else if(this.txtpassw.TextLength < 8)
            {
                this.mensajeerror("las Contraseñas debe tener minimo 8 caracteres");
                errorProvidermsm.SetError(this.txtpassw, "contraseña debe tener minimo 8 caracteres");
            } else if (this.txtpassw.Text != this.txtconfirmpassword.Text)
            {
                this.mensajeerror("las Contraseñas no cohiciden");
                errorProvidermsm.SetError(this.txtpassw, "contraseña no cohiciden");
                errorProvidermsm.SetError(this.txtconfirmpassword, "contraseña no cohiciden");
            }
            else
            {
                byte[] imgn = { 0, 0, 0, 0 };
                this.loadings.Show();
                //string responde = NUsuario.peticiones("Insertar",0,this.txtname.Text,this.textemail.Text,this.txtpassw.Text, imgn,"Cliente","sgdfgegdfgdkh");
                DataTable dt = NUsuario.peticionesData("Insertar", 0, this.txtname.Text, this.textemail.Text, this.txtpassw.Text, imgn, "Cliente", "sgdfgegdfgdkh");

                if(dt.Rows.Count > 0)
                {
                    int iduser = Convert.ToInt32(dt.Rows[0]["id"]);
                    string type = "Cliente";
                    string nombre = Convert.ToString(this.txtname.Text);
                    this.loadings.Hide();
                    FrmPrincipal frmp = new FrmPrincipal(iduser,nombre, type);
                    frmp.Show();
                    this.Hide();
                }
                else
                {
                    this.loadings.Hide();
                    this.mensajeerror("El registro de usuario no se pudo registrar con exito");
                }
            }
        }
    }
}
