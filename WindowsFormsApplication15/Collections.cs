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
    public partial class Collections : Form
    {
        public Collections()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;

            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
