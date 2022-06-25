namespace CapaPresentacion.PrecioProducto
{
    partial class PPrecioProducto
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
            this.dataGridViewprecioproduct = new System.Windows.Forms.DataGridView();
            this.btnprrecioproductnew = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprecioproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewprecioproduct
            // 
            this.dataGridViewprecioproduct.AllowUserToAddRows = false;
            this.dataGridViewprecioproduct.AllowUserToDeleteRows = false;
            this.dataGridViewprecioproduct.AllowUserToOrderColumns = true;
            this.dataGridViewprecioproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewprecioproduct.Location = new System.Drawing.Point(-1, 47);
            this.dataGridViewprecioproduct.Name = "dataGridViewprecioproduct";
            this.dataGridViewprecioproduct.ReadOnly = true;
            this.dataGridViewprecioproduct.RowTemplate.Height = 25;
            this.dataGridViewprecioproduct.Size = new System.Drawing.Size(1005, 500);
            this.dataGridViewprecioproduct.TabIndex = 0;
            this.dataGridViewprecioproduct.DoubleClick += new System.EventHandler(this.dataGridViewprecioproduct_DoubleClick);
            // 
            // btnprrecioproductnew
            // 
            this.btnprrecioproductnew.Location = new System.Drawing.Point(785, 12);
            this.btnprrecioproductnew.Name = "btnprrecioproductnew";
            this.btnprrecioproductnew.Size = new System.Drawing.Size(201, 23);
            this.btnprrecioproductnew.TabIndex = 1;
            this.btnprrecioproductnew.Text = "Nuevo Precio a Producto";
            this.btnprrecioproductnew.UseVisualStyleBackColor = true;
            this.btnprrecioproductnew.Click += new System.EventHandler(this.btnprrecioproductnew_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(11, 15);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PlaceholderText = "Buscar producto";
            this.txtbusqueda.Size = new System.Drawing.Size(143, 23);
            this.txtbusqueda.TabIndex = 2;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // PPrecioProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnprrecioproductnew);
            this.Controls.Add(this.dataGridViewprecioproduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PPrecioProducto";
            this.Text = "PPrecioProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprecioproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewprecioproduct;
        private Button btnprrecioproductnew;
        private TextBox txtbusqueda;
    }
}