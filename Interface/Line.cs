using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp7;

namespace WindowsFormsApp7.Interface
{
    class Line : IFigure
    {
        int Width, Height,lastX,lastY;
        Bitmap bitmap;
        public Line(int x, int y)
        {
            Width = x;
            Height = y;
            bitmap = new Bitmap(Width, Height);
            lastY = 0;
            lastX = 0;
        }
        public Bitmap DrawFigure(int x, int y, Color color)
        {   if ((lastX==x&&lastY==y)||(lastX==1&&lastY==1)||(lastX==0&&lastY==0))
            { lastY = y; lastX = x; bitmap.SetPixel(x, y, color); }
            else if(lastX!=x&&lastY==y)
            {
                double k = (y - lastY) / (x - lastX);
                double b = lastY - k * lastX;
                for (int i = lastX; i < x; i++)
                {
                    bitmap.SetPixel(i, y, color);

                }
                for (int i = lastX; i > x; i--)
                {
                    bitmap.SetPixel(i, y, color);

                }
                lastX = x;
                lastY = y;
            }
        else if(lastY!=y&&lastX==x)
            {
                double k;
                if (x != lastX)
                {
                    k = (y - lastY) / (x - lastX);

                    double b = lastY - k * lastX;
                    if (lastY > y)
                    {
                        for (int i = lastY; i < y; i++)
                        {
                            bitmap.SetPixel(Convert.ToInt32((i - b) / k), i, color);

                        }
                    }
                    else
                    {
                        for (int i = lastY; i > y; i--)
                        {
                            bitmap.SetPixel(Convert.ToInt32((i - b) / k), i, color);

                        }
                    }
                }
                else
                {
                    for(int i = lastY;i<y;i++)
                    {
                        bitmap.SetPixel(x, i, color);
                    }
                    for (int i = lastY; i > y; i--)
                    {
                        bitmap.SetPixel(x, i, color);
                    }
                }
                lastX = x;
                lastY = y;
            }
        else if((lastX!=x&&lastY!=y) && (lastX != 1 && lastY != 1) &&(lastX != 0 && lastY != 0))
            {
                double dal = Math.Sqrt(Math.Pow(lastX - x, 2) + Math.Pow(lastY - y, 2));
                double xd = (x - lastX) / dal;
                double yd = (y - lastY) / dal;
                while(lastY!=y&&lastX!=x)
                {
                    bitmap.SetPixel(lastX, lastY, color);
                    lastY = lastY + System.Convert.ToInt32(yd);
                    lastX = lastX + System.Convert.ToInt32(xd); 
                }

                    //double c = lastX - x;
                //int i,xx=x,yy=y;
                //if(c>0)
                //{ i = 1; }
                //else
                //{ i = -1; }
                //double b =lastY - y;
                //int j;
                //if (b > 0)
                //{ j = 1; }
                //else
                //{ j = -1; }
                //if (Math.Abs(c) > Math.Abs(b))
                //{
                    //while(lastX!=x)
                    //{   
                    //    bitmap.SetPixel(x, y, color);
                    //    x += i;
                    //    y +=-j * System.Convert.ToInt32(b / c);
                    //}
                //}
                //else
                //{
                //    while(lastY!=y)
                //    {
                //        bitmap.SetPixel(x, y, color);
                //        y += j;
                //        x += -i * System.Convert.ToInt32(c / b);
                //    }
                //}
                //lastX = xx;
                //lastY = yy;
            }
            //bitmap.SetPixel(x, y,color);
            return bitmap;
        }
        public Bitmap DrawFigure(int x, int y)
        {
            lastX = x;
            lastY = y;
            return bitmap;
        }
    }
}
