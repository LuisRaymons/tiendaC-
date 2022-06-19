namespace CapaPresentacion.Usuario
{
    partial class PUsuarioEdit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnameedit = new System.Windows.Forms.TextBox();
            this.txtemailedit = new System.Windows.Forms.TextBox();
            this.checkBoxcangepassword = new System.Windows.Forms.CheckBox();
            this.labelpassuser = new System.Windows.Forms.Label();
            this.txteditpassword = new System.Windows.Forms.TextBox();
            this.labelconfirmpassuser = new System.Windows.Forms.Label();
            this.txteditconfirpassword = new System.Windows.Forms.TextBox();
            this.btnselectimgedit = new System.Windows.Forms.Button();
            this.comboBoxedittypeuser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnguardaredit = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBoxedituser = new System.Windows.Forms.PictureBox();
            this.errormsmedituser = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxedituser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormsmedituser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cerraricon;
            this.pictureBox1.Location = new System.Drawing.Point(630, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // txtnameedit
            // 
            this.txtnameedit.Location = new System.Drawing.Point(124, 69);
            this.txtnameedit.Name = "txtnameedit";
            this.txtnameedit.Size = new System.Drawing.Size(301, 23);
            this.txtnameedit.TabIndex = 3;
            // 
            // txtemailedit
            // 
            this.txtemailedit.Enabled = false;
            this.txtemailedit.Location = new System.Drawing.Point(124, 117);
            this.txtemailedit.Name = "txtemailedit";
            this.txtemailedit.Size = new System.Drawing.Size(301, 23);
            this.txtemailedit.TabIndex = 4;
            // 
            // checkBoxcangepassword
            // 
            this.checkBoxcangepassword.AutoSize = true;
            this.checkBoxcangepassword.Location = new System.Drawing.Point(32, 171);
            this.checkBoxcangepassword.Name = "checkBoxcangepassword";
            this.checkBoxcangepassword.Size = new System.Drawing.Size(134, 19);
            this.checkBoxcangepassword.TabIndex = 5;
            this.checkBoxcangepassword.Text = "Cambiar Contraseña";
            this.checkBoxcangepassword.UseVisualStyleBackColor = true;
            this.checkBoxcangepassword.CheckedChanged += new System.EventHandler(this.checkBoxcangepassword_CheckedChanged);
            // 
            // labelpassuser
            // 
            this.labelpassuser.AutoSize = true;
            this.labelpassuser.Location = new System.Drawing.Point(28, 229);
            this.labelpassuser.Name = "labelpassuser";
            this.labelpassuser.Size = new System.Drawing.Size(67, 15);
            this.labelpassuser.TabIndex = 6;
            this.labelpassuser.Text = "Contraseña";
            // 
            // txteditpassword
            // 
            this.txteditpassword.Location = new System.Drawing.Point(124, 221);
            this.txteditpassword.Name = "txteditpassword";
            this.txteditpassword.Size = new System.Drawing.Size(301, 23);
            this.txteditpassword.TabIndex = 7;
            this.txteditpassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelconfirmpassuser
            // 
            this.labelconfirmpassuser.AutoSize = true;
            this.labelconfirmpassuser.Location = new System.Drawing.Point(28, 277);
            this.labelconfirmpassuser.Name = "labelconfirmpassuser";
            this.labelconfirmpassuser.Size = new System.Drawing.Size(81, 15);
            this.labelconfirmpassuser.TabIndex = 8;
            this.labelconfirmpassuser.Text = "C. Contraseña";
            // 
            // txteditconfirpassword
            // 
            this.txteditconfirpassword.Location = new System.Drawing.Point(124, 269);
            this.txteditconfirpassword.Name = "txteditconfirpassword";
            this.txteditconfirpassword.Size = new System.Drawing.Size(301, 23);
            this.txteditconfirpassword.TabIndex = 9;
            // 
            // btnselectimgedit
            // 
            this.btnselectimgedit.Location = new System.Drawing.Point(32, 339);
            this.btnselectimgedit.Name = "btnselectimgedit";
            this.btnselectimgedit.Size = new System.Drawing.Size(393, 23);
            this.btnselectimgedit.TabIndex = 10;
            this.btnselectimgedit.Text = "Seleccionar imagen";
            this.btnselectimgedit.UseVisualStyleBackColor = true;
            this.btnselectimgedit.Click += new System.EventHandler(this.btnselectimgedit_Click);
            // 
            // comboBoxedittypeuser
            // 
            this.comboBoxedittypeuser.FormattingEnabled = true;
            this.comboBoxedittypeuser.Items.AddRange(new object[] {
            "Administrador",
            "Ventas",
            "Almacen"});
            this.comboBoxedittypeuser.Location = new System.Drawing.Point(134, 394);
            this.comboBoxedittypeuser.Name = "comboBoxedittypeuser";
            this.comboBoxedittypeuser.Size = new System.Drawing.Size(291, 23);
            this.comboBoxedittypeuser.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de usuario";
            // 
            // btnguardaredit
            // 
            this.btnguardaredit.Location = new System.Drawing.Point(32, 445);
            this.btnguardaredit.Name = "btnguardaredit";
            this.btnguardaredit.Size = new System.Drawing.Size(393, 23);
            this.btnguardaredit.TabIndex = 13;
            this.btnguardaredit.Text = "Guardar";
            this.btnguardaredit.UseVisualStyleBackColor = true;
            this.btnguardaredit.Click += new System.EventHandler(this.btnguardaredit_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(32, 474);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(393, 23);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBoxedituser
            // 
            this.pictureBoxedituser.Location = new System.Drawing.Point(469, 69);
            this.pictureBoxedituser.Name = "pictureBoxedituser";
            this.pictureBoxedituser.Size = new System.Drawing.Size(157, 151);
            this.pictureBoxedituser.TabIndex = 15;
            this.pictureBoxedituser.TabStop = false;
            // 
            // errormsmedituser
            // 
            this.errormsmedituser.ContainerControl = this;
            // 
            // PUsuarioEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 505);
            this.Controls.Add(this.pictureBoxedituser);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardaredit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxedittypeuser);
            this.Controls.Add(this.btnselectimgedit);
            this.Controls.Add(this.txteditconfirpassword);
            this.Controls.Add(this.labelconfirmpassuser);
            this.Controls.Add(this.txteditpassword);
            this.Controls.Add(this.labelpassuser);
            this.Controls.Add(this.checkBoxcangepassword);
            this.Controls.Add(this.txtemailedit);
            this.Controls.Add(this.txtnameedit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PUsuarioEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUsuarioEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxedituser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormsmedituser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnameedit;
        private TextBox txtemailedit;
        private CheckBox checkBoxcangepassword;
        private Label labelpassuser;
        private TextBox txteditpassword;
        private Label labelconfirmpassuser;
        private TextBox txteditconfirpassword;
        private Button btnselectimgedit;
        private ComboBox comboBoxedittypeuser;
        private Label label6;
        private Button btnguardaredit;
        private Button btncancelar;
        private PictureBox pictureBoxedituser;
        private ErrorProvider errormsmedituser;
    }
}