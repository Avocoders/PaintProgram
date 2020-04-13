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
        Bitmap q;
        int n = 1;
        
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
            if ( e.X < 0 || e.X >pictureBox1.Width || e.Y  < 0 || e.Y > pictureBox1.Height)
            {
                isFirst = true;
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

        private void Pixel_1_CheckedChanged(object sender, EventArgs e)
        {
            n = 1;
        }

        private void Pixel_3_CheckedChanged(object sender, EventArgs e)
        {
            n = 2;
        }

        private void Pixel_5_CheckedChanged(object sender, EventArgs e)
        {
            n = 3;
        }

        private void DrawLine(int x, int y)
        {
            

            if (lastX == x && lastY == y||isFirst==true)
            {
                Pain(x, y, color);
                pictureBox1.Image = q;
                lastX = x;
                lastY = y;
            }

            while ((lastX != x || lastY != y) /*&& (radioButton1.Checked == false)*/)
            {
                if (lastX < x && lastY > y) //1   
                {
                    Pain(lastX + 1, lastY - 1, color);
                    
                    lastX = lastX + 1;
                    lastY = lastY - 1;
                }

                if (lastX > x && lastY < y)//2
                {
                    Pain(lastX - 1, lastY + 1, color);

                    lastX = lastX - 1;
                    lastY = lastY + 1;
                }

                if (lastX == x && lastY <= y) //3
                {
                    Pain(lastX, lastY + 1, color);

                    lastY = lastY + 1;

                }

                if (lastX < x && lastY == y) //4
                {
                    Pain(lastX + 1, lastY, color);

                    lastX = lastX + 1;
                }

                if (lastX > x && lastY > y) //5
                {
                    Pain(lastX - 1, lastY - 1, color);

                    lastX = lastX - 1;
                    lastY = lastY - 1;
                }

                if (lastX < x && lastY < y) //6
                {
                    Pain(lastX + 1, lastY + 1, color);

                    lastX = lastX + 1;
                    lastY = lastY + 1;
                }

                if (lastX == x && lastY > y) //7
                {
                    Pain(lastX, lastY - 1, color);

                    lastY = lastY - 1;
                }

                if (lastX > x && lastY == y) //8
                {
                    Pain(lastX - 1, lastY, color);

                    lastX = lastX - 1;
                }
            }
            lastX = x;
            lastY = y;

        }
        public Bitmap Pain(int x, int y, Color color)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x - i > 0 && x + i < pictureBox1.Width && y - j > 0 && y + j < pictureBox1.Height)
                    {
                        q.SetPixel(x - i, y - j, color);
                        q.SetPixel(x + i, y + j, color);
                    }
                        q.SetPixel(x, y, color);
                }
            }
            return q;
        }


    }
}
