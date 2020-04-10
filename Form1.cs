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
        public Form1()
        {
            InitializeComponent();
        }


        Bitmap q;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            q.SetPixel(e.X, e.Y, Color.Red);
            pictureBox1.Image = q;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            q = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            

        }
    }
}
