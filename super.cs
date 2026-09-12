using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace super
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 447);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }

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
            ee.Clear(Color.FromArgb(255, 255, 255));
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
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


}
