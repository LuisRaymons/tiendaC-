namespace CapaPresentacion.Compra
{
    partial class PCompraNew
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.selectproducto = new System.Windows.Forms.ComboBox();
            this.selectpromotor = new System.Windows.Forms.ComboBox();
            this.txtpreciototal = new System.Windows.Forms.TextBox();
            this.btnselectimg = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBoximg = new System.Windows.Forms.PictureBox();
            this.errorProvidermsm = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermsm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Compra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cerraricon;
            this.pictureBox1.Location = new System.Drawing.Point(515, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(29, 73);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(55, 15);
            this.Cantidad.TabIndex = 1;
            this.Cantidad.Text = "Cantidad";
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(29, 114);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(56, 15);
            this.Producto.TabIndex = 2;
            this.Producto.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promotor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio Total";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(111, 70);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(269, 23);
            this.txtcantidad.TabIndex = 5;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // selectproducto
            // 
            this.selectproducto.FormattingEnabled = true;
            this.selectproducto.Location = new System.Drawing.Point(111, 106);
            this.selectproducto.Name = "selectproducto";
            this.selectproducto.Size = new System.Drawing.Size(269, 23);
            this.selectproducto.TabIndex = 6;
            // 
            // selectpromotor
            // 
            this.selectpromotor.FormattingEnabled = true;
            this.selectpromotor.Items.AddRange(new object[] {
            "Seleccione"});
            this.selectpromotor.Location = new System.Drawing.Point(111, 147);
            this.selectpromotor.Name = "selectpromotor";
            this.selectpromotor.Size = new System.Drawing.Size(269, 23);
            this.selectpromotor.TabIndex = 7;
            // 
            // txtpreciototal
            // 
            this.txtpreciototal.Location = new System.Drawing.Point(111, 184);
            this.txtpreciototal.Name = "txtpreciototal";
            this.txtpreciototal.Size = new System.Drawing.Size(269, 23);
            this.txtpreciototal.TabIndex = 8;
            this.txtpreciototal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciototal_KeyPress);
            // 
            // btnselectimg
            // 
            this.btnselectimg.Location = new System.Drawing.Point(29, 224);
            this.btnselectimg.Name = "btnselectimg";
            this.btnselectimg.Size = new System.Drawing.Size(351, 23);
            this.btnselectimg.TabIndex = 9;
            this.btnselectimg.Text = "Seleccionar imagen";
            this.btnselectimg.UseVisualStyleBackColor = true;
            this.btnselectimg.Click += new System.EventHandler(this.btnselectimg_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(29, 253);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(351, 23);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(29, 282);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(351, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBoximg
            // 
            this.pictureBoximg.Location = new System.Drawing.Point(398, 70);
            this.pictureBoximg.Name = "pictureBoximg";
            this.pictureBoximg.Size = new System.Drawing.Size(127, 137);
            this.pictureBoximg.TabIndex = 12;
            this.pictureBoximg.TabStop = false;
            // 
            // errorProvidermsm
            // 
            this.errorProvidermsm.ContainerControl = this;
            // 
            // PCompraNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.Controls.Add(this.pictureBoximg);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnselectimg);
            this.Controls.Add(this.txtpreciototal);
            this.Controls.Add(this.selectpromotor);
            this.Controls.Add(this.selectproducto);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCompraNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCompraNew";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermsm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label Cantidad;
        private Label Producto;
        private Label label2;
        private Label label3;
        private TextBox txtcantidad;
        private ComboBox selectproducto;
        private ComboBox selectpromotor;
        private TextBox txtpreciototal;
        private Button btnselectimg;
        private Button btnguardar;
        private Button btncancelar;
        private PictureBox pictureBoximg;
        private ErrorProvider errorProvidermsm;
    }
}