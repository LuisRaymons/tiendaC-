namespace CapaPresentacion.Compra
{
    partial class PCompraEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txteditcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtedittotal = new System.Windows.Forms.TextBox();
            this.selecteditproduct = new System.Windows.Forms.ComboBox();
            this.selecteditpromotor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxeditimg = new System.Windows.Forms.PictureBox();
            this.errorProvidermsm = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxeditimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermsm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editar Compra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cerraricon;
            this.pictureBox1.Location = new System.Drawing.Point(510, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // txteditcantidad
            // 
            this.txteditcantidad.Location = new System.Drawing.Point(99, 69);
            this.txteditcantidad.Name = "txteditcantidad";
            this.txteditcantidad.Size = new System.Drawing.Size(275, 23);
            this.txteditcantidad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Promotor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio Total";
            // 
            // txtedittotal
            // 
            this.txtedittotal.Location = new System.Drawing.Point(98, 175);
            this.txtedittotal.Name = "txtedittotal";
            this.txtedittotal.Size = new System.Drawing.Size(275, 23);
            this.txtedittotal.TabIndex = 8;
            // 
            // selecteditproduct
            // 
            this.selecteditproduct.FormattingEnabled = true;
            this.selecteditproduct.Location = new System.Drawing.Point(99, 108);
            this.selecteditproduct.Name = "selecteditproduct";
            this.selecteditproduct.Size = new System.Drawing.Size(274, 23);
            this.selecteditproduct.TabIndex = 9;
            // 
            // selecteditpromotor
            // 
            this.selecteditpromotor.FormattingEnabled = true;
            this.selecteditpromotor.Location = new System.Drawing.Point(98, 144);
            this.selecteditpromotor.Name = "selecteditpromotor";
            this.selecteditpromotor.Size = new System.Drawing.Size(276, 23);
            this.selecteditpromotor.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Seleccione una imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(353, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(352, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxeditimg
            // 
            this.pictureBoxeditimg.Location = new System.Drawing.Point(391, 69);
            this.pictureBoxeditimg.Name = "pictureBoxeditimg";
            this.pictureBoxeditimg.Size = new System.Drawing.Size(127, 124);
            this.pictureBoxeditimg.TabIndex = 14;
            this.pictureBoxeditimg.TabStop = false;
            // 
            // errorProvidermsm
            // 
            this.errorProvidermsm.ContainerControl = this;
            // 
            // PCompraEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 310);
            this.Controls.Add(this.pictureBoxeditimg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selecteditpromotor);
            this.Controls.Add(this.selecteditproduct);
            this.Controls.Add(this.txtedittotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txteditcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCompraEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCompraEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxeditimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermsm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txteditcantidad;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtedittotal;
        private ComboBox selecteditproduct;
        private ComboBox selecteditpromotor;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBoxeditimg;
        private ErrorProvider errorProvidermsm;
    }
}