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
using System.Drawing.Imaging;
using WindowsFormsApp7.Fill;
using WindowsFormsApp7.DrawerFabric;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Point moveStart;
        AbstractFabric abstractFabric;
        Drower drower;
        SingleBitmap q = SingleBitmap.Create();        
        int n = 1;
        int xnow, ynow;
        Color color;
        bool firstColor = true;        
        Brush brush;        
        bool isDrow, isFirst,isFirstPoligon,isCollapsed;
        bool expend = false;
        bool noexpend = true;
        int lastX, lastY;
        int startX = 0;
        int startY = 0;
        IFigur Figure;
        IFill Fill;
        int tmp = 0;
        bool Eraser = false;
        SaveFileDialog save = new SaveFileDialog();
        OpenFileDialog open = new OpenFileDialog();
        int nAngle=5;
        Point first, last;
        public Form1()
        {
            InitializeComponent();

            lineThickness.Minimum = 1;
            lineThickness.Maximum = 10;

            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;            
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = color;
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

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nAngle = Convert.ToInt32(textBox3.Text);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {   
            if ((e.Button & MouseButtons.Left) != 0)
            { 
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);  
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonRollUp_Click(object sender, EventArgs e)
        {            if (isCollapsed != true)
            {
                isCollapsed = true;
                this.WindowState = FormWindowState.Minimized;
            }            
        }
        private void buttonExpend_Click(object sender, EventArgs e)
        {                        if (expend == false)
            {
                this.WindowState = FormWindowState.Maximized;
                expend = true;
                noexpend = false;
               
            }
            else if (noexpend == false)
            {
                this.WindowState = FormWindowState.Normal;
                noexpend = true;
                expend = false;
            }
        }

        public Color GetColor()
        {
            return color;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (tmp == 0)
            //{
            //if (isDrow == true && e.X > 0 && e.X < pictureBox1.Width && e.Y > 0 && e.Y < pictureBox1.Height)
            //{
                     
            //        brush.DrawLine(lastX, lastY, e.X, e.Y);                    
            //        pictureBox1.Image = q.bitmap;
                    
            //        lastX = e.X;
            //        lastY = e.Y;
            // }
            if (e.X < 0 || e.X > pictureBox1.Width || e.Y < 0 || e.Y > pictureBox1.Height)
            {
                isFirst = true;
            }

            //else if (tmp !=10 && tmp != 11)            
            //{               
            if (isDrow == true && e.X > 0 && e.X < pictureBox1.Width && e.Y > 0 && e.Y < pictureBox1.Height)
                {
                brush.SetIsFirst(isFirst);
                isFirst = false;

                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    if (Figure is Ellipse)
                    {
                        Figure = new Сircle(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                    if (Figure is Rectangl)
                    {
                        Figure = new Square(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                    if (Figure is IsoscelesTriangle)
                    {
                        Figure = new RightTriangle(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                }
                if ((Control.ModifierKeys & Keys.Shift) != Keys.Shift)
                {
                    if (Figure is Ellipse)
                    {
                        Figure = new Ellipse(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                    if (Figure is Rectangl)
                    {
                        Figure = new Rectangl(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                    if (Figure is IsoscelesTriangle)
                    {
                        Figure = new IsoscelesTriangle(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                    if (Figure is Square)
                    {
                        Figure = new Square(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                    if( Figure is RightTriangle )
                    {
                        Figure = new RightTriangle(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                    if (Figure is Poligon)
                    {
                        Figure = new Poligon(brush);
                        drower = abstractFabric.CreateDrower(Figure, brush, Fill);
                    }
                }
                last = e.Location;

                if (!(drower is ClassLine))
                { q.DrawFigure(); } 
                    drower.Draw(first, last,nAngle);
                
                if (drower is ClassLine)
                    { first = last; }
                    
                    //Figure.Drow(startX, startY, e.X, e.Y, nAngle);
                    pictureBox1.Image = q.bitmap;
                }
           // }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drower = abstractFabric.CreateDrower(Figure, brush, Fill);
            first = e.Location;
            
            if (firstColor == true)
            {
                if (e.Button == MouseButtons.Left)
                {                    
                    if (tmp == 10)
                    {
                        button1.BackColor = q.bitmap.GetPixel(e.X, e.Y);
                        color = button1.BackColor;
                        brush.SetColor(color);
                    }
                    else
                    {
                        if (Eraser == true)
                        {
                            brush.SetColor(Color.White);
                            brush.SetDot(e.X, e.Y);
                            pictureBox1.Image = q.bitmap;
                        }
                        else
                        {
                            brush.SetColor(button1.BackColor);
                        }                        
                    }                    
                }
                else if (e.Button == MouseButtons.Right)
                {
                    brush.SetColor(button4.BackColor);
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    
                    if (tmp == 10)
                    {
                        button4.BackColor = q.bitmap.GetPixel(e.X, e.Y);
                        color = button4.BackColor;
                        brush.SetColor(color);
                    }
                    else
                    {
                        if (Eraser == true)
                        {
                            brush.SetColor(Color.White);
                            brush.SetDot(e.X, e.Y);
                            pictureBox1.Image = q.bitmap;
                        }
                        else
                        {
                            brush.SetColor(button4.BackColor);
                        }                        
                    }                    
                }
                else if (e.Button == MouseButtons.Right)
                {
                    brush.SetColor(button1.BackColor);
                }
            }
            
            isDrow = true;
            isFirst = true;

            //if (tmp != 10)
            //{
                q.Clone2();
            //}

            //if (tmp == 0)
            //{                
            //    brush.SetDot(e.X, e.Y);
            //    pictureBox1.Image = q.bitmap;
            //}

            //if (tmp != 11)
            //{               
            //    lastX = e.X;
            //    lastY = e.Y;
            //    startX = e.X;            //    startY = e.Y;
            //}
            
            //if(tmp==11)
            //{
            //    if (isFirstPoligon == true)
            //    {                    
            //        startX = e.X;
            //        startY = e.Y;
            //        lastX = startX;
            //        lastY = startY;
            //        brush.SetDot(startX, startY);
            //        isFirstPoligon = false;
                    pictureBox1.Image = q.bitmap;
            //    }                
            //    else 
            //    {
            //        xnow = e.X;
            //        ynow = e.Y;
            //        brush.DrawLine(lastX, lastY, xnow, ynow);                    
            //        lastX = e.X;
            //        lastY = e.Y;
            //        pictureBox1.Image = q.bitmap;
            //    }
            //}
            if (tmp == 13)
            {
                SolidFill cast = new SolidFill(color);
                cast.Casting(e.X, e.Y);
                pictureBox1.Image = q.bitmap;
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {            
            isDrow = false;
            isFirst = false;
            isFirstPoligon = false;
            color = Color.Black;
            q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            q.CreateBitmapList();
            brush = new Brush(pictureBox1.Width, pictureBox1.Height);            
            pictureBox1.Image = q.bitmap;
            isCollapsed = false;
            abstractFabric = new LineFabric();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrow = false;
            if (tmp != 11)
            { q.Clone(); }
        }        

        private void lineThickness_Scroll(object sender, EventArgs e)
        {
            switch (lineThickness.Value)
            {
                case 1: n = 1; break;
                case 2: n = 2; break;
                case 3: n = 4; break;
                case 4: n = 6; break;
                case 5: n = 8; break;
                case 6: n = 10; break;
                case 7: n = 12; break;
                case 8: n = 14; break;
                case 9: n = 16; break;
                case 10: n = 18; break;
            }
            brush.ChangePaint(n);
        }

        private void buttonBlue_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Blue;              
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }               

        private void buttonBlack_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Black; 
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }

        private void buttonRed_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Red;
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }

        private void buttonOrange_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Orange;
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }

        private void buttonWhite_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.White;
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }

        private void buttonGrey_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Gray;
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }

        private void buttonGreen_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Green; 
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }

        private void buttonPurple_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Purple; 
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }

        private void buttonYellow_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Yellow; 
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new Square(brush);
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new Rectangl(brush);
        }

        private void RightTriangle_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new RightTriangle(brush);
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new IsoscelesTriangle(brush);
        }
        private void straightLine_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new StraightLine(brush);
        }
        private void choosePen_Click(object sender, EventArgs e)
        {
            abstractFabric = new LineFabric();
            Eraser = false;
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (tmp == 11)
            {
                brush.DrawLine(startX, startY, lastX, lastY);
                pictureBox1.Image = q.bitmap;
                isFirstPoligon = true;
                q.Clone();
            }
        }
        private void moreColor_Click(object sender, EventArgs e)
        {            colorDialog1.AllowFullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { color = colorDialog1.Color; }
            // установка цвета формы
            
            if (firstColor == true)
            {
                button1.BackColor = color;
            }
            else
            {
                button4.BackColor = color;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new Poligon(brush);            
        }

        private void textBox3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nAngle = Convert.ToInt32(textBox3.Text);
                textBox3.Text = "";
            }
        }

        private void oval_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new Ellipse(brush);
        }

        private void circle_Click(object sender, EventArgs e)
        {
            Figure = new Сircle(brush);
            abstractFabric = new FigureFabric();
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && isCollapsed!=true)
            {
                q.bitmap = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);                
                pictureBox1.Image = q.bitmap;
                brush.SetSize(pictureBox1.Width, pictureBox1.Height);                
            }
            isCollapsed = false;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            q.Redo();
            pictureBox1.Image = q.tmp1;           
        }

        private void chooseFill_Click(object sender, EventArgs e)
        {
            tmp = 13;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (q.bitmap != null)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {                    
                    q.bitmap.Save(save.FileName);
                }
            }            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                q.bitmap = new Bitmap(open.FileName);
                pictureBox1.Image = q.bitmap;
                q.CreateBitmapList();
                isDrow = false;
                isFirst = false;
                isFirstPoligon = false;
                color = Color.Black;                
                brush = new Brush(pictureBox1.Width, pictureBox1.Height);               
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            firstColor = true;
            this.button1.BringToFront();
            color = button1.BackColor;           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstColor = false;
            this.button4.BringToFront();
            color = button4.BackColor;            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (firstColor == true)
            {
                firstColor = false;
                this.button4.BringToFront();
                color = button4.BackColor;
                brush.SetColor(button4.BackColor);
            }
            else
            {
                firstColor = true;
                this.button1.BringToFront();
                color = button1.BackColor;
                brush.SetColor(button1.BackColor);
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
            q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = q.bitmap;
            q.CreateBitmapList();            
        }

        private void deleteTheLastOne_Click(object sender, EventArgs e)
        {
            q.Undo();            
            pictureBox1.Image = q.tmp1;            
        }

        private void chooseEraser_Click(object sender, EventArgs e)
        {
            abstractFabric =new LineFabric();
            //brush.SetColor(Color.White);
            Eraser = true;
        }                
    }
}

