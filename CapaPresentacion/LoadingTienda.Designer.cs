namespace CapaPresentacion
{
    partial class LoadingTienda
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
            this.pictureBoxloading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloading)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxloading
            // 
            this.pictureBoxloading.Image = global::CapaPresentacion.Properties.Resources.loading;
            this.pictureBoxloading.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxloading.Name = "pictureBoxloading";
            this.pictureBoxloading.Size = new System.Drawing.Size(532, 395);
            this.pictureBoxloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxloading.TabIndex = 0;
            this.pictureBoxloading.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 394);
            this.Controls.Add(this.pictureBoxloading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.Opacity = 0.7D;
            this.Text = "Loading";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxloading;
    }
}