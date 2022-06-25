using System.Data;
using CapaNegocio;

namespace CapaPresentacion.Venta
{
    public partial class PVentaNew : Form
    {
        private int iduser;
        private LoadingTienda loadings = new LoadingTienda();
        private decimal preciototal = 0.00M;
        public PVentaNew(int iduser)
        {
            this.iduser = iduser;
            InitializeComponent();
            loadingclients();
            loadingproductos();
            loadingpagos();
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

        private void loadingclients()
        {
            byte[] imgn = { 0, 0, 0, 0 };
            DataTable clientes = NCliente.peticionesData("SELECTCLIENT", 0, "", "", "", imgn, "", 0, "");
            this.selectclient.Items.Clear();

            this.selectclient.DisplayMember = "nombre";
            this.selectclient.ValueMember = "id";
            this.selectclient.DataSource = clientes;
            
        }
        private void loadingproductos()
        {
            byte[] imgn = { 0, 0, 0, 0 };
            DataTable productos = NProducto.peticionesData("SELECTPRODUCT", 0, "", "", "", imgn, 0);
            this.selectproducto.Items.Clear();

            this.selectproducto.DisplayMember = "nombre";
            this.selectproducto.ValueMember = "id";
            this.selectproducto.DataSource = productos;
        }

        private void loadingpagos()
        {
            DataTable pagos = NVentas.peticionesData("TipoPago",0,"",0.00,0,0,0);

            this.selectpago.Items.Clear();

            this.selectpago.DisplayMember = "name";
            this.selectpago.ValueMember = "id";
            this.selectpago.DataSource = pagos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Agreagar productos al carrito
        private void addproduct_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.selectproducto.SelectedValue) == 0)
            {
                this.mensajeerror("Seleccione un producto");
            }
            else
            {
                byte[] imgn = { 0, 0, 0, 0 };
                DataTable dtexistalmacen = NCompra.peticionesData("Almacendata", 0, "", 0, 0.00, imgn, Convert.ToInt32(this.selectproducto.SelectedValue), 0);

                if (dtexistalmacen.Rows.Count > 0)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridViewcontentproduct);

                    IDataReader precio = NPrecioProducto.obtenerpreciobyid(Convert.ToInt32(this.selectproducto.SelectedValue));
                    while (precio.Read())
                    {
                        bool existproduct = dataGridViewcontentproduct.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["product"].Value) == Convert.ToString(precio["nombre"]));
                        if (!existproduct)
                        {
                            msminputnumer msinputnumer = new msminputnumer();
                            msinputnumer.ShowDialog();
                            int cantidadprod = msinputnumer.cantidadesinput;

                            if(cantidadprod > 0)
                            {
                                if (cantidadprod <= Convert.ToInt32(dtexistalmacen.Rows[0]["stock"]))
                                {
                                    fila.Cells[0].Value = precio["id"];
                                    fila.Cells[1].Value = cantidadprod;
                                    fila.Cells[2].Value = precio["nombre"];
                                    fila.Cells[3].Value = Convert.ToDecimal(precio["precio"]);
                                    fila.Cells[4].Value = decimal.Round(Convert.ToDecimal(precio["precio"]) * Convert.ToInt32(cantidadprod));

                                    preciototal = decimal.Round(preciototal + Convert.ToDecimal(precio["precio"]) * Convert.ToInt32(cantidadprod));

                                    this.labelprecio.Text = Convert.ToString(preciototal);
                                    dataGridViewcontentproduct.Rows.Add(fila);
                                }
                                else
                                {
                                    this.mensajeerror("No se encuentran los productos suficientes para esta compra");
                                }
                            }
                            else
                            {

                            }
                            //if (Convert.ToInt32(dtexistalmacen.Rows[0]["stock"]) > 0)
                            

                        }
                        else
                        {
                            this.mensajeerror("El registro ya se encuentra en el carrito de compras");
                        }
                    }
                }
                else
                {
                    this.mensajeerror("No se encontraro el producto en almacen");
                }

                
            }
        }

        // Bonton de pagar
        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(this.selectpago.SelectedValue) == 0)
            {
                this.mensajeerror("Seleccione el tipo de pago");
            } else if(this.dataGridViewcontentproduct.RowCount < 1)
            {
                this.mensajeerror("No se encontraron productos en el carrito");
            }
            else
            {
                this.loadings.Show();
                bool banderainserts = false;
                // insercion de la venta
                int pago = Convert.ToInt32(this.selectpago.SelectedValue);
                int client = Convert.ToInt32(this.selectclient.SelectedValue) == 0 ? 1 : Convert.ToInt32(this.selectclient.SelectedValue);

                DataTable dt = NVentas.peticionesData("Insertar",0,"gsfdfgfdsfgfs", Convert.ToDouble(preciototal),pago,client, this.iduser);

                // insercion de detalle de venta
                foreach (DataGridViewRow c in this.dataGridViewcontentproduct.Rows)
                {
                    int idventa = Convert.ToInt32(dt.Rows[0]["id"]);
                    int idproduct = Convert.ToInt32(c.Cells["id"].Value);
                    int cantidaproduct = Convert.ToInt32(c.Cells["cantidad"].Value);
                    double precio = Convert.ToInt32(c.Cells["precio"].Value);

                    string responde = NDVenta.peticiones("Insertar",0, idventa, idproduct, cantidaproduct,precio);

                    if (responde.Equals("2"))
                    {
                        banderainserts = true;
                    }
                    else
                    {
                        banderainserts = false;
                    }
                }

                this.loadings.Hide();
                if (banderainserts)
                {
                    this.mensajeok("Se registro con exito la venta");
                    this.Close();
                }
                else
                {
                    // eliminiar los registros de venta y detalle de venta
                    foreach(DataGridViewRow dr in this.dataGridViewcontentproduct.Rows)
                    {
                        string responde = NDVenta.peticiones("EliminarVenta",0, Convert.ToInt32(dr.Cells["id"].Value),0,0,0.00);
                    }
                    this.mensajeerror("Error al insertar la venta intente nuevamente");
                }
            }   
        }

        private void dataGridViewcontentproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewcontentproduct.Columns[e.ColumnIndex].Name == "destroyproduct")
            {
                DialogResult Eliminarcate = MessageBox.Show("¿Quieres eliminar al producto " + this.dataGridViewcontentproduct.CurrentRow.Cells[2].Value.ToString() + "?", "Eliminar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Eliminarcate == DialogResult.OK)
                {
                    foreach (DataGridViewRow c in this.dataGridViewcontentproduct.Rows)
                    {
                        preciototal = preciototal - Convert.ToDecimal(c.Cells["precio"].Value);
                        this.labelprecio.Text = Convert.ToString(preciototal);

                        this.dataGridViewcontentproduct.Rows.Remove(c);
                    }
                }
    
            }
        }
    }
}
