using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Brush

    {
        bool isFirst;
        int width, heigth;
        Bitmap q;
        public Brush(int width,int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }
        Color color = Color.Black;
        int n=1;
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
        public void DrawLine(int lastX,int lastY,int x, int y)
        {


            if (lastX == x && lastY == y || isFirst == true)
            {
                Pain(x, y);
                lastX = x;
                lastY = y;
            }

            while ((lastX != x || lastY != y) /*&& (radioButton1.Checked == false)*/)
            {
                if (lastX < x && lastY > y) //1   
                {
                    Pain(lastX + 1, lastY - 1);

                    lastX = lastX + 1;
                    lastY = lastY - 1;
                }

                if (lastX > x && lastY < y)//2
                {
                    Pain(lastX - 1, lastY + 1);

                    lastX = lastX - 1;
                    lastY = lastY + 1;
                }

                if (lastX == x && lastY <= y) //3
                {
                    Pain(lastX, lastY + 1);

                    lastY = lastY + 1;

                }

                if (lastX < x && lastY == y) //4
                {
                    Pain(lastX + 1, lastY);

                    lastX = lastX + 1;
                }

                if (lastX > x && lastY > y) //5
                {
                    Pain(lastX - 1, lastY - 1);

                    lastX = lastX - 1;
                    lastY = lastY - 1;
                }

                if (lastX < x && lastY < y) //6
                {
                    Pain(lastX + 1, lastY + 1);

                    lastX = lastX + 1;
                    lastY = lastY + 1;
                }

                if (lastX == x && lastY > y) //7
                {
                    Pain(lastX, lastY - 1);

                    lastY = lastY - 1;
                }

                if (lastX > x && lastY == y) //8
                {
                    Pain(lastX - 1, lastY);

                    lastX = lastX - 1;
                }
            }
            lastX = x;
            lastY = y;

        }

        

        public void Pain(int x, int y)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x - i > 0 && x + i < width && y - j > 0 && y + j < heigth)
                    {
                        q.SetPixel(x - i, y - j, color);
                        q.SetPixel(x + i, y + j, color);
                    }
                    q.SetPixel(x, y, color);
                }
            }
            //return q;
        }
    }
}
