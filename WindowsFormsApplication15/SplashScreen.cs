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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TransparencyKey = Color.FromArgb(42, 42, 42);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form f2=new MainScreen();
            f2.Show();
            timer1.Stop();
        }
    }
}
