using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WindowsFormsApp7.Figure;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Bitmap q,bitmap2;
        int n = 1;

        Color color;
        Brush brush;
        Holst holst;
        bool isDrow, isFirst;
        int lastX, lastY;
        int startX = 0;
        int startY = 0;
        IFigur Figure;
        int tmp = 0;
        Bitmap bitmap3;
        RectangleF cloneRect;
        System.Drawing.Imaging.PixelFormat format;



        public Form1()
        {
            InitializeComponent();
        }
        public Color GetColor()
        {
            return color;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tmp == 0)
            {
                if (isDrow == true && e.X > 0 && e.X < pictureBox1.Width && e.Y > 0 && e.Y < pictureBox1.Height)
                {

                    brush.SetBitmap(q);
                    brush.SetIsFirst(isFirst);
                    brush.DrawLine(lastX, lastY, e.X, e.Y);
                    q = brush.GetBitmap();
                    pictureBox1.Image = q;
                    isFirst = false;
                    lastX = e.X;
                    lastY = e.Y;
                    //Figure.Drow(startX, startY, e.X, e.Y);

                }
                if (e.X < 0 || e.X > pictureBox1.Width || e.Y < 0 || e.Y > pictureBox1.Height)
                {
                    isFirst = true;
                }
            }
            else 
            {
                if (isDrow == true && e.X > 0 && e.X < pictureBox1.Width && e.Y > 0 && e.Y < pictureBox1.Height)
                {

                    
                    bitmap2 = bitmap3.Clone(cloneRect, format);
                    brush.SetBitmap(bitmap2);
                     Figure.Drow(startX, startY, e.X, e.Y);
                     q = brush.GetBitmap();
                    
                    pictureBox1.Image = q;
                    

                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
            isDrow = true;
            isFirst = true;
            startX = e.X;
            startY = e.Y;
            
            bitmap3 = new Bitmap(pictureBox1.Image);
            cloneRect = new RectangleF(0, 0, pictureBox1.Width, pictureBox1.Height);
            format = bitmap3.PixelFormat;
            bitmap2 = bitmap3.Clone(cloneRect, format);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            isDrow = false;
            isFirst = false;
            color = Color.Black;
            q = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            brush = new Brush(pictureBox1.Width, pictureBox1.Height);
            holst = new Holst(q,brush);
            pictureBox1.Image = q;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrow = false;

        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonBlue_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Blue;
            brush.SetColor(color);
        }

        private void buttonBlack_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Black; brush.SetColor(color);
        }

        private void buttonRed_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Red; brush.SetColor(color);
        }

        private void buttonOrange_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Orange; brush.SetColor(color);
        }

        private void buttonWhite_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.White; brush.SetColor(color);
        }

        private void buttonGrey_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Gray; brush.SetColor(color);
        }

        private void buttonGreen_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Green; brush.SetColor(color);
        }

        private void buttonPurple_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Purple; brush.SetColor(color);
        }

        private void buttonYellow_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Yellow; brush.SetColor(color);
        }

        private void Pixel_1_CheckedChanged(object sender, EventArgs e)
        {
            n = 1;
            brush.ChangePaint(1);
        }

        private void square_Click(object sender, EventArgs e)
        {
            tmp = 1;
            Figure = new Square(brush);
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            tmp = 2;
            Figure = new Rectangl(brush);
        }

        private void RightTriangle_Click(object sender, EventArgs e)
        {
            tmp = 3;
            Figure = new RightTriangle(brush);
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            tmp = 4;
            Figure = new IsoscelesTriangle(brush);
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            q = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = q;
        }

        private void deleteTheLastOne_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = bitmap3;
            q = bitmap3;
        }

        private void chooseEraser_Click(object sender, EventArgs e)
        {
            tmp = 0;
            brush.SetColor(Color.White);
        }

        private void Pixel_3_CheckedChanged(object sender, EventArgs e)
        {
            n = 2;
            brush.ChangePaint(2);
        }

        private void Pixel_5_CheckedChanged(object sender, EventArgs e)
        {
            n = 3;
            brush.ChangePaint(3);
        }




    }
}

