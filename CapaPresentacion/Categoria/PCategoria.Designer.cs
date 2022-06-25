namespace CapaPresentacion.Categoria
{
    partial class PCategoria
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
            this.datagridviewcategoria = new System.Windows.Forms.DataGridView();
            this.btnagregarcategoria = new FontAwesome.Sharp.IconButton();
            this.txtbuscarcategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewcategoria
            // 
            this.datagridviewcategoria.AllowUserToAddRows = false;
            this.datagridviewcategoria.AllowUserToDeleteRows = false;
            this.datagridviewcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewcategoria.Location = new System.Drawing.Point(0, 59);
            this.datagridviewcategoria.Name = "datagridviewcategoria";
            this.datagridviewcategoria.ReadOnly = true;
            this.datagridviewcategoria.RowTemplate.Height = 25;
            this.datagridviewcategoria.Size = new System.Drawing.Size(1005, 500);
            this.datagridviewcategoria.TabIndex = 0;
            this.datagridviewcategoria.DoubleClick += new System.EventHandler(this.datagridviewcategoria_DoubleClick);
            // 
            // btnagregarcategoria
            // 
            this.btnagregarcategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnagregarcategoria.IconColor = System.Drawing.Color.Black;
            this.btnagregarcategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarcategoria.Location = new System.Drawing.Point(914, 12);
            this.btnagregarcategoria.Name = "btnagregarcategoria";
            this.btnagregarcategoria.Size = new System.Drawing.Size(124, 30);
            this.btnagregarcategoria.TabIndex = 1;
            this.btnagregarcategoria.Text = "Nueva Categoria";
            this.btnagregarcategoria.UseVisualStyleBackColor = true;
            this.btnagregarcategoria.Click += new System.EventHandler(this.btnagregarcategoria_Click);
            // 
            // txtbuscarcategoria
            // 
            this.txtbuscarcategoria.Location = new System.Drawing.Point(11, 20);
            this.txtbuscarcategoria.Name = "txtbuscarcategoria";
            this.txtbuscarcategoria.PlaceholderText = "Buscar Categoria";
            this.txtbuscarcategoria.Size = new System.Drawing.Size(179, 23);
            this.txtbuscarcategoria.TabIndex = 2;
            this.txtbuscarcategoria.TextChanged += new System.EventHandler(this.txtbuscarcategoria_TextChanged);
            // 
            // PCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.txtbuscarcategoria);
            this.Controls.Add(this.btnagregarcategoria);
            this.Controls.Add(this.datagridviewcategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCategoria";
            this.Text = "PCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridviewcategoria;
        private FontAwesome.Sharp.IconButton btnagregarcategoria;
        private TextBox txtbuscarcategoria;
    }
}