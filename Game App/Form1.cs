using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_App
{
    public partial class Form1 : Form
    {

        enum Dir { Left, Right, None }

        
        int speed = 10;
        int score = 0;
        Dir dir = Dir.None;
        Random rndom = new Random();

        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;
            pictureBox5.Top += speed;
            pictureBox6.Top += speed;
            pictureBox8.Top += speed;
            pictureBox9.Top += speed;
            pictureBox10.Top += speed;

            pictureBox11.Top += speed;
            pictureBox12.Top += speed;
            pictureBox13.Top += speed;
            pictureBox14.Top += speed;

            pictureBox15.Top += speed;
            pictureBox16.Top += speed;
            pictureBox17.Top += speed;


            if (pictureBox1.Top > panel1.Height) pictureBox1.Top = -pictureBox1.Height;
            if (pictureBox2.Top > panel1.Height) pictureBox2.Top = -pictureBox2.Height;
            if (pictureBox3.Top > panel1.Height) pictureBox3.Top = -pictureBox3.Height;
            if (pictureBox4.Top > panel1.Height) pictureBox4.Top = -pictureBox4.Height;
            if (pictureBox5.Top > panel1.Height) pictureBox5.Top = -pictureBox5.Height;
            if (pictureBox6.Top > panel1.Height) pictureBox6.Top = -pictureBox6.Height;
            if (pictureBox8.Top > panel1.Height) pictureBox8.Top = -pictureBox8.Height;
            if (pictureBox9.Top > panel1.Height) pictureBox9.Top = -pictureBox9.Height;
            if (pictureBox10.Top > panel1.Height) pictureBox10.Top = -pictureBox10.Height;

            if (pictureBox11.Top > panel1.Height) pictureBox11.Top = -pictureBox11.Height;
            if (pictureBox12.Top > panel1.Height) pictureBox12.Top = -pictureBox12.Height;
            if (pictureBox13.Top > panel1.Height) pictureBox13.Top = -pictureBox13.Height;
            if (pictureBox14.Top > panel1.Height) pictureBox14.Top = -pictureBox14.Height;

            if (pictureBox15.Top > panel1.Height) pictureBox15.Top = -pictureBox15.Height;
            if (pictureBox16.Top > panel1.Height) pictureBox16.Top = -pictureBox16.Height;
            if (pictureBox17.Top > panel1.Height) pictureBox17.Top = -pictureBox17.Height;


            if (dir == Dir.Left && pictureBox7.Left>0)
            {
                pictureBox7.Left -= speed;
            }
            if (dir == Dir.Right && pictureBox7.Left< panel1.Width-pictureBox7.Width)
            {
                pictureBox7.Left += speed;
            }


            if (pictureBox15.Visible)
            {
                pictureBox15.Top += speed;
            }
            if (pictureBox15.Top>panel1.Height)
            {
                pictureBox15.Visible = false;
                pictureBox15.Top = -pictureBox15.Height;
                pictureBox15.Left = rndom.Next((panel1.Width - pictureBox15.Width)/3);
                pictureBox15.Visible = true;
            }

            if (pictureBox16.Visible)
            {
                pictureBox16.Top += speed;
            }
            if (pictureBox16.Top > panel1.Height)
            {
                pictureBox16.Visible = false;
                pictureBox16.Top = -pictureBox16.Height;
                pictureBox16.Left = rndom.Next(panel1.Width /2 , panel1.Width-pictureBox16.Width);
                pictureBox16.Visible = true;
            }


            if (pictureBox17.Visible)
            {
                pictureBox17.Top += speed;
            }
            if (pictureBox17.Top > panel1.Height)
            {
                pictureBox17.Visible = false;
                pictureBox17.Top = -pictureBox17.Height;
                pictureBox17.Left = rndom.Next(panel1.Width - pictureBox17.Width);
                pictureBox17.Visible = true;
            }
            if (pictureBox7.Bounds.IntersectsWith(pictureBox15.Bounds) || pictureBox7.Bounds.IntersectsWith(pictureBox16.Bounds) || pictureBox7.Bounds.IntersectsWith(pictureBox17.Bounds))
            {
                timer1.Enabled = false;
                label2.Visible = true;
                label3.Visible = true;
            }

            score++;

            if (score > 1000) { speed = 15; };
            if (score > 2000) { speed = 25; };
            if (score > 3000) { speed = 35; };
            if (score > 4000) { speed = 50; };



            label1.Text = "Score : " + score;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                dir = Dir.Left;
            }
            else if (e.KeyData == Keys.Right)
            {
                dir = Dir.Right;
            }
            else dir = Dir.None;

            if (label2.Visible)
            {
                if (e.KeyData == Keys.Space)
                {
                    label2.Visible = false;
                    label3.Visible = false;
                    timer1.Enabled = true;
                    pictureBox7.Left = panel1.Width / 2;
                    pictureBox15.Left = 0;
                    pictureBox16.Left = panel1.Width - pictureBox16.Width;
                    pictureBox17.Left = panel1.Width - pictureBox17.Width;
                    speed = 10;
                    score = 0;


                }
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            dir = Dir.None;
        }
    }
}
