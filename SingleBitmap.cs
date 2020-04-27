using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    class SingleBitmap
    {
        private static SingleBitmap Bit;

        private SingleBitmap()
        {
        }

        public static SingleBitmap Create()
        {
            if (Bit == null)
            {
                Bit = new SingleBitmap();
            }
            return Bit;
        }

        public Bitmap bitmap;
        public Bitmap first;
        public Bitmap bitFigure;
        public List<Bitmap> bitmap2;
        public List<Bitmap> listOfBitmap;
        public List<IFigur> listOfFigure;
        public List<Point> pointsList = new List<Point>();
        public Bitmap tmp1;
        Brush brush;
        public int width,heigth;
        int n, end;
       
        public void CreateBitmapList()
        {

            first = new Bitmap(bitmap);
            bitmap2 = new List<Bitmap>();
            listOfBitmap = new List<Bitmap>();
            listOfFigure = new List<IFigur>();
            bitmap2.Insert(0, bitmap);
            n = 0;
            end = n;
            listOfBitmap.Insert(n, bitFigure);
            //bitFigure = new Bitmap(width, heigth);
        }
        public void GetBrush(Brush brush)
        {
            this.brush = brush;
        }

        public void DrowAllFigure()
        {
            foreach(IFigur f in listOfFigure)
            {
                Point tmp = f.points[0];
                foreach (Point p in f.points)
                {
                    brush.DrawLine(tmp.X,tmp.Y, p.X,p.Y );
                    tmp = p;
                }
                brush.DrawLine(tmp.X, tmp.Y, f.points[0].X, f.points[0].Y);
            }
        }

        public void Clone()
        {
            tmp1 = new Bitmap(bitmap);
            n++;
            end = n;
            bitmap2.Insert(n, tmp1);           
        }

        public void DrawFigure()
        {
            bitmap = new Bitmap(tmp1);
            
            Graphics graph = Graphics.FromImage(bitmap);
            graph.DrawImage(bitFigure, 0, 0);
            
        }
       public void DrawLine()
        {
            Graphics graph = Graphics.FromImage(bitmap);
            graph.DrawImage(bitFigure, 0, 0);
        }
        public void SaveBitmap()
        { 
            listOfBitmap.Insert(n,bitFigure);
        }
        public void ChangeSize(int w, int h)
        {
            Bitmap ResultBitmap = new Bitmap(w, h);
            Graphics graph = Graphics.FromImage(ResultBitmap);
            graph.DrawImage(bitmap, 0, 0);
            bitmap = new Bitmap(w, h);
            bitmap = ResultBitmap;

        }

        public void Clone2()
        {
            if (n < end)
            {
                bitmap = new Bitmap(tmp1);
                for (int i = end; i > n; i--)
                {
                    bitmap2.RemoveAt(i);
                }
            }
            tmp1 = new Bitmap(bitmap);
        }

        public void Undo()
        {
            if (n > 1)
            {
                n--;
                tmp1 = bitmap2[n];
            }
            else if (n == 1)
            {
                n--;
                tmp1 = first;
            }
        }

        public void Redo()
        {
            if (n < end)
            {
                n++;
                tmp1 = bitmap2[n];
            }
        }
    }    
}
