namespace CapaPresentacion.Producto
{
    partial class PProductoNew
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
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxpreciokilo = new System.Windows.Forms.CheckBox();
            this.btnselectimg = new System.Windows.Forms.Button();
            this.selectcategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnewnameproducto = new System.Windows.Forms.TextBox();
            this.txtnewdescripcion = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBoxproductnew = new System.Windows.Forms.PictureBox();
            this.errormsmnewproduct = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormsmnewproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Image = global::CapaPresentacion.Properties.Resources.cerraricon;
            this.btncerrar.Location = new System.Drawing.Point(564, -2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(22, 27);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 32);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // checkBoxpreciokilo
            // 
            this.checkBoxpreciokilo.AutoSize = true;
            this.checkBoxpreciokilo.Location = new System.Drawing.Point(12, 227);
            this.checkBoxpreciokilo.Name = "checkBoxpreciokilo";
            this.checkBoxpreciokilo.Size = new System.Drawing.Size(103, 19);
            this.checkBoxpreciokilo.TabIndex = 4;
            this.checkBoxpreciokilo.Text = "Precio por Kilo";
            this.checkBoxpreciokilo.UseVisualStyleBackColor = true;
            // 
            // btnselectimg
            // 
            this.btnselectimg.Location = new System.Drawing.Point(12, 268);
            this.btnselectimg.Name = "btnselectimg";
            this.btnselectimg.Size = new System.Drawing.Size(403, 23);
            this.btnselectimg.TabIndex = 5;
            this.btnselectimg.Text = "Selecciona Imagen";
            this.btnselectimg.UseVisualStyleBackColor = true;
            this.btnselectimg.Click += new System.EventHandler(this.btnselectimg_Click);
            // 
            // selectcategoria
            // 
            this.selectcategoria.FormattingEnabled = true;
            this.selectcategoria.Location = new System.Drawing.Point(91, 303);
            this.selectcategoria.Name = "selectcategoria";
            this.selectcategoria.Size = new System.Drawing.Size(318, 23);
            this.selectcategoria.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria";
            // 
            // txtnewnameproducto
            // 
            this.txtnewnameproducto.Location = new System.Drawing.Point(97, 68);
            this.txtnewnameproducto.Name = "txtnewnameproducto";
            this.txtnewnameproducto.Size = new System.Drawing.Size(318, 23);
            this.txtnewnameproducto.TabIndex = 9;
            // 
            // txtnewdescripcion
            // 
            this.txtnewdescripcion.Location = new System.Drawing.Point(96, 116);
            this.txtnewdescripcion.Multiline = true;
            this.txtnewdescripcion.Name = "txtnewdescripcion";
            this.txtnewdescripcion.Size = new System.Drawing.Size(319, 94);
            this.txtnewdescripcion.TabIndex = 10;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(12, 348);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(397, 23);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(10, 377);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(399, 23);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBoxproductnew
            // 
            this.pictureBoxproductnew.Location = new System.Drawing.Point(434, 68);
            this.pictureBoxproductnew.Name = "pictureBoxproductnew";
            this.pictureBoxproductnew.Size = new System.Drawing.Size(141, 142);
            this.pictureBoxproductnew.TabIndex = 13;
            this.pictureBoxproductnew.TabStop = false;
            // 
            // errormsmnewproduct
            // 
            this.errormsmnewproduct.ContainerControl = this;
            // 
            // PProductoNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 415);
            this.Controls.Add(this.pictureBoxproductnew);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtnewdescripcion);
            this.Controls.Add(this.txtnewnameproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectcategoria);
            this.Controls.Add(this.btnselectimg);
            this.Controls.Add(this.checkBoxpreciokilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PProductoNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PProductoNew";
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormsmnewproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btncerrar;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxpreciokilo;
        private Button btnselectimg;
        private ComboBox selectcategoria;
        private Label label5;
        private TextBox txtnewnameproducto;
        private TextBox txtnewdescripcion;
        private Button btnguardar;
        private Button btncancelar;
        private PictureBox pictureBoxproductnew;
        private ErrorProvider errormsmnewproduct;
    }
}