namespace CapaPresentacion.Usuario
{
    partial class PUsuario
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
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.btnnewusuario = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToAddRows = false;
            this.dataGridViewUsuario.AllowUserToDeleteRows = false;
            this.dataGridViewUsuario.AllowUserToOrderColumns = true;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(1, 53);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.RowTemplate.Height = 25;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(1004, 500);
            this.dataGridViewUsuario.TabIndex = 0;
            this.dataGridViewUsuario.DoubleClick += new System.EventHandler(this.dataGridViewUsuario_DoubleClick);
            // 
            // btnnewusuario
            // 
            this.btnnewusuario.Location = new System.Drawing.Point(888, 12);
            this.btnnewusuario.Name = "btnnewusuario";
            this.btnnewusuario.Size = new System.Drawing.Size(150, 23);
            this.btnnewusuario.TabIndex = 1;
            this.btnnewusuario.Text = "Nuevo Usuario";
            this.btnnewusuario.UseVisualStyleBackColor = true;
            this.btnnewusuario.Click += new System.EventHandler(this.btnnewusuario_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(22, 13);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PlaceholderText = "Buscar Usuario";
            this.txtbusqueda.Size = new System.Drawing.Size(139, 23);
            this.txtbusqueda.TabIndex = 2;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnnewusuario);
            this.Controls.Add(this.dataGridViewUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PUsuario";
            this.Text = "PUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewUsuario;
        private Button btnnewusuario;
        private TextBox txtbusqueda;
    }
}