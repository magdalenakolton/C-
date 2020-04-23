using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Black, 1);
        private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Orange, 1);
        private System.Drawing.Pen pen3 = new System.Drawing.Pen(Color.Red, 1);
        private System.Drawing.Pen pen4 = new System.Drawing.Pen(Color.Green, 1);
        private System.Drawing.Brush brush1 = new System.Drawing.SolidBrush(Color.Red);
        private System.Drawing.Brush brush2 = new System.Drawing.SolidBrush(Color.Blue);
        private System.Drawing.Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);

            int srodekX = pictureBox1.Width / 2, srodekY = pictureBox1.Height / 2, maxX = pictureBox1.Width, maxY =
                pictureBox1.Height;

            gr.DrawLine(pen1, 0, srodekY, maxX, srodekY);
            gr.DrawLine(pen1, srodekX, 0, srodekX, maxY);

            int x0 = pictureBox1.Width / 2,
                y0 = pictureBox1.Height / 2,
                r = (pictureBox1.Height / 2) - 150;

            int x2, y2;

            Point t = new Point();

            t.X = int.Parse(textBox1.Text);
            t.Y = int.Parse(textBox2.Text);


            Point[] punkty = new Point[300];
            Point[] punktyN = new Point[300];


            double alfa = 0;
            double dalfa = (2 * Math.PI) / 300;
            for (int i = 0; i < 300; i++)
            {
                double x = r * Math.Cos(alfa) + srodekX;
                double y = r * Math.Sin(alfa) + srodekY;
                x2 = (int)x + t.X;
                y2 = (int)y - t.Y;
                punkty[i] = new Point((int)x, (int)y);
                punktyN[i] = new Point((int)x2, ((int)y2));
                alfa += dalfa;
            }

            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300 - 1; j++)
                {
                    gr.DrawLine(pen3, punkty[i], punkty[j]);
                    gr.DrawLine(pen4, punktyN[i], punktyN[j]);
                }
            }

            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);

            int srodekX = pictureBox1.Width / 2, srodekY = pictureBox1.Height / 2, maxX = pictureBox1.Width, maxY = pictureBox1.Height;
            gr.DrawLine(pen1, 0, srodekY, maxX, srodekY);
            gr.DrawLine(pen1, srodekX, 0, srodekX, maxY);


            int bok = int.Parse(textBox1.Text);
            int teta = int.Parse(textBox2.Text);


            Point[] punkty = new Point[4];
            Point[] punktyN = new Point[4];
            Point[] punktyR = new Point[4];

            punkty[0] = new Point(-(bok / 2), (bok / 2));
            punkty[1] = new Point((bok / 2), (bok / 2));
            punkty[2] = new Point((bok / 2), -(bok / 2));
            punkty[3] = new Point(-(bok / 2), -(bok / 2));

            punktyR[0] = new Point(-(bok / 2) + srodekX, (bok / 2) + srodekY);
            punktyR[1] = new Point((bok / 2) + srodekX, (bok / 2) + srodekY);
            punktyR[2] = new Point((bok / 2) + srodekX, -(bok / 2) + srodekY);
            punktyR[3] = new Point(-(bok / 2) + srodekX, -(bok / 2) + srodekY);


            for (int i = 0; i < 4; i++)
            {
                int noweX = srodekX + (int)(punkty[i].X * Math.Cos(teta) + punkty[i].Y * Math.Sin(teta));
                int noweY = srodekY + (int)(-punkty[i].X * Math.Sin(teta) + punkty[i].Y * Math.Cos(teta));

                punktyN[i] = new Point(noweX, noweY);
            }

            gr.DrawLine(pen3, punktyR[0], punktyR[1]);
            gr.DrawLine(pen3, punktyR[1], punktyR[2]);
            gr.DrawLine(pen3, punktyR[2], punktyR[3]);
            gr.DrawLine(pen3, punktyR[3], punktyR[0]);


            gr.DrawLine(pen4, punktyN[0], punktyN[1]);
            gr.DrawLine(pen4, punktyN[1], punktyN[2]);
            gr.DrawLine(pen4, punktyN[2], punktyN[3]);
            gr.DrawLine(pen4, punktyN[3], punktyN[0]);

            pictureBox1.Image = bmp;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);

            int srodekX = pictureBox1.Width / 2, srodekY = pictureBox1.Height / 2, maxX = pictureBox1.Width, maxY =
                pictureBox1.Height;

            gr.DrawLine(pen1, 0, srodekY, maxX, srodekY);
            gr.DrawLine(pen1, srodekX, 0, srodekX, maxY);

            int x0 = pictureBox1.Width / 2,
                y0 = pictureBox1.Height / 2,
                r = (pictureBox1.Height / 2) - 150;
            double skalowanie = 0;

            int x2, y2;

            Point t = new Point();

            t.X = int.Parse(textBox1.Text);
            t.Y = int.Parse(textBox2.Text);
            skalowanie = double.Parse(textBox3.Text);


            Point[] punkty = new Point[300];
            Point[] punktyN = new Point[300];
            Point[] punktyS = new Point[300];


            double alfa = 0;
            double dalfa = (2 * Math.PI) / 300;
            for (int i = 0; i < 300; i++)
            {
                double x = r * Math.Cos(alfa) + srodekX;
                double y = r * Math.Sin(alfa) + srodekY;

                x2 = (int)(r * skalowanie * Math.Cos(alfa) + srodekX + t.X);
                y2 = (int)(r * skalowanie * Math.Sin(alfa) + srodekY - t.Y);

                punkty[i] = new Point((int)x, (int)y);
                punktyS[i] = new Point((int)x2, ((int)y2));
                alfa += dalfa;
            }



            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300 - 1; j++)
                {
                    gr.DrawLine(pen3, punkty[i], punkty[j]);
                    gr.DrawLine(pen4, punktyS[i], punktyS[j]);
                }
            }

            pictureBox1.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);

            int srodekX = pictureBox1.Width / 2, srodekY = pictureBox1.Height / 2, maxX = pictureBox1.Width, maxY = pictureBox1.Height;
            gr.DrawLine(pen1, 0, srodekY, maxX, srodekY);
            gr.DrawLine(pen1, srodekX, 0, srodekX, maxY);


            int bok = int.Parse(textBox1.Text);
            int teta = int.Parse(textBox2.Text);
            int tX = int.Parse(textBox3.Text);
            int tY = int.Parse(textBox4.Text);


            Point[] punkty = new Point[4];
            Point[] punktyN = new Point[4];
            Point[] punktyR = new Point[4];
            Point[] punkty2 = new Point[4];

            punkty[0] = new Point(-(bok / 2), (bok / 2));
            punkty[1] = new Point((bok / 2), (bok / 2));
            punkty[2] = new Point((bok / 2), -(bok / 2));
            punkty[3] = new Point(-(bok / 2), -(bok / 2));

            punktyR[0] = new Point(-(bok / 2) + srodekX, (bok / 2) + srodekY);
            punktyR[1] = new Point((bok / 2) + srodekX, (bok / 2) + srodekY);
            punktyR[2] = new Point((bok / 2) + srodekX, -(bok / 2) + srodekY);
            punktyR[3] = new Point(-(bok / 2) + srodekX, -(bok / 2) + srodekY);


            for (int i = 0; i < 4; i++)
            {
                int noweX = srodekX + (int)(punkty[i].X * Math.Cos(teta) + punkty[i].Y * Math.Sin(teta));
                int noweY = srodekY + (int)(-punkty[i].X * Math.Sin(teta) + punkty[i].Y * Math.Cos(teta));

                punktyN[i] = new Point(noweX, noweY);
            }

            for (int i = 0; i < 4; i++)
            {
                int noweX = srodekX + (int)(punkty[i].X * Math.Cos(teta) + punkty[i].Y * Math.Sin(teta) + tX);
                int noweY = srodekY + (int)(-punkty[i].X * Math.Sin(teta) + punkty[i].Y * Math.Cos(teta) - tY);

                punkty2[i] = new Point(noweX, noweY);
            }

            gr.DrawLine(pen3, punktyR[0], punktyR[1]);
            gr.DrawLine(pen3, punktyR[1], punktyR[2]);
            gr.DrawLine(pen3, punktyR[2], punktyR[3]);
            gr.DrawLine(pen3, punktyR[3], punktyR[0]);

            gr.DrawLine(pen3, punkty2[0], punkty2[1]);
            gr.DrawLine(pen3, punkty2[1], punkty2[2]);
            gr.DrawLine(pen3, punkty2[2], punkty2[3]);
            gr.DrawLine(pen3, punkty2[3], punkty2[0]);





            pictureBox1.Image = bmp;
        }
    }

}