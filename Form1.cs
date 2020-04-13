﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Interface;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {   
        Bitmap q;
        IFigure figure;
         Color color;
        bool isDrow,isFirst;
        int lastX, lastY;
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
            if (isDrow == true && e.X > 0 && e.X < pictureBox1.Width && e.Y > 0 && e.Y < pictureBox1.Height)
            {
                DrawLine(e.X, e.Y);
                pictureBox1.Image = q;
                isFirst = false;
                
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
            isDrow = true;
            isFirst = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //figure = new Line(pictureBox1.Width, pictureBox1.Height);
            isDrow = false;
            isFirst = false;
            color = Color.Black;
            q = new Bitmap(pictureBox1.Width, pictureBox1.Height);
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
        }

        private void buttonBlack_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void buttonRed_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void buttonOrange_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Orange;
        }

        private void buttonWhite_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.White;
        }

        private void buttonGrey_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Gray;
        }

        private void buttonGreen_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void buttonPurple_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Purple;
        }

        private void buttonYellow_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }
        private void DrawLine(int x, int y)
        {
            if ((lastX == x && lastY == y) || (lastX == 0 && lastY == 0) || (isFirst == true))
            { lastY = y; lastX = x; q.SetPixel(x, y, color); }
            if (lastX != x && lastY == y)
            {
                double k = (y - lastY) / (x - lastX);
                double b = lastY - k * lastX;
                for (int i = lastX; i < x; i++)
                {
                    q.SetPixel(i, y, color);

                }
                for (int i = lastX; i > x; i--)
                {
                    q.SetPixel(i, y, color);

                }
                lastX = x;
                lastY = y;
            }
            if (lastY != y && lastX == x)
            {

                for (int i = lastY; i < y; i++)
                {
                    q.SetPixel(x, i, color);
                }
                for (int i = lastY; i > y; i--)
                {
                    q.SetPixel(x, i, color);
                }

                lastX = x;
                lastY = y;
            }
            if ((lastX != x && lastY != y) && (lastX != 0 && lastY != 0))
            {
                double dal = Math.Sqrt(Math.Pow(lastX - x, 2) + Math.Pow(lastY - y, 2));
                //double dal = (y - lastY) / (x - lastX);
                double xd = (x - lastX) / (dal / 1.5);
                double yd = (y - lastY) / (dal / 1.5);
                while (lastY != y && lastX != x)
                {
                    q.SetPixel(lastX, lastY, color);
                    
                    lastY = lastY + System.Convert.ToInt32(yd);
                    lastX = lastX + System.Convert.ToInt32(xd);
                }




            }
            
        }
    }
}
