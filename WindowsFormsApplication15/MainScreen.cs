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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            panel1.Location = new Point(-126, 82);
            pictureBox5.Location= new Point(72, 263);
            pictureBox4.Location = new Point(-54, 263);
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0);
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0);
            pictureBox12.Location = new Point(506, 98);
            
        }
        private bool mouseDown;
        private Point lastLocation;  
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
          
        }
        int r = 244;
        int g = 65;
        int b = 65;
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.black;
           
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.cor;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
             pictureBox3.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.fecharC;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.fecharSC;
         
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            pictureBox2.Image = global::WindowsFormsApplication15.Properties.Resources.animation;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = global::WindowsFormsApplication15.Properties.Resources.black;
            timer1.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            pictureBox4.Left += 6;
            panel1.Left += 6;
            if ( panel1.Left == 0)
            {
                timer2.Stop();
                pictureBox4.Hide();
                pictureBox5.Show();
            }
         
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.circuloazul;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.circuloaba;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox12.Hide();
            pictureBox5.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
         
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left -= 6;
            panel1.Left -= 6;
            if (panel1.Left==-126)
            {
                timer3.Stop();
                
            }
         
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer3.Start();
            pictureBox4.Show();
            pictureBox5.Hide();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.circuloazul;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = global::WindowsFormsApplication15.Properties.Resources.circuloaba;
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= 1;
                pictureBox6.BackColor = Color.FromArgb(r, g, b);
                pictureBox7.BackColor = Color.FromArgb(r, g, b);
                pictureBox8.BackColor = Color.FromArgb(r, g, b);
                pictureBox9.BackColor = Color.FromArgb(r, g, b);
                if (r <= 65)
                {
                    timerR.Stop();
                    timerG.Start();


                }
            }

            if (b <= 65)
            {

                if (r < 254)
                    r += 1;
                pictureBox6.BackColor = Color.FromArgb(r, g, b);
                pictureBox7.BackColor = Color.FromArgb(r, g, b);
                pictureBox8.BackColor = Color.FromArgb(r, g, b);
                pictureBox9.BackColor = Color.FromArgb(r, g, b);
                if (r >= 244)
                {
                    timerR.Stop();
                    timerG.Start();


                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += 1;
                pictureBox6.BackColor = Color.FromArgb(r, g, b);
                pictureBox7.BackColor = Color.FromArgb(r, g, b);
                pictureBox8.BackColor = Color.FromArgb(r, g, b);
                pictureBox9.BackColor = Color.FromArgb(r, g, b);
                if (g >= 244)
                {
                    timerG.Stop();
                    timerB.Start();


                }
            }

            if (r >= 244)
            {
                g -= 1;
                pictureBox6.BackColor = Color.FromArgb(r, g, b);
                pictureBox7.BackColor = Color.FromArgb(r, g, b);
                pictureBox8.BackColor = Color.FromArgb(r, g, b);
                pictureBox9.BackColor = Color.FromArgb(r, g, b);
                if (g <= 65)
                {
                    timerG.Stop();
                    timerB.Start();


                }
            }
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += 1;
                pictureBox6.BackColor = Color.FromArgb(r, g, b);
                pictureBox7.BackColor = Color.FromArgb(r, g, b);
                pictureBox8.BackColor = Color.FromArgb(r, g, b);
                pictureBox9.BackColor = Color.FromArgb(r, g, b);
                if (b >= 244)
                {
                    timerB.Stop();
                    timerR.Start();


                }
            }

            if (g >= 244)
            {
                b -= 1;
                pictureBox6.BackColor = Color.FromArgb(r, g, b);
                pictureBox7.BackColor = Color.FromArgb(r, g, b);
                pictureBox8.BackColor = Color.FromArgb(r, g, b);
                pictureBox9.BackColor = Color.FromArgb(r, g, b);
                if (b <= 65)
                {
                    timerB.Stop();
                    timerR.Start();


                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
          
            
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            label1.Show();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            label2.Show();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

            timer4.Start();

            timer5.Start();

            timer6.Start();

            timer7.Start();

            timer8.Start();

            timer9.Start();

            timer10.Start();

            timer11.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox15.Show();
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox13.Show();
            timer5.Stop();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox14.Show();
            timer6.Stop();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox17.Show();
            timer7.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox19.Show();
            timer8.Stop();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox18.Show();
            timer9.Stop();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox20.Show();
            timer10.Stop();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            pictureBox16.Show();
            timer11.Stop();
         
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form f3=new DataOptions();
            f3.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form f6 = new Collections();
            f6.Show();

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.BackColor = Color.FromArgb(200, 232, 255);
            pictureBox12.BackgroundImage = Properties.Resources.chill;
            pictureBox12.Show();
            pictureBox16.BringToFront();
            pictureBox15.BringToFront();
            pictureBox13.BringToFront();
            pictureBox14.BringToFront();
            pictureBox17.BringToFront();
            pictureBox19.BringToFront();
            pictureBox18.BringToFront();
            pictureBox20.BringToFront();
        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.FromArgb(200, 232, 255);
            pictureBox12.BackgroundImage = Properties.Resources.roadtrip;
            pictureBox12.Show();
            pictureBox16.BringToFront();
            pictureBox15.BringToFront();
            pictureBox13.BringToFront();
            pictureBox14.BringToFront();
            pictureBox17.BringToFront();
            pictureBox19.BringToFront();
            pictureBox18.BringToFront();
            pictureBox20.BringToFront();

        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.FromArgb(200, 232, 255);
            pictureBox12.BackgroundImage = Properties.Resources.rock;
            pictureBox12.Show();
            pictureBox16.BringToFront();
            pictureBox15.BringToFront();
            pictureBox13.BringToFront();
            pictureBox14.BringToFront();
            pictureBox17.BringToFront();
            pictureBox19.BringToFront();
            pictureBox18.BringToFront();
            pictureBox20.BringToFront();
           
           
        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.BackColor = Color.FromArgb(200, 232, 255);
            pictureBox12.BackgroundImage = Properties.Resources.electronic;
            pictureBox12.Show();
            pictureBox16.BringToFront();
            pictureBox15.BringToFront();
            pictureBox13.BringToFront();
            pictureBox14.BringToFront();
            pictureBox17.BringToFront();
            pictureBox19.BringToFront();
            pictureBox18.BringToFront();
            pictureBox20.BringToFront();
          
          
        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.FromArgb(200, 232, 255);
            pictureBox12.BackgroundImage = Properties.Resources.acoustic;
            pictureBox12.Show();
            pictureBox16.BringToFront();
            pictureBox15.BringToFront();
            pictureBox13.BringToFront();
            pictureBox14.BringToFront();
            pictureBox17.BringToFront();
            pictureBox19.BringToFront();
            pictureBox18.BringToFront();
            pictureBox20.BringToFront();
          
        }

        private void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.FromArgb(200, 232, 255);
            pictureBox12.BackgroundImage = Properties.Resources.jazz;
            pictureBox12.Show();
            pictureBox16.BringToFront();
            pictureBox15.BringToFront();
            pictureBox13.BringToFront();
            pictureBox14.BringToFront();
            pictureBox17.BringToFront();
            pictureBox19.BringToFront();
            pictureBox18.BringToFront();
            pictureBox20.BringToFront();
       
        }

        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.FromArgb(200, 232, 255);
            pictureBox12.BackgroundImage = Properties.Resources.classical;
            pictureBox12.Show();
            pictureBox16.BringToFront();
            pictureBox15.BringToFront();
            pictureBox13.BringToFront();
            pictureBox14.BringToFront();
            pictureBox17.BringToFront();
            pictureBox19.BringToFront();
            pictureBox18.BringToFront();
            pictureBox20.BringToFront();
           
        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            pictureBox20.BackColor = Color.FromArgb(200, 232, 255);
            pictureBox12.BackgroundImage = Properties.Resources.studywork;
            pictureBox12.Show();
            pictureBox16.BringToFront();
            pictureBox15.BringToFront();
            pictureBox13.BringToFront();
            pictureBox14.BringToFront();
            pictureBox17.BringToFront();
            pictureBox19.BringToFront();
            pictureBox18.BringToFront();
            pictureBox20.BringToFront();
          
          
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.BackgroundImage = Properties.Resources.icons8_speaker_96;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.BackgroundImage = Properties.Resources.icons8_speaker_96;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.BackgroundImage = Properties.Resources.icons8_speaker_96;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.icons8_speaker_96;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.BackgroundImage = Properties.Resources.icons8_speaker_96;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.FromArgb(208, 250, 255); 
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.FromArgb(208, 250, 255); 
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.BackColor = Color.FromArgb(208, 250, 255); 
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.FromArgb(208, 250, 255); 
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.FromArgb(208, 250, 255); 
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.FromArgb(208, 250, 255); 
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.BackColor = Color.FromArgb(208, 250, 255); 
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.BackColor = Color.FromArgb(208, 250, 255);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.BackgroundImage = Properties.Resources.icons8_speaker_96;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.BackgroundImage = Properties.Resources.icons8_speaker_96;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.BackgroundImage = Properties.Resources.icons8_speaker_96;
        }
    }
}
