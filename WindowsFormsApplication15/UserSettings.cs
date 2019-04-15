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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            this.Opacity = 0;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);
            label7.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            label9.Hide();
            label10.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
        }

        /*protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Brush brushImege;
            System.Drawing.Drawing2D.GraphicsPath caminho = null;
            try
            {
                Bitmap Imagem = new Bitmap(this.Image);
                Imagem = new Bitmap(Imagem, new Size(this.Width - 1, this.Height - 1));
                brushImege = new TextureBrush(Imagem);
            }
            catch
            {
                Bitmap Imagem = new Bitmap(this.Width - 1, this.Height - 1, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                using (Graphics grp = Graphics.FromImage(Imagem))
                {
                    grp.FillRectangle(
                        Brushes.White, 0, 0, this.Width - 1, this.Height - 1);
                    Imagem = new Bitmap(this.Width - 1, this.Height - 1, grp);
                }
                brushImege = new TextureBrush(Imagem);
            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            caminho.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.FillPath(brushImege, caminho);
            e.Graphics.DrawPath(Pens.Black, caminho);
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;

            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.LimeGreen;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.White;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.icons8_change_theme_48;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.icons8_change_theme_48__1_;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label7.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label7.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
           
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Tomato;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.LimeGreen;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.White;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label9.Show();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label9.Hide();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label10.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label10.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
