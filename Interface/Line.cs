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
        public Bitmap DrawFigure(int x, int y, Color color,Boolean isFirst)
        {   
            if ((lastX==x&&lastY==y)||(lastX==0&&lastY==0)||(isFirst==true))
            { lastY = y; lastX = x; bitmap.SetPixel(x, y, color); }
             if(lastX!=x&&lastY==y)
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
             if(lastY!=y&&lastX==x)
            {
                
                    for(int i = lastY;i<y;i++)
                    {
                        bitmap.SetPixel(x, i, color);
                    }
                    for (int i = lastY; i > y; i--)
                    {
                        bitmap.SetPixel(x, i, color);
                    }
                
                lastX = x;
                lastY = y;
            }
             if((lastX!=x&&lastY!=y) &&  (lastX != 0 && lastY != 0))
            {
                double dal = Math.Sqrt(Math.Pow(lastX - x, 2) + Math.Pow(lastY - y, 2));
                //double dal = (y - lastY) / (x - lastX);
                double xd = (x - lastX) / dal;
                double yd = (y - lastY) / dal;
                while(lastY!=y&&lastX!=x)
                {
                    bitmap.SetPixel(lastX, lastY, color);
                    lastY = lastY + System.Convert.ToInt32(yd);
                    lastX = lastX + System.Convert.ToInt32(xd); 
                }

               

            }
           
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
