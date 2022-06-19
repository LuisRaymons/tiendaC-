namespace CapaPresentacion.Categoria
{
    partial class PCategoriaEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txteditcategoria = new System.Windows.Forms.TextBox();
            this.btnguardaeditcategoria = new System.Windows.Forms.Button();
            this.btncancelaredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txteditcategoria
            // 
            this.txteditcategoria.Location = new System.Drawing.Point(58, 27);
            this.txteditcategoria.Name = "txteditcategoria";
            this.txteditcategoria.Size = new System.Drawing.Size(257, 23);
            this.txteditcategoria.TabIndex = 1;
            // 
            // btnguardaeditcategoria
            // 
            this.btnguardaeditcategoria.Location = new System.Drawing.Point(18, 75);
            this.btnguardaeditcategoria.Name = "btnguardaeditcategoria";
            this.btnguardaeditcategoria.Size = new System.Drawing.Size(297, 23);
            this.btnguardaeditcategoria.TabIndex = 2;
            this.btnguardaeditcategoria.Text = "Guardar";
            this.btnguardaeditcategoria.UseVisualStyleBackColor = true;
            this.btnguardaeditcategoria.Click += new System.EventHandler(this.btnguardaeditcategoria_Click);
            // 
            // btncancelaredit
            // 
            this.btncancelaredit.Location = new System.Drawing.Point(18, 104);
            this.btncancelaredit.Name = "btncancelaredit";
            this.btncancelaredit.Size = new System.Drawing.Size(297, 23);
            this.btncancelaredit.TabIndex = 3;
            this.btncancelaredit.Text = "Cancelar";
            this.btncancelaredit.UseVisualStyleBackColor = true;
            this.btncancelaredit.Click += new System.EventHandler(this.btncancelaredit_Click);
            // 
            // PCategoriaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 135);
            this.Controls.Add(this.btncancelaredit);
            this.Controls.Add(this.btnguardaeditcategoria);
            this.Controls.Add(this.txteditcategoria);
            this.Controls.Add(this.label1);
            this.Name = "PCategoriaEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnguardaeditcategoria;
        public TextBox txteditcategoria;
        private Button btncancelaredit;
    }
}