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
        Brush brush;
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
                //DrawLine(e.X, e.Y);
                brush.SetBitmap(q);
                brush.SetIsFirst(isFirst);
                brush.DrawLine(lastX,lastY,e.X, e.Y);
                q = brush.GetBitmap();
                pictureBox1.Image = q;
                isFirst = false;
                lastX = e.X;
                lastY = e.Y;
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
            brush = new Brush(pictureBox1.Width, pictureBox1.Height);
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
