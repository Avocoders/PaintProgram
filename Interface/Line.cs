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
            lastY = -1;
            lastX = -1;
        }
        public Bitmap DrawFigure(int x, int y, Color color)
        {   if ((lastX==x&&lastY==y)||(lastX==1&&lastY==1)||(lastX==-1&&lastY==-1))
            { lastY = y; lastX = x; bitmap.SetPixel(x, y, color); }
            else if(lastX!=x)
            {
                double k = (y - lastY) / (x - lastX);
                double b = lastY - k * lastX;
                for (int i = lastX; i < x; i++)
                {
                    bitmap.SetPixel(i, Convert.ToInt32(k * i + b), color);

                }
                for (int i = lastX; i > x; i--)
                {
                    bitmap.SetPixel(i, Convert.ToInt32(k * i + b), color);

                }
                lastX = x;
                lastY = y;
            }
        else if(lastY!=y)
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
