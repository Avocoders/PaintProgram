using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7.Figure
{
    class Ellipse : IFigur
    {
        Brush q;
        public Ellipse(Brush bruch)
        {
            q = bruch;
        }

        public void Drow(int x1, int y1, int x2, int y2)
        {
            int a=0, b=0, nx, ny;
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int cx = (x1 + x2) / 2;
            int cy = (y1 + y2) / 2;

            if (x2 > x1 && y2 < y1)
            {
                nx = x1 + dx / 2;
                ny = y1 + dy;
                int ax1 = x1 + dx / 2;
                int ay1 = y1;
                int ax2 = x2 - dx / 2;
                int ay2 = y2;
                int bx1 = x1;
                int by1 = y1 - dy / 2;
                int bx2 = x2;
                int by2 = y2 + dy / 2;
                a = Convert.ToInt32(Math.Sqrt(Math.Abs((ax2 * ax2 - ax1 * ax1)) + Math.Abs((ay2 * ay2 - ay1 * ay1)))/2);
                b = Convert.ToInt32(Math.Sqrt(Math.Abs((bx2 * bx2 - bx1 * bx1)) + Math.Abs((by2 * by2 - by1 * by1)))/2);             
            }
            else if (x2 > x1 && y2 > y1) 
            {
                
                nx = x1 + dx / 2;
                ny = y1;
                int ax1 = x2 - dx / 2;
                int ay1 = y2;
                int ax2 = x1 + dx / 2;
                int ay2 = y1;
                int bx1 = x1;
                int by1 = y1 + dy / 2;
                int bx2 = x2;
                int by2 = y2 - dy / 2;
                a = Convert.ToInt32(Math.Sqrt(Math.Abs((ax2 * ax2 - ax1 * ax1)) + Math.Abs((ay2 * ay2 - ay1 * ay1))) / 2);
                b = Convert.ToInt32(Math.Sqrt(Math.Abs((bx2 * bx2 - bx1 * bx1)) + Math.Abs((by2 * by2 - by1 * by1))) / 2);                
            }
            else if (x2 < x1 && y2 > y1)
            {
               
                nx = x1 - dx / 2;
                ny = y1;
                int ax1 = x2 + dx / 2;
                int ay1 = y2;
                int ax2 = x1 - dx / 2;
                int ay2 = y1;
                int bx1 = x2;
                int by1 = y2 - dy / 2;
                int bx2 = x1;
                int by2 = y1 + dy / 2;
                a = Convert.ToInt32(Math.Sqrt(Math.Abs((ax2 * ax2 - ax1 * ax1)) + Math.Abs((ay2 * ay2 - ay1 * ay1)))/2);
                b = Convert.ToInt32(Math.Sqrt(Math.Abs((bx2 * bx2 - bx1 * bx1)) + Math.Abs((by2 * by2 - by1 * by1)))/2);
            }
            else 
            {                
                nx = x1 - dx / 2;
                ny = y2;
                int ax1 = x1 - dx / 2;
                int ay1 = y1;
                int ax2 = x2 + dx / 2;
                int ay2 = y2;
                int bx1 = x2-dx/2;
                int by1 = y2 + dy / 2;
                int bx2 = x1;
                int by2 = y1 - dy / 2;
                a = Convert.ToInt32(Math.Sqrt(Math.Abs((ax2 * ax2 - ax1 * ax1)) + Math.Abs((ay2 * ay2 - ay1 * ay1)))/2);
                b = Convert.ToInt32(Math.Sqrt(Math.Abs((bx2 * bx2 - bx1 * bx1)) + Math.Abs((by2 * by2 - by1 * by1)))/2);
            }


            for (int i = 0; i < 360; i++)
            {                
                int ex = cx + Convert.ToInt32(a * Math.Cos(i * 3.14159f / 180.0f));
                int ey = cy + Convert.ToInt32(b * Math.Sin(i * 3.14159f / 180.0f));
                q.DrawLine(ex, ey, nx, ny);
                nx = ex;
                ny = ey;
            }
        }
    }
}
