using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class LoadingTienda : Form
    {
        public LoadingTienda()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            this.pictureBoxloading.Load("loading.gif");
            //this.pictureBoxloading.Load("question.jpg");
            this.pictureBoxloading.Location = new Point(this.Width/2 - this.pictureBoxloading.Width/2,
                                                        this.Height / 2 - this.pictureBoxloading.Height / 2);
        }
    }
}
