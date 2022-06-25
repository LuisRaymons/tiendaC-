namespace CapaPresentacion.Venta
{
    partial class PVenta
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
            this.dataGridViewventas = new System.Windows.Forms.DataGridView();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnnuevaventa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewventas
            // 
            this.dataGridViewventas.AllowUserToAddRows = false;
            this.dataGridViewventas.AllowUserToDeleteRows = false;
            this.dataGridViewventas.AllowUserToOrderColumns = true;
            this.dataGridViewventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewventas.Location = new System.Drawing.Point(-1, 45);
            this.dataGridViewventas.Name = "dataGridViewventas";
            this.dataGridViewventas.ReadOnly = true;
            this.dataGridViewventas.RowTemplate.Height = 25;
            this.dataGridViewventas.Size = new System.Drawing.Size(1005, 500);
            this.dataGridViewventas.TabIndex = 0;
            this.dataGridViewventas.DoubleClick += new System.EventHandler(this.dataGridViewventas_DoubleClick);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(12, 12);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PlaceholderText = "Buscar Venta";
            this.txtbusqueda.Size = new System.Drawing.Size(147, 23);
            this.txtbusqueda.TabIndex = 1;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // btnnuevaventa
            // 
            this.btnnuevaventa.Location = new System.Drawing.Point(941, 12);
            this.btnnuevaventa.Name = "btnnuevaventa";
            this.btnnuevaventa.Size = new System.Drawing.Size(97, 23);
            this.btnnuevaventa.TabIndex = 2;
            this.btnnuevaventa.Text = "Nueva Venta";
            this.btnnuevaventa.UseVisualStyleBackColor = true;
            this.btnnuevaventa.Click += new System.EventHandler(this.btnnuevaventa_Click);
            // 
            // PVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.btnnuevaventa);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.dataGridViewventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PVenta";
            this.Text = "PVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewventas;
        private TextBox txtbusqueda;
        private Button btnnuevaventa;
    }
}