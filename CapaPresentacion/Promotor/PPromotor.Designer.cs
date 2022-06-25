namespace CapaPresentacion.Promotor
{
    partial class PPromotor
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
            this.dataGridViewpromotor = new System.Windows.Forms.DataGridView();
            this.btnnewpromotor = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpromotor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewpromotor
            // 
            this.dataGridViewpromotor.AllowUserToAddRows = false;
            this.dataGridViewpromotor.AllowUserToDeleteRows = false;
            this.dataGridViewpromotor.AllowUserToOrderColumns = true;
            this.dataGridViewpromotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpromotor.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewpromotor.Name = "dataGridViewpromotor";
            this.dataGridViewpromotor.ReadOnly = true;
            this.dataGridViewpromotor.RowTemplate.Height = 25;
            this.dataGridViewpromotor.Size = new System.Drawing.Size(1004, 500);
            this.dataGridViewpromotor.TabIndex = 0;
            this.dataGridViewpromotor.DoubleClick += new System.EventHandler(this.dataGridViewpromotor_DoubleClick);
            // 
            // btnnewpromotor
            // 
            this.btnnewpromotor.Location = new System.Drawing.Point(870, 12);
            this.btnnewpromotor.Name = "btnnewpromotor";
            this.btnnewpromotor.Size = new System.Drawing.Size(159, 23);
            this.btnnewpromotor.TabIndex = 1;
            this.btnnewpromotor.Text = "Nuevo Promotor";
            this.btnnewpromotor.UseVisualStyleBackColor = true;
            this.btnnewpromotor.Click += new System.EventHandler(this.btnnewpromotor_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(12, 12);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PlaceholderText = "Buscar Promotor";
            this.txtbusqueda.Size = new System.Drawing.Size(146, 23);
            this.txtbusqueda.TabIndex = 2;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // PPromotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnnewpromotor);
            this.Controls.Add(this.dataGridViewpromotor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PPromotor";
            this.Text = "Promotor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpromotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewpromotor;
        private Button btnnewpromotor;
        private TextBox txtbusqueda;
    }
}