using System;
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
        public  Color color = Color.Black;
        bool isDrow;
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
            if (isDrow == true)
            {
                q = figure.DrawFigure(e.X, e.Y, color);
                pictureBox1.Image = q;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrow = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            figure = new Line(pictureBox1.Width, pictureBox1.Height);
            isDrow = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrow = false;
        }
    }
}
