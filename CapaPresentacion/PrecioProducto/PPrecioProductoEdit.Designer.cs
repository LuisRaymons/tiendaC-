namespace CapaPresentacion.PrecioProducto
{
    partial class PPrecioProductoEdit
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecioedit = new System.Windows.Forms.TextBox();
            this.btnguardaredit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtproductedit = new System.Windows.Forms.TextBox();
            this.errorProvidermsmedit = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermsmedit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 35);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modificar Precio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cerraricon;
            this.pictureBox1.Location = new System.Drawing.Point(342, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // txtprecioedit
            // 
            this.txtprecioedit.Location = new System.Drawing.Point(71, 102);
            this.txtprecioedit.Name = "txtprecioedit";
            this.txtprecioedit.Size = new System.Drawing.Size(276, 23);
            this.txtprecioedit.TabIndex = 4;
            // 
            // btnguardaredit
            // 
            this.btnguardaredit.Location = new System.Drawing.Point(9, 143);
            this.btnguardaredit.Name = "btnguardaredit";
            this.btnguardaredit.Size = new System.Drawing.Size(338, 25);
            this.btnguardaredit.TabIndex = 5;
            this.btnguardaredit.Text = "Guardar";
            this.btnguardaredit.UseVisualStyleBackColor = true;
            this.btnguardaredit.Click += new System.EventHandler(this.btnguardaredit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtproductedit
            // 
            this.txtproductedit.Location = new System.Drawing.Point(75, 60);
            this.txtproductedit.Name = "txtproductedit";
            this.txtproductedit.Size = new System.Drawing.Size(272, 23);
            this.txtproductedit.TabIndex = 7;
            // 
            // errorProvidermsmedit
            // 
            this.errorProvidermsmedit.ContainerControl = this;
            // 
            // PPrecioProductoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 218);
            this.Controls.Add(this.txtproductedit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnguardaredit);
            this.Controls.Add(this.txtprecioedit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PPrecioProductoEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPrecioProductoEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidermsmedit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtprecioedit;
        private Button btnguardaredit;
        private Button button2;
        private Label label3;
        private TextBox txtproductedit;
        private ErrorProvider errorProvidermsmedit;
    }
}