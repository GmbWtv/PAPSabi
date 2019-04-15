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
    public partial class DataOptions : Form
    {
        public DataOptions()
        {
            InitializeComponent();
        
            label11.Hide();
            label12.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
            label18.Hide();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel1.Location = new Point(88, 75);
            panel2.Location = new Point(472, 75);
            panel3.Location = new Point(857, 75);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;

            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            label11.Show();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            label11.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.fecharC;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.fecharSC;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.fecharC;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.fecharSC;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.fecharC;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.fecharSC;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            label12.Show();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            label12.Hide();
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            label15.Show();
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            label15.Hide();
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            label16.Show();
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            label16.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            label17.Show();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            label17.Hide();
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            label18.Show();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            label18.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form f5 = new Form5();
            f5.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form upload = new UploadSong();
            upload.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form play = new PlaySong();
            play.Show();
        }
    }
}

