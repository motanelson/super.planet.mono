using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace super
{
    public partial class Form1 : Form
    {
        private Image i; Bitmap b; int value = 0; int value2 = 0; int xx = 0; int yy = 0; Graphics ee; int xxx = 0; int yyy = 0; int xxxx = 10;int xxx1 = 0;int xxxx1=10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            int v = value & 1;

            ee = Graphics.FromImage(b);
            Pen a = new Pen(Color.FromArgb(0, 0, 0));
            Pen c = new Pen(Color.FromArgb(255, 255, 255));
            SolidBrush rBrush = new SolidBrush(Color.FromArgb(60, 60, 60));
            SolidBrush rrBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
            SolidBrush raBrush = new SolidBrush(Color.FromArgb(100, 100, 100));
            Rectangle f = new Rectangle(pictureBox1.Width / 2 - 150, pictureBox1.Height / 2 - 150, 300, 300);
            Rectangle f1 = new Rectangle(xxx - 25, yyy - 25, 50, 50);
            Rectangle f2 = new Rectangle(xxx - 10+xxx1, yyy - 10, 20, 20);
            ee.Clear(Color.FromArgb(0, 0, 255));
            if (xxxx > 0)
            {

                if (xxxx1 > 0)
                {
                    ee.FillEllipse(rBrush, f);
                    ee.FillEllipse(rrBrush, f1);
                    ee.FillEllipse(raBrush, f2);


                }
                else
                {

                    ee.FillEllipse(rBrush, f);
                    ee.FillEllipse(raBrush, f2);
                    ee.FillEllipse(rrBrush, f1);


                }
            }
            else
            {
                if (xxxx1 > 0)
                { 
                    ee.FillEllipse(rrBrush, f1);
                    ee.FillEllipse(raBrush, f2);
                    ee.FillEllipse(rBrush, f);
                } else
                {
                    ee.FillEllipse(raBrush, f2);
                    ee.FillEllipse(rrBrush, f1);
                    
                    ee.FillEllipse(rBrush, f);
                }


            }
            a.Dispose();
            c.Dispose();
            ee.Dispose();
            rBrush.Dispose();
            rrBrush.Dispose();
            raBrush.Dispose();
            pictureBox1.Refresh();
            xxx = xxx + xxxx;
            xxx1 = xxx1 + xxxx1;
            if (xxx > 480 || xxx < 100) xxxx = -xxxx;
            if (xxx1 > 29 || xxx1 < -29) xxxx1 = -xxxx1;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            xxx = pictureBox1.Width / 2;
            yyy = pictureBox1.Height / 2;
        }
    }


}
