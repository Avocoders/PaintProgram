using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public class Brush
    {
        bool isFirst;
        int width, heigth;
        int n = 1;
        SingleBitmap q = SingleBitmap.Create();
        Color color = Color.Black;

        public Brush()
        {
        }
        public Brush(Brush brush)
        {
            this.color = brush.color;
            this.heigth = brush.heigth;
            this.isFirst = brush.isFirst;
            this.width = brush.width;
            this.n = brush.n;
        }
        public Brush(int width, int heigth)
        {            
            this.width = width;
            this.heigth = heigth;
        }
        public void  SetSize(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }              
        
        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void SetIsFirst(bool isFirst)
        {
            this.isFirst = isFirst;
        }
        
        public void ChangePaint(int a)
        {
            n = a;
        }

        public void DrawLine(int lastX, int lastY, int x, int y)
        {
            if (lastX == x && lastY == y || isFirst == true)
            {
                Pain(x, y);
                lastX = x;
                lastY = y;
            }
            int xd = (x - lastX);
            int yd = (y - lastY);            
            double xy;
            if (lastX == x)
            {
                if (lastY < y)
                {
                    for (int i = lastY; i <= y; i++)
                    {
                        Pain(x, i);
                    }
                    lastY = y;
                }
                if (lastY > y)
                {
                    for (int i = lastY; i >= y; i--)
                    {
                        Pain(x, i);
                    }
                    lastY = y;
                }
            }
            if (lastY == y)
            {
                if (lastX < x)
                {
                    for (int i = lastX; i <= x; i++)
                    {
                        Pain(i, y);
                    }
                    lastX = x;
                }
                if (lastX > x)
                {
                    for (int i = lastX; i >= x; i--)
                    {
                        Pain(i, y);
                    }
                    lastX = x;
                }
            }
            if (lastX < x && lastY > y)  // 1 четверть
            {
                if (Math.Abs(xd) >= Math.Abs(yd))
                {
                    xy = (double) yd / xd;
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastX; i <= x; i++)
                    {                        
                        lastY = (int)(Math.Round((i - firstX) * xy)) + firstY;
                        Pain(i, lastY);
                    }                    
                }
                if (Math.Abs(xd) < Math.Abs(yd))
                {

                    int firstX = lastX;
                    int firstY = lastY;
                    xy = (double) xd / yd;
                    for (int i = lastY; i >= y; i--)
                    {
                        lastX = (int)(Math.Round((i - firstY) * xy)) + firstX;
                        Pain(lastX, i);
                    }                    
                }
            }
            if (lastX < x && lastY < y)  // 2 четверть
            {
                if (Math.Abs(xd) >= Math.Abs(yd))
                {
                    xy = (double)yd / xd;
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastX; i <= x; i++)
                    {
                        lastY = (int)(Math.Round((i - firstX) * xy)) + firstY;
                        Pain(i, lastY);
                    }                    
                }
                if (Math.Abs(xd) < Math.Abs(yd))
                {
                    xy = (double)xd / yd;
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastY; i <= y; i++)
                    {
                        lastX = (int)(Math.Round((i - firstY) * xy)) + firstX;  
                        Pain(lastX, i);
                    }                    
                }
            }

            if (lastX > x && lastY > y)  // 3 четверть
            {
                if (Math.Abs(xd) >= Math.Abs(yd))
                {
                    xy = (double)yd / xd;
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastX; i >= x; i--)
                    {
                        lastY = (int)(Math.Round((i - firstX) * xy)) + firstY;
                        Pain(i, lastY);
                    }                    
                }
                if (Math.Abs(xd) < Math.Abs(yd))
                {
                    xy = (double)xd / yd;
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastY; i >= y; i--)
                    {
                        lastX = (int)(Math.Round((i - firstY) * xy)) + firstX;
                        Pain(lastX, i);
                    }                   
                }
            }

            if (lastX > x && lastY < y) // 4 четверть
            {
                if (Math.Abs(xd) >= Math.Abs(yd))
                {
                    xy = (double)yd / xd;
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastX; i >= x; i--)
                    {
                        lastY = (int)(Math.Round((i - firstX) * xy)) + firstY;
                        Pain(i, lastY);
                    }                    
                }
                if (Math.Abs(xd) < Math.Abs(yd))
                {
                    xy = (double)xd / yd;
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastY; i <= y; i++)
                    {
                        lastX = (int)(Math.Round((i - firstY) * xy)) + firstX;
                        Pain(lastX, i);
                    }                    
                }
            }
        }

        public void Pain(int x, int y)
        {
            int del = n / 2;
            for (int i = 0; i < n; i++)
            {
                if (x - del > 0 && x + del < width && y - del > 0 && y + del < heigth)
                {
                    
                    q.bitFigure.SetPixel(x - del + i, y + del, color);
                    q.bitFigure.SetPixel(x - del + i, y - del, color);
                    q.bitFigure.SetPixel(x + del, y - del + i, color);
                    q.bitFigure.SetPixel(x - del, y - del + i, color);
                }
            }
        }

        public void SetDot(int x, int y)
        {
            int del = n / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x - del > 0 && x + del < width && y - del > 0 && y + del < heigth)
                    {
                        q.bitFigure.SetPixel(x - del + i, y - del + j, color);
                    }
                }
            }
        }        
    }
}

