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
        Bitmap q;
        public Brush(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }
        Color color = Color.Black;
        int n = 1;
        public void SetBitmap(Bitmap q)
        {
            this.q = q;
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public void SetIsFirst(bool isFirst)
        {
            this.isFirst = isFirst;
        }
        public Bitmap GetBitmap()
        {
            return q;
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
            xd = Math.Abs(xd);
            yd = Math.Abs(yd);
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
                if (xd >= yd)
                {
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastX; i <= x; i++)
                    {
                        Pain(i, lastY);
                        lastY = ((i - firstX) * (y - firstY)) / (x - firstX) + firstY;
                    }
                    lastX = x;
                    lastY = y;
                }
                if (xd < yd)
                {
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastY; i >= y; i--)
                    {
                        Pain(lastX, i);
                        lastX = ((i - firstY) * (x - firstX)) / (y - firstY) + firstX;
                    }
                    lastX = x;
                    lastY = y;
                }
            }

            if (lastX < x && lastY < y)
            {
                if (xd >= yd)
                {
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastX; i <= x; i++)
                    {
                        Pain(i, lastY);
                        lastY = ((i - firstX) * (y - firstY)) / (x - firstX) + firstY;
                    }
                    lastX = x;
                    lastY = y;
                }
                if (xd < yd)
                {
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastY; i <= y; i++)
                    {
                        Pain(lastX, i);
                        lastX = ((i - firstY) * (x - firstX)) / (y - firstY) + firstX;
                    }
                    lastX = x;
                    lastY = y;
                }
            }

            if (lastX > x && lastY > y)
            {
                if (xd >= yd)
                {
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastX; i >= x; i--)
                    {
                        Pain(i, lastY);
                        lastY = ((i - firstX) * (y - firstY)) / (x - firstX) + firstY;
                    }
                    lastX = x;
                    lastY = y;
                }
                if (xd < yd)
                {
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastY; i >= y; i--)
                    {
                        Pain(lastX, i);
                        lastX = ((i - firstY) * (x - firstX)) / (y - firstY) + firstX;
                    }
                    lastX = x;
                    lastY = y;
                }
            }

            if (lastX > x && lastY < y)
            {
                if (xd >= yd)
                {
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastX; i >= x; i--)
                    {
                        Pain(i, lastY);
                        lastY = ((i - firstX) * (y - firstY)) / (x - firstX) + firstY;
                    }
                    lastX = x;
                    lastY = y;
                }
                if (xd < yd)
                {
                    int firstX = lastX;
                    int firstY = lastY;
                    for (int i = lastY; i <= y; i++)
                    {
                        Pain(lastX, i);
                        lastX = ((i - firstY) * (x - firstX)) / (y - firstY) + firstX;
                    }
                    lastX = x;
                    lastY = y;
                }
            }

            //while ((lastX != x || lastY != y))
            //{
                
            //}     

        }

        public void Pain(int x, int y)
        {
            //int x2=0;
            //int y2=0;
            //for (int i = 0; i < 181; i++)
            //{
            //    x2 = x2 + Convert.ToInt32(n * Math.Cos(i * 3.14159 / 180));
            //    y2 = y2 + Convert.ToInt32(n * Math.Sin(i * 3.14159 / 180));
            //    q.SetPixel(x2, y2, color);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x - i > 0 && x + i < width && y - j > 0 && y + j < heigth)
                    {
                        q.SetPixel(x - i, y - j, color);
                        q.SetPixel(x + i, y + j, color);
                        q.SetPixel(x, y, color);
                    }
                }
            }
        }
        }
    }

