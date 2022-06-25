namespace CapaPresentacion.Venta
{
    partial class PVentaNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectclient = new System.Windows.Forms.ComboBox();
            this.selectproducto = new System.Windows.Forms.ComboBox();
            this.selectpago = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addproduct = new FontAwesome.Sharp.IconButton();
            this.dataGridViewcontentproduct = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioneto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destroyproduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.labelprecio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcontentproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva venta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cerraricon;
            this.pictureBox1.Location = new System.Drawing.Point(642, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de pago";
            // 
            // selectclient
            // 
            this.selectclient.FormattingEnabled = true;
            this.selectclient.Location = new System.Drawing.Point(101, 80);
            this.selectclient.Name = "selectclient";
            this.selectclient.Size = new System.Drawing.Size(370, 23);
            this.selectclient.TabIndex = 4;
            // 
            // selectproducto
            // 
            this.selectproducto.FormattingEnabled = true;
            this.selectproducto.Location = new System.Drawing.Point(101, 117);
            this.selectproducto.Name = "selectproducto";
            this.selectproducto.Size = new System.Drawing.Size(370, 23);
            this.selectproducto.TabIndex = 5;
            // 
            // selectpago
            // 
            this.selectpago.FormattingEnabled = true;
            this.selectpago.Location = new System.Drawing.Point(101, 151);
            this.selectpago.Name = "selectpago";
            this.selectpago.Size = new System.Drawing.Size(370, 23);
            this.selectpago.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addproduct
            // 
            this.addproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addproduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addproduct.IconColor = System.Drawing.Color.Black;
            this.addproduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addproduct.IconSize = 17;
            this.addproduct.Location = new System.Drawing.Point(477, 120);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(27, 20);
            this.addproduct.TabIndex = 9;
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // dataGridViewcontentproduct
            // 
            this.dataGridViewcontentproduct.AllowUserToAddRows = false;
            this.dataGridViewcontentproduct.AllowUserToDeleteRows = false;
            this.dataGridViewcontentproduct.AllowUserToOrderColumns = true;
            this.dataGridViewcontentproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcontentproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Cantidad,
            this.product,
            this.precioneto,
            this.precio,
            this.destroyproduct});
            this.dataGridViewcontentproduct.Location = new System.Drawing.Point(22, 269);
            this.dataGridViewcontentproduct.Name = "dataGridViewcontentproduct";
            this.dataGridViewcontentproduct.ReadOnly = true;
            this.dataGridViewcontentproduct.RowTemplate.Height = 25;
            this.dataGridViewcontentproduct.Size = new System.Drawing.Size(645, 141);
            this.dataGridViewcontentproduct.TabIndex = 10;
            this.dataGridViewcontentproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcontentproduct_CellClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // product
            // 
            this.product.Frozen = true;
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // precioneto
            // 
            this.precioneto.Frozen = true;
            this.precioneto.HeaderText = "Precio neto";
            this.precioneto.Name = "precioneto";
            this.precioneto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.Frozen = true;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // destroyproduct
            // 
            this.destroyproduct.Frozen = true;
            this.destroyproduct.HeaderText = "Acciones";
            this.destroyproduct.Image = global::CapaPresentacion.Properties.Resources.bote;
            this.destroyproduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.destroyproduct.Name = "destroyproduct";
            this.destroyproduct.ReadOnly = true;
            this.destroyproduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.destroyproduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(536, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Location = new System.Drawing.Point(598, 215);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(0, 15);
            this.labelprecio.TabIndex = 12;
            // 
            // PVentaNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 434);
            this.Controls.Add(this.labelprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewcontentproduct);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectpago);
            this.Controls.Add(this.selectproducto);
            this.Controls.Add(this.selectclient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PVentaNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PVentaNew";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcontentproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox selectclient;
        private ComboBox selectproducto;
        private ComboBox selectpago;
        private Button button1;
        private Button button2;
        private FontAwesome.Sharp.IconButton addproduct;
        private DataGridView dataGridViewcontentproduct;
        private Label label5;
        private Label labelprecio;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn precioneto;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewImageColumn destroyproduct;
    }
}