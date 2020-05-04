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
using WindowsFormsApp7.MovingChange;


namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {        
        AbstractFabric abstractFabric;
        Drower drower;
        SingleBitmap q = SingleBitmap.Create();
        IFigur Figure;
        CreatedFigure currentFigur;        
        CreatedFigure cf;
        Brush brush;
        SaveFileDialog save = new SaveFileDialog();
        OpenFileDialog open = new OpenFileDialog();
        IMovingChange moving;
        IFill Fill;
        Color color;        
        Point moveStart;
        Point first, last;
        int n = 1;
        int nAngle = 5;
        bool drowing = true;
        bool isHanded = false;
        bool isTop = false;
        bool isZoom = false;
        bool isTurn = false;
        bool isFigureChanged = false;
        bool isColorChanged = false;
        bool isThicknessChange = false;
        bool isGran = false;         
        bool firstColor = true;                 
        bool isDrow, isFirst, isFirstPoligon, isCollapsed;
        bool expend = false;
        bool noexpend = true;         
        bool fill = false;
        bool Eraser = false;
        bool Pipetka = false;         
        int tmpIndex;
       
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
        }        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && isCollapsed != true)
            {
                q.ChangeSize(pictureBox1.Width, pictureBox1.Height);
                q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = q.bitmap;
                brush = new Brush(brush);
                brush.SetSize(pictureBox1.Width, pictureBox1.Height);
            }
            isCollapsed = false;
        }
        private void buttonExpend_Click(object sender, EventArgs e)
        {
            if (expend == false)
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox7.Image = Image.FromFile("D:/ckr.gif");
            if (q.bitmap != null)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    q.bitmap.Save(save.FileName);
                }
            }
            pictureBox7.Visible = false;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox8.Image = Image.FromFile("D:/1f.gif");
            if (open.ShowDialog() == DialogResult.OK)
            {
                q.bitmap = new Bitmap(open.FileName);                
            }
            pictureBox1.Image = q.bitmap;
            q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            q.CreateBitmapList();
            isDrow = false;
            isFirst = false;
            isFirstPoligon = false;
            Eraser = false;
            Pipetka = false;
            textBox3.Visible = false;
            fill = false;             
            isTop = false;
            isHanded = false;
            isZoom = false;
            isTurn = false;
            isFigureChanged = false;
            drowing = true;
            isColorChanged = false;
            isGran = false;
            isThicknessChange = false;            
            toolStripDropDownButton2.Image = topToolStripMenuItem.Image;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
            isCollapsed = false;
            q.heigth = pictureBox1.Height;
            q.width = pictureBox1.Width;
            pictureBox8.Visible = false;
        }

        public Color GetColor()
        {
            return color;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 0 || e.X > pictureBox1.Width || e.Y < 0 || e.Y > pictureBox1.Height)
            {
                isFirst = true;
            }
            if (isDrow == true && e.X > 0 && e.X < pictureBox1.Width && e.Y > 0 && e.Y < pictureBox1.Height)
            {
                if (drowing == true)
                {
                    brush.SetIsFirst(isFirst);
                    isFirst = false;
                    if (!(abstractFabric is UncommonPoligon))
                    {
                        q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                        {
                            if (Figure is Ellipse)
                            {
                                cf.figur=new Сircle();

                                drower = abstractFabric.CreateDrower(cf.figur, cf.brush, cf.fill);
                                isFigureChanged = true;
                            }
                            else if (Figure is Rectangl)
                            {
                                cf.figur = new Square();
                                drower = abstractFabric.CreateDrower(cf.figur, cf.brush, cf.fill);
                                isFigureChanged = true;
                            }
                            else if (Figure is IsoscelesTriangle)
                            {
                                cf.figur = new RightTriangle();
                                drower = abstractFabric.CreateDrower(cf.figur, cf.brush, cf.fill);
                                isFigureChanged = true;
                            }                           
                        }
                        else if ((Control.ModifierKeys & Keys.Shift) != Keys.Shift)
                        {
                            if (Figure is Ellipse && isFigureChanged == true)
                            {
                                cf.figur = new Ellipse();
                                drower = abstractFabric.CreateDrower(cf.figur, cf.brush, cf.fill);
                                isFigureChanged = false;
                            }
                            else if (Figure is Rectangl && isFigureChanged == true)
                            {
                                cf.figur = new Rectangl();
                                drower = abstractFabric.CreateDrower(cf.figur, cf.brush, cf.fill);
                                isFigureChanged = false;
                            }
                            else if (Figure is IsoscelesTriangle&& isFigureChanged == true)
                            {
                                cf.figur = new IsoscelesTriangle();
                                drower = abstractFabric.CreateDrower(cf.figur, cf.brush, cf.fill);
                                isFigureChanged = false;
                            }                            
                        }
                        last = e.Location;
                        drower.Draw(first, last, nAngle,cf);
                        if (!(drower is ClassLine))
                        { q.DrawFigure(); }
                        else if (drower is ClassLine)
                        { 
                            q.DrawLine();
                            first = last;
                        }
                        pictureBox1.Image = q.bitmap;
                    }
                }
                else if ((isHanded == true || isGran == true)&& currentFigur != null)
                {                   
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);                    
                    moving.ChangeFigure(e.Location);
                    q.Move();
                    q.DrowOnlyOneFigure(currentFigur);                    
                    pictureBox1.Image = q.bitmap;                    
                }
                else if (isZoom == true && currentFigur != null)
                {                    
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height); 
                    if (currentFigur.figur is Сircle)
                    {                        
                        drower.Draw(currentFigur.centr, e.Location, nAngle,currentFigur);
                    }
                    else if (currentFigur.figur is Ellipse)
                    {
                        Point po = new Point(currentFigur.l.X + (e.X - first.X), currentFigur.l.Y + (e.Y - first.Y));
                        drower.Draw(currentFigur.f, po, nAngle, currentFigur);
                        first = e.Location;
                    }
                    else
                    {
                        moving.ChangeFigure(e.Location);
                    }
                    q.DrawFigure();
                    q.DrowOnlyOneFigure(currentFigur);                    
                    pictureBox1.Image = q.bitmap;
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);                 
                }

                else if (isTurn == true && currentFigur != null)
                {
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    moving.ChangeFigure(e.Location);
                    q.Move();
                    q.DrowOnlyOneFigure(currentFigur);
                    pictureBox1.Image = q.bitmap;                    
                }

                else if (isTop == true && currentFigur != null)
                {                   
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    currentFigur.poin[tmpIndex] = e.Location;
                    q.DrowOnlyOneFigure(currentFigur);
                    q.DrawFigure();
                    pictureBox1.Image = q.bitmap;
                    
                }
                else if (isFigureChanged == true && currentFigur != null)
                {
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    currentFigur.poin[tmpIndex] = e.Location;
                    drower.Draw(first, currentFigur.poin[tmpIndex], nAngle, cf);                    
                    q.DrowOnlyOneFigure(currentFigur);
                    q.DrawFigure();                    
                    pictureBox1.Image = q.bitmap;                                       
                }                
            }            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {            
            if (drowing == true)
            {
                if (!(abstractFabric is UncommonPoligon))
                {
                    if (Figure == null)
                    {
                        cf = new CreatedFigure(new Brush(brush), null, Fill);
                    }
                    else
                    {
                    cf = new CreatedFigure(new Brush(brush), Figure, Fill);
                    }
                    drower = abstractFabric.CreateDrower(cf.figur, cf.brush, cf.fill);                    
                    q.listOfFigure.Add(cf);
                    q.Clone2();
                }
                
                first = e.Location;
                isDrow = true;
                isFirst = true;

                if (firstColor == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {                        
                        if (fill == true)
                        {
                            if (button1.BackColor != q.bitmap.GetPixel(e.X, e.Y))
                            {
                                Fill = new SolidFill(button1.BackColor);
                                Fill.SetColor(e.X, e.Y);
                                Fill.Casting(e.X, e.Y);
                                pictureBox1.Image = q.bitmap;
                            }
                        }
                        else if (Pipetka == true)
                        {
                            button1.BackColor = q.bitmap.GetPixel(e.X, e.Y);
                            color = button1.BackColor;
                            brush.SetColor(color);
                            cf.brush.SetColor(color);
                        }
                        else if (Eraser == true)
                        {
                            if (cf != null)
                                cf.brush.SetColor(Color.White);
                            brush.SetColor(Color.White);
                            brush.SetDot(e.X, e.Y);
                            pictureBox1.Image = q.bitmap;
                        }
                        else
                        {
                            if(cf!=null)
                            cf.brush.SetColor(button1.BackColor);
                            brush.SetColor(color);
                            if (abstractFabric is LineFabric)
                            {                                
                                brush.SetDot(e.X, e.Y);
                                q.DrawLine();
                                pictureBox1.Image = q.bitmap;
                            }
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        cf.brush.SetColor(button4.BackColor);
                        brush.SetColor(button4.BackColor);
                        if (abstractFabric is LineFabric)
                        {                            
                            brush.SetDot(e.X, e.Y);
                            q.DrawLine();
                            pictureBox1.Image = q.bitmap;
                        }
                    }
                }
                else 
                {
                    if (e.Button == MouseButtons.Left)
                    {                       
                       
                        if (fill == true)
                        {
                            if (button4.BackColor != q.bitmap.GetPixel(e.X, e.Y))
                            {
                                Fill = new SolidFill(button4.BackColor);
                                Fill.SetColor(e.X, e.Y);
                                Fill.Casting(e.X, e.Y);
                                pictureBox1.Image = q.bitmap;
                            }
                        }
                        else if (Pipetka == true)
                        {
                            button4.BackColor = q.bitmap.GetPixel(e.X, e.Y);
                            color = button4.BackColor;
                            brush.SetColor(color);
                            if (cf != null)
                                cf.brush.SetColor(color);
                        }
                        else if (Eraser == true)
                        {
                            cf.brush.SetColor(Color.White);
                            brush.SetColor(Color.White);
                            brush.SetDot(e.X, e.Y);
                            pictureBox1.Image = q.bitmap;
                        }
                        else
                        {
                            if (cf != null)
                                cf.brush.SetColor(button4.BackColor);
                            brush.SetColor(button4.BackColor);
                            if (abstractFabric is LineFabric)
                            {                                
                                brush.SetDot(e.X, e.Y);
                                q.DrawLine();
                                pictureBox1.Image = q.bitmap;
                            }
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        if (cf != null)
                            cf.brush.SetColor(button1.BackColor);
                        brush = new Brush(brush);
                        brush.SetColor(button1.BackColor);
                        if (abstractFabric is LineFabric)
                        {
                            brush = new Brush(brush);
                            brush.SetDot(e.X, e.Y);
                            q.DrawLine();
                            pictureBox1.Image = q.bitmap;
                        }
                    }
                }
                
                if (abstractFabric is UncommonPoligon)
                {
                    if (isFirstPoligon == true)
                    {
                        cf = new CreatedFigure(brush, Figure, Fill);
                        q.listOfFigure.Add(cf);
                        isFirstPoligon = false;
                        first = e.Location;
                        last = e.Location;
                        drower.Draw(e.Location, e.Location, nAngle,cf);
                        q.DrawLine();
                        q.Clone2();
                    }
                    else
                    {
                        drower.Draw(e.Location, first, nAngle,cf);
                        q.DrawLine();                        
                    }
                    pictureBox1.Image = q.bitmap;
                }
            }
            else if (isHanded == true|| isZoom==true|| isTurn==true)
            {
                isDrow = true;
                
                currentFigur = moving.FindPoint(e.Location);
               
                if (currentFigur != null)
                {                   
                    q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.GetBrush(brush, abstractFabric);
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowNotAllFigure(currentFigur);
                    q.Clone2();
                    //q.SetTmp();
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);                   
                    q.DrowOnlyOneFigure(currentFigur);                    
                    pictureBox1.Image = q.bitmap;                    
                }        

            }
            else if (isTop == true || isFigureChanged == true)
            {
                isDrow = true;
                
                for (int i = -10; i <= 10; i++)
                {
                    for (int j = -10; j <= 10; j++)
                    {
                        Point p = new Point(e.X + i, e.Y + j);
                        currentFigur = moving.FindPoint(p);
                        if (currentFigur != null)
                        {
                            tmpIndex = moving.FindMainPoint(p);
                            first = moving.FirstPoint(p);
                            break;
                        }
                    }
                    if (currentFigur != null)
                    {
                        break;
                    }
                }
                if (currentFigur != null)
                {                    
                    q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.GetBrush(brush, abstractFabric);
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowNotAllFigure(currentFigur);
                    q.Clone2();
                    //q.SetTmp();
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowOnlyOneFigure(currentFigur);                    
                    pictureBox1.Image = q.bitmap;                     
                }                   
            }
            else if(isGran == true)
            {
                isDrow = true;

                for (int i = -10; i <= 10; i++)
                {
                    for (int j = -10; j <= 10; j++)
                    {
                        Point p = new Point(e.X + i, e.Y + j);
                        currentFigur = moving.FindPoint(p);
                        if (currentFigur != null)
                        {
                            tmpIndex = moving.FindMainPoint(p);                            
                            break;
                        }
                    }
                    if (currentFigur != null)
                    {
                        break;
                    }
                }
                if (currentFigur != null)
                {
                    q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.GetBrush(brush, abstractFabric);
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowNotAllFigure(currentFigur);
                    q.Clone2();
                    //q.SetTmp();
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowOnlyOneFigure(currentFigur);
                    q.DrawFigure();
                    pictureBox1.Image = q.bitmap;
                }
            }

            else if (isColorChanged == true)
            {
                isDrow = true;                
                currentFigur = moving.FindPoint(e.Location);    
                if (currentFigur != null)
                {
                    q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.GetBrush(brush, abstractFabric);
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowNotAllFigure(currentFigur);
                    q.Clone2();                    
                    currentFigur.brush.SetColor(button1.BackColor);                    
                    q.GetBrush(brush, abstractFabric);
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowOnlyOneFigure(currentFigur);
                    q.DrawFigure();
                    pictureBox1.Image = q.bitmap;                    
                }                
            }
            else if (isThicknessChange == true)
            {
                isDrow = true;
                currentFigur = moving.FindPoint(e.Location);
                if (currentFigur != null)
                {
                    q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.GetBrush(brush, abstractFabric);
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowNotAllFigure(currentFigur);
                    q.Clone2();                    
                    currentFigur.brush.ChangePaint(n);                    
                    q.GetBrush(brush, abstractFabric);
                    q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    q.DrowOnlyOneFigure(currentFigur);
                    q.DrawFigure();
                    pictureBox1.Image = q.bitmap;
                }
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {            
            isDrow = false;
            isFirst = false;
            isFirstPoligon = false;
            color = Color.Black;
            q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            q.CreateBitmapList();
            brush = new Brush(pictureBox1.Width, pictureBox1.Height);            
            pictureBox1.Image = q.bitmap;
            isCollapsed = false;
            abstractFabric = new LineFabric();
            textBox3.Visible = false;
            q.heigth = pictureBox1.Height;
            q.width = pictureBox1.Width;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrow = false;
            if (!(abstractFabric is UncommonPoligon))
            { 
                q.Clone();
            }           
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
                case 9: n = 17; break;
                case 10: n = 20; break;
            }
            brush = new Brush(brush);
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
            pictureBox2.BackColor = button1.BackColor;
            button1.BackColor = button4.BackColor;
            button4.BackColor = pictureBox2.BackColor;
            brush = new Brush(brush);
            if (firstColor == true)
            {
                color = button1.BackColor;

                brush.SetColor(button1.BackColor);
            }
            else
            {
                color = button4.BackColor;
                brush.SetColor(button4.BackColor);
            }
        }

        private void button4_BackColorChanged(object sender, EventArgs e)
        {
            if (Fill is TwoColorFill)
            {
                Fill = new TwoColorFill(button4.BackColor);
            }
            else if (Fill is SolidFill)
            {
                Fill = new SolidFill(button4.BackColor);
            }
        }

        private void chooseFill_Click(object sender, EventArgs e)
        {
            Eraser = false;
            Pipetka = false;
            textBox3.Visible = false;
            fill = true;
        }

        private void заливкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fill = new TwoColorFill(button4.BackColor);
            toolStripDropDownButton1.Image = заливкаToolStripMenuItem.Image;
        }

        private void безЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fill = new WithoutFill();
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }

        private void заливкаОднотоннаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fill = new TwoColorFill(button1.BackColor);
            toolStripDropDownButton1.Image = заливкаОднотоннаяToolStripMenuItem.Image;
        }

        private void square_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new Square();
            textBox3.Visible = false;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new Rectangl();
            textBox3.Visible = false;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }

        private void RightTriangle_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new RightTriangle();
            textBox3.Visible = false;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new IsoscelesTriangle();
            textBox3.Visible = false;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }
        private void straightLine_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new StraightLine();
            textBox3.Visible = false;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }
        private void choosePen_Click(object sender, EventArgs e)
        {
            abstractFabric = new LineFabric();
            Eraser = false;
            textBox3.Visible = false;
            Pipetka = false;
            fill = false;
            Fill = null;
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            drower.Draw(first, last, nAngle,cf);
            q.DrawLine();            
            pictureBox1.Image = q.bitmap;
            drower = abstractFabric.CreateDrower(cf.figur, cf.brush, cf.fill);
            isFirstPoligon = true;            
            q.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figure = null;
            abstractFabric = new UncommonPoligon();
            textBox3.Visible = false;
            Eraser = false;
            Pipetka = false;
            fill = false;
            isFirstPoligon = true;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
            drower = abstractFabric.CreateDrower(Figure, brush, Fill);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new Poligon();
            textBox3.Visible = true;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }

        private void textBox3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nAngle = Convert.ToInt32(textBox3.Text);
                textBox3.Text = "";
                textBox3.Visible = false;
            }
        }

        private void oval_Click(object sender, EventArgs e)
        {
            abstractFabric = new FigureFabric();
            Figure = new Ellipse();
            textBox3.Visible = false;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            Figure = new Сircle();
            abstractFabric = new FigureFabric();
            textBox3.Visible = false;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Figure = new Star();
            abstractFabric = new FigureFabric();
            textBox3.Visible = true;
            Eraser = false;
            Pipetka = false;
            fill = false;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }       

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drowing = true;
            isHanded = false;
            isTop = false;
            isZoom = false;
            isTurn = false;
            isFigureChanged = false;
            isColorChanged = false;
            isThicknessChange = false;
            isGran = false;            
            toolStripDropDownButton2.Image = topToolStripMenuItem.Image;
        }

        private void перемещениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            drowing = false;
            isHanded = true;
            isTop = false;
            isZoom = false;
            isTurn = false;
            isFigureChanged = false;
            isColorChanged = false;
            isThicknessChange = false;
            isGran = false;            
            moving = new FigureMove();
            toolStripDropDownButton2.Image = перемещениеToolStripMenuItem1.Image;
        }

        private void верхушкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drowing = false;
            isHanded = false;
            isTop = true;
            isZoom = false;
            isTurn = false;
            isFigureChanged = false;
            isColorChanged = false;
            isThicknessChange = false;
            isGran = false;            
            moving = new PointMove();
            toolStripDropDownButton2.Image = верхушкаToolStripMenuItem.Image;
        }

        private void масштабируемToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            drowing = false;
            isHanded = false;
            isTop = false;
            isZoom = true;
            isTurn = false;
            isFigureChanged = false;
            isColorChanged = false;
            isThicknessChange = false;
            isGran = false;            
            moving = new ChangeSizeFigure();
            toolStripDropDownButton2.Image = масштабируемToolStripMenuItem.Image;            
        }

        private void меняетФигуруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drowing = false;
            isHanded = false;
            isTop = false;
            isZoom = false;
            isTurn = false;
            isFigureChanged = true;
            isColorChanged = false;
            isThicknessChange = false;
            isGran = false;            
            moving = new PointMove();
            toolStripDropDownButton2.Image = меняетФигуруToolStripMenuItem.Image;
        }

        private void поToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drowing = false;
            isHanded = false;
            isTop = false;
            isZoom = false;
            isTurn = false;
            isFigureChanged = false;
            isColorChanged = true;
            isThicknessChange = false;
            isGran = false;            
            moving = new FigureMove();
            toolStripDropDownButton2.Image = поToolStripMenuItem.Image;
        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            drowing = false;
            isHanded = false;
            isTop = false;
            isZoom = false;
            isTurn = true;
            isFigureChanged = false;
            isColorChanged = false;
            isThicknessChange = false;
            isGran = false;
            moving = new TigersTurn();
            toolStripDropDownButton2.Image = toolStripMenuItem2.Image;
        }

        private void увеличьТолщинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drowing = false;
            isHanded = false;
            isTop = false;
            isZoom = false;
            isTurn = false;
            isFigureChanged = false;
            isColorChanged = false;
            isThicknessChange = true;
            isGran = false;
            moving = new FigureMove();
            toolStripDropDownButton2.Image = увеличьТолщинуToolStripMenuItem.Image;
        }

        private void переместиГраньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drowing = false;
            isHanded = false;
            isTop = false;
            isZoom = false;
            isTurn = false;
            isFigureChanged = false;
            isColorChanged = false;
            isThicknessChange = false;
            isGran = true;
            moving = new GranMove();
            toolStripDropDownButton2.Image = переместиГраньToolStripMenuItem.Image;
        }           
        private void deleteAll_Click(object sender, EventArgs e)
        {
            isDrow = false;
            isFirst = false;
            isFirstPoligon = true;            
            q.bitFigure = new Bitmap(pictureBox1.Width, pictureBox1.Height);            
            q.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = q.bitmap;
            q.CreateBitmapList();
            q.tmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Eraser = false;
            Pipetka = false;
            fill = false;
            textBox3.Visible = false;
            isTop = false;
            isHanded = false;
            isZoom = false;
            isColorChanged = false;
            isFigureChanged = false;
            drowing = true;
            isTop = false;
            isTurn = false;
            isGran = false;
            toolStripDropDownButton2.Image = topToolStripMenuItem.Image;
            Fill = null;
            toolStripDropDownButton1.Image = безЗаливкиToolStripMenuItem.Image;
        }

        private void deleteTheLastOne_Click(object sender, EventArgs e)
        {
            q.Undo();            
            pictureBox1.Image = q.tmp1;            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            q.Redo();
            pictureBox1.Image = q.tmp1;
        }

        private void chooseEraser_Click(object sender, EventArgs e)
        {
            abstractFabric =new LineFabric();            
            Eraser = true;
            textBox3.Visible = false;
            Pipetka = false;
            fill = false;            
        }

        private void choosePipette_Click(object sender, EventArgs e)
        {
            Pipetka = true;
            Eraser = false;
            fill = false;
        }
    }
}

