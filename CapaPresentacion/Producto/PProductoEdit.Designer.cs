namespace CapaPresentacion.Producto
{
    partial class PProductoEdit
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
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnameeditproduct = new System.Windows.Forms.TextBox();
            this.txtdescripcioneditproduct = new System.Windows.Forms.TextBox();
            this.checkBoxpreciokiloeditproduct = new System.Windows.Forms.CheckBox();
            this.pictureBoximgeditproduct = new System.Windows.Forms.PictureBox();
            this.btnselectimgproductedit = new System.Windows.Forms.Button();
            this.btnguardaeditproduct = new System.Windows.Forms.Button();
            this.btncanceleditproduct = new System.Windows.Forms.Button();
            this.errormsmedit = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxcategoriaedit = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximgeditproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormsmedit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modificar Producto";
            // 
            // btnclose
            // 
            this.btnclose.Image = global::CapaPresentacion.Properties.Resources.cerraricon;
            this.btnclose.Location = new System.Drawing.Point(516, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(23, 24);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 1;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // txtnameeditproduct
            // 
            this.txtnameeditproduct.Location = new System.Drawing.Point(93, 64);
            this.txtnameeditproduct.Name = "txtnameeditproduct";
            this.txtnameeditproduct.Size = new System.Drawing.Size(289, 23);
            this.txtnameeditproduct.TabIndex = 3;
            // 
            // txtdescripcioneditproduct
            // 
            this.txtdescripcioneditproduct.Location = new System.Drawing.Point(92, 105);
            this.txtdescripcioneditproduct.Multiline = true;
            this.txtdescripcioneditproduct.Name = "txtdescripcioneditproduct";
            this.txtdescripcioneditproduct.Size = new System.Drawing.Size(290, 93);
            this.txtdescripcioneditproduct.TabIndex = 4;
            // 
            // checkBoxpreciokiloeditproduct
            // 
            this.checkBoxpreciokiloeditproduct.AutoSize = true;
            this.checkBoxpreciokiloeditproduct.Location = new System.Drawing.Point(17, 216);
            this.checkBoxpreciokiloeditproduct.Name = "checkBoxpreciokiloeditproduct";
            this.checkBoxpreciokiloeditproduct.Size = new System.Drawing.Size(103, 19);
            this.checkBoxpreciokiloeditproduct.TabIndex = 5;
            this.checkBoxpreciokiloeditproduct.Text = "Precio por Kilo";
            this.checkBoxpreciokiloeditproduct.UseVisualStyleBackColor = true;
            // 
            // pictureBoximgeditproduct
            // 
            this.pictureBoximgeditproduct.Location = new System.Drawing.Point(393, 64);
            this.pictureBoximgeditproduct.Name = "pictureBoximgeditproduct";
            this.pictureBoximgeditproduct.Size = new System.Drawing.Size(125, 134);
            this.pictureBoximgeditproduct.TabIndex = 6;
            this.pictureBoximgeditproduct.TabStop = false;
            // 
            // btnselectimgproductedit
            // 
            this.btnselectimgproductedit.Location = new System.Drawing.Point(17, 282);
            this.btnselectimgproductedit.Name = "btnselectimgproductedit";
            this.btnselectimgproductedit.Size = new System.Drawing.Size(365, 23);
            this.btnselectimgproductedit.TabIndex = 7;
            this.btnselectimgproductedit.Text = "Seleccionar Imagen";
            this.btnselectimgproductedit.UseVisualStyleBackColor = true;
            this.btnselectimgproductedit.Click += new System.EventHandler(this.btnselectimgproductedit_Click);
            // 
            // btnguardaeditproduct
            // 
            this.btnguardaeditproduct.Location = new System.Drawing.Point(17, 311);
            this.btnguardaeditproduct.Name = "btnguardaeditproduct";
            this.btnguardaeditproduct.Size = new System.Drawing.Size(365, 23);
            this.btnguardaeditproduct.TabIndex = 8;
            this.btnguardaeditproduct.Text = "Guardar";
            this.btnguardaeditproduct.UseVisualStyleBackColor = true;
            this.btnguardaeditproduct.Click += new System.EventHandler(this.btnguardaeditproduct_Click);
            // 
            // btncanceleditproduct
            // 
            this.btncanceleditproduct.Location = new System.Drawing.Point(17, 340);
            this.btncanceleditproduct.Name = "btncanceleditproduct";
            this.btncanceleditproduct.Size = new System.Drawing.Size(365, 23);
            this.btncanceleditproduct.TabIndex = 9;
            this.btncanceleditproduct.Text = "Cancelar";
            this.btncanceleditproduct.UseVisualStyleBackColor = true;
            this.btncanceleditproduct.Click += new System.EventHandler(this.btncanceleditproduct_Click);
            // 
            // errormsmedit
            // 
            this.errormsmedit.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categoria";
            // 
            // comboBoxcategoriaedit
            // 
            this.comboBoxcategoriaedit.FormattingEnabled = true;
            this.comboBoxcategoriaedit.Location = new System.Drawing.Point(90, 242);
            this.comboBoxcategoriaedit.Name = "comboBoxcategoriaedit";
            this.comboBoxcategoriaedit.Size = new System.Drawing.Size(292, 23);
            this.comboBoxcategoriaedit.TabIndex = 11;
            // 
            // PProductoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 388);
            this.Controls.Add(this.comboBoxcategoriaedit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncanceleditproduct);
            this.Controls.Add(this.btnguardaeditproduct);
            this.Controls.Add(this.btnselectimgproductedit);
            this.Controls.Add(this.pictureBoximgeditproduct);
            this.Controls.Add(this.checkBoxpreciokiloeditproduct);
            this.Controls.Add(this.txtdescripcioneditproduct);
            this.Controls.Add(this.txtnameeditproduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PProductoEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PProductoEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximgeditproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormsmedit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnclose;
        private Label label2;
        private Label label3;
        private TextBox txtnameeditproduct;
        private TextBox txtdescripcioneditproduct;
        private CheckBox checkBoxpreciokiloeditproduct;
        private PictureBox pictureBoximgeditproduct;
        private Button btnselectimgproductedit;
        private Button btnguardaeditproduct;
        private Button btncanceleditproduct;
        private ErrorProvider errormsmedit;
        private Label label4;
        private ComboBox comboBoxcategoriaedit;
    }
}