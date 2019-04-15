using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class UploadSong : Form
    {
        public UploadSong()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void UploadSong_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;

            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
