namespace CapaPresentacion.Producto
{
    partial class PProducto
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.txtbusquedaproducto = new System.Windows.Forms.TextBox();
            this.btnnewproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(1, 49);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowTemplate.Height = 25;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1005, 500);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.DoubleClick += new System.EventHandler(this.dataGridViewProductos_DoubleClick);
            // 
            // txtbusquedaproducto
            // 
            this.txtbusquedaproducto.Location = new System.Drawing.Point(1, 12);
            this.txtbusquedaproducto.Name = "txtbusquedaproducto";
            this.txtbusquedaproducto.PlaceholderText = "Buscar producto";
            this.txtbusquedaproducto.Size = new System.Drawing.Size(150, 23);
            this.txtbusquedaproducto.TabIndex = 1;
            this.txtbusquedaproducto.TextChanged += new System.EventHandler(this.txtbusquedaproducto_TextChanged);
            // 
            // btnnewproduct
            // 
            this.btnnewproduct.Location = new System.Drawing.Point(917, 12);
            this.btnnewproduct.Name = "btnnewproduct";
            this.btnnewproduct.Size = new System.Drawing.Size(113, 23);
            this.btnnewproduct.TabIndex = 2;
            this.btnnewproduct.Text = "Nuevo Producto";
            this.btnnewproduct.UseVisualStyleBackColor = true;
            this.btnnewproduct.Click += new System.EventHandler(this.btnnewproduct_Click);
            // 
            // PProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.btnnewproduct);
            this.Controls.Add(this.txtbusquedaproducto);
            this.Controls.Add(this.dataGridViewProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PProducto";
            this.Text = "PProducto";
            this.Load += new System.EventHandler(this.PProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewProductos;
        private TextBox txtbusquedaproducto;
        private Button btnnewproduct;
    }
}