using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Fill
    {
        int x, y;
        SingleBitmap q = SingleBitmap.Create();
        Color color = Color.Black;

        public Fill(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Casting(int x, int y, Color fillColor)
        {
            Color startColor = q.bitmap.GetPixel(x,y);
            int leftX = x;
            int rightX = x;
            while(q.bitmap.GetPixel(leftX-1, y)== startColor && leftX>0)
            {
                leftX--;
            }   
            for(int i = leftX; i<=rightX; i++)
            {
                q.bitmap.SetPixel(i, y,fillColor);
            }

            for (int i = leftX; i <= rightX; i++)
            {
                if (q.bitmap.GetPixel(i, y - 1) == startColor && y>0)
                {
                    Casting(i, y - 1, fillColor); 
                }
                if (q.bitmap.GetPixel(i, y + 1) == startColor && y > 0)
                {
                    Casting(i, y - 1, fillColor);
                }
            }

        }
    }
}
