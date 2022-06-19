namespace CapaPresentacion.Cliente
{
    partial class PPClienteNew
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnselectimg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlasname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddres = new System.Windows.Forms.TextBox();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.pictureBoximgclient = new System.Windows.Forms.PictureBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.errormsmclientnew = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxcolonias = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximgclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormsmclientnew)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 33);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cerraricon;
            this.pictureBox1.Location = new System.Drawing.Point(508, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // btnselectimg
            // 
            this.btnselectimg.Location = new System.Drawing.Point(16, 179);
            this.btnselectimg.Name = "btnselectimg";
            this.btnselectimg.Size = new System.Drawing.Size(350, 25);
            this.btnselectimg.TabIndex = 4;
            this.btnselectimg.Text = "Seleccionar Imagen";
            this.btnselectimg.UseVisualStyleBackColor = true;
            this.btnselectimg.Click += new System.EventHandler(this.btnselectimg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "CP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Colonia";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(84, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(282, 23);
            this.txtname.TabIndex = 8;
            // 
            // txtlasname
            // 
            this.txtlasname.Location = new System.Drawing.Point(84, 100);
            this.txtlasname.Name = "txtlasname";
            this.txtlasname.Size = new System.Drawing.Size(282, 23);
            this.txtlasname.TabIndex = 9;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(84, 145);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(282, 23);
            this.txtphone.TabIndex = 10;
            // 
            // txtaddres
            // 
            this.txtaddres.Location = new System.Drawing.Point(84, 216);
            this.txtaddres.Name = "txtaddres";
            this.txtaddres.Size = new System.Drawing.Size(282, 23);
            this.txtaddres.TabIndex = 11;
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(84, 255);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(282, 23);
            this.txtcp.TabIndex = 12;
            this.txtcp.TextChanged += new System.EventHandler(this.txtcp_TextChanged);
            // 
            // pictureBoximgclient
            // 
            this.pictureBoximgclient.Location = new System.Drawing.Point(383, 60);
            this.pictureBoximgclient.Name = "pictureBoximgclient";
            this.pictureBoximgclient.Size = new System.Drawing.Size(123, 136);
            this.pictureBoximgclient.TabIndex = 14;
            this.pictureBoximgclient.TabStop = false;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(20, 337);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(346, 37);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(20, 376);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(346, 37);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // errormsmclientnew
            // 
            this.errormsmclientnew.ContainerControl = this;
            // 
            // comboBoxcolonias
            // 
            this.comboBoxcolonias.FormattingEnabled = true;
            this.comboBoxcolonias.Location = new System.Drawing.Point(84, 287);
            this.comboBoxcolonias.Name = "comboBoxcolonias";
            this.comboBoxcolonias.Size = new System.Drawing.Size(282, 23);
            this.comboBoxcolonias.TabIndex = 17;
            // 
            // PPClienteNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 424);
            this.Controls.Add(this.comboBoxcolonias);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.pictureBoximgclient);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.txtaddres);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtlasname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnselectimg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PPClienteNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPClienteEdit";
            this.Load += new System.EventHandler(this.PPClienteNew_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximgclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormsmclientnew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnselectimg;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtname;
        private TextBox txtlasname;
        private TextBox txtphone;
        private TextBox txtaddres;
        private TextBox txtcp;
        private PictureBox pictureBoximgclient;
        private Button btnguardar;
        private Button btncancelar;
        private ErrorProvider errormsmclientnew;
        private ComboBox comboBoxcolonias;
    }
}