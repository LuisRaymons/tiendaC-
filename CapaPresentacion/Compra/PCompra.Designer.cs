namespace CapaPresentacion.Compra
{
    partial class PCompra
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
            this.dataGridViewcompra = new System.Windows.Forms.DataGridView();
            this.btnagregarcompra = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewcompra
            // 
            this.dataGridViewcompra.AllowUserToAddRows = false;
            this.dataGridViewcompra.AllowUserToDeleteRows = false;
            this.dataGridViewcompra.AllowUserToOrderColumns = true;
            this.dataGridViewcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcompra.Location = new System.Drawing.Point(-1, 46);
            this.dataGridViewcompra.Name = "dataGridViewcompra";
            this.dataGridViewcompra.ReadOnly = true;
            this.dataGridViewcompra.RowTemplate.Height = 25;
            this.dataGridViewcompra.Size = new System.Drawing.Size(1004, 500);
            this.dataGridViewcompra.TabIndex = 0;
            this.dataGridViewcompra.DoubleClick += new System.EventHandler(this.dataGridViewcompra_DoubleClick);
            // 
            // btnagregarcompra
            // 
            this.btnagregarcompra.Location = new System.Drawing.Point(894, 12);
            this.btnagregarcompra.Name = "btnagregarcompra";
            this.btnagregarcompra.Size = new System.Drawing.Size(144, 23);
            this.btnagregarcompra.TabIndex = 1;
            this.btnagregarcompra.Text = "Nueva Venta";
            this.btnagregarcompra.UseVisualStyleBackColor = true;
            this.btnagregarcompra.Click += new System.EventHandler(this.btnagregarcompra_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(12, 12);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PlaceholderText = "Buscar Compra";
            this.txtbusqueda.Size = new System.Drawing.Size(169, 23);
            this.txtbusqueda.TabIndex = 2;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // PCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnagregarcompra);
            this.Controls.Add(this.dataGridViewcompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCompra";
            this.Text = "PCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewcompra;
        private Button btnagregarcompra;
        private TextBox txtbusqueda;
    }
}