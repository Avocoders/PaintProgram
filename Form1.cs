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
        Point moveStart;
        Bitmap q,bitmap2;
        int n = 1;
        int xnow, ynow;
        Color color;
        Brush brush;        
        bool isDrow, isFirst,isFirstPoligon;
        int lastX, lastY;
        int startX = 0;
        int startY = 0;
        IFigur Figure;
        int tmp = 0;
        Bitmap bitmap3,bitmap4;
        RectangleF cloneRect;
        System.Drawing.Imaging.PixelFormat format;

        public Form1()
        {
            InitializeComponent();
            lineThickness.Minimum = 1;
            lineThickness.Maximum = 6;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            moreColor.Click += moreColor_Click;
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_SIZEBOX = 0x40000;
                var cp = base.CreateParams;
                cp.Style |= WS_SIZEBOX;
                return cp;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {            
            if ((e.Button & MouseButtons.Left) != 0)
            {                
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);                
                this.Location = new Point(this.Location.X + deltaPos.X,
                this.Location.Y + deltaPos.Y);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExpend_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
            else if (tmp!=10&&tmp!=11)
            
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
           
            isDrow = true;
            isFirst = true;
            
            if (tmp != 11)
            {
                bitmap2 = CreateNewLayer();
             lastX = e.X;
            lastY = e.Y;
                startX = e.X;
            startY = e.Y;
                brush.SetBitmap(bitmap2);
            }
            if(tmp==0)
            {
                brush.SetDot(e.X,e.Y);
                q = brush.GetBitmap();
                pictureBox1.Image = q;
            }
            if (tmp==10)
            {
                
                brush.SetColor(q.GetPixel(e.X, e.Y));
            }
            if(tmp==11)
            {
                if (isFirstPoligon == true)
                {
                    q = CreateNewLayer();
                    brush.SetBitmap(q);
                    startX = e.X;
                    startY = e.Y;
                    lastX = startX;
                    lastY = startY;
                    brush.SetDot(startX, startY);
                    isFirstPoligon = false;
                    q = brush.GetBitmap();
                    pictureBox1.Image = q;
                }
                else 
                {
                    xnow = e.X;
                    ynow = e.Y;
                    brush.DrawLine(lastX, lastY, xnow, ynow);
                    q = brush.GetBitmap();
                    lastX = e.X;
                    lastY = e.Y;
                    pictureBox1.Image = q;
                }

            }
        }
        private Bitmap CreateNewLayer()
        {
            bitmap3 = new Bitmap(pictureBox1.Image);
            bitmap4 = new Bitmap(pictureBox1.Image);
            cloneRect = new RectangleF(0, 0, pictureBox1.Width, pictureBox1.Height);
            format = bitmap3.PixelFormat;
            //bitmap2 = bitmap3.Clone(cloneRect, format);
            return bitmap3.Clone(cloneRect, format);
        }
        private void DrowIrregularPolygon(int x,int y)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            isDrow = false;
            isFirst = false;
            isFirstPoligon = false;
            color = Color.Black;
            q = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            brush = new Brush(pictureBox1.Width, pictureBox1.Height);            
            pictureBox1.Image = q;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrow = false;
        }        

        private void lineThickness_Scroll(object sender, EventArgs e)
        {
            switch(lineThickness.Value)
            {
                case 1: n = 1; break;
                case 2: n = 2; break;
                case 3: n = 3; break;
                case 4: n = 4; break;
                case 5: n = 5; break;
                case 6: n = 6; break;
            }
            brush.ChangePaint(n);
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

        private void straightLine_Click(object sender, EventArgs e)
        {
            tmp = 12;
            Figure = new StraightLine(brush);
        }

        private void choosePen_Click(object sender, EventArgs e)
        {
            tmp = 0;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            if (tmp == 11)
            {
                brush.DrawLine(startX, startY, lastX, lastY);
                q = brush.GetBitmap();
                pictureBox1.Image = q;
                isFirstPoligon = true;
            }
        }

        private void moreColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            this.BackColor = colorDialog1.Color;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(tmp==11)
            {
                brush.DrawLine(startX, startY, lastX, lastY);
                q = brush.GetBitmap();
                pictureBox1.Image = q;
                isFirstPoligon = true;
            }
        }

        private void choosePipette_Click(object sender, EventArgs e)
        {
            tmp = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmp = 11;
            isFirstPoligon = true;
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            q = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = q;
        }

        private void deleteTheLastOne_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = bitmap4;
            //q = bitmap3;
        }

        private void chooseEraser_Click(object sender, EventArgs e)
        {
            tmp = 0;
            brush.SetColor(Color.White);
        }
    }
}

