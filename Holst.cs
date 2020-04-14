using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Holst
    {
        Bitmap bitmap1, bitmap2;
        Brush brush;
        bool isReturned=false;
        public Holst(Bitmap bitmap, Brush brush)
        {
            bitmap1 = bitmap;
            bitmap2 = new Bitmap(bitmap.Width,bitmap.Height);
            this.brush = brush;
        }
        public void SetBitmap(Bitmap bitmap)
        {   
            bitmap1 = bitmap;
        }
        public Bitmap GetLastBitmap()
        {
            if (isReturned == true)
            { return bitmap2; }
            else
            { return bitmap1; }
            if(isReturned==true)
            { isReturned = false; }
            else
            { isReturned = true; }
        }
        public Bitmap GetBitmap()
        { return bitmap1; }
        public void SetBitmapToBrush()
        {
            brush.SetBitmap(bitmap1);
        }
        public Bitmap DrowFigure()
        {
            Bitmap bitmap3 = new Bitmap(bitmap1);
           brush.SetBitmap( bitmap3 );
           // brush.DrawLine( lastX,  lastY,  x,  y);
            bitmap2 = brush.GetBitmap();
            //brush.SetBitmap(bitmap3);
            return bitmap2;
        }
        public Bitmap DrowLine()
        {
            brush.SetBitmap(bitmap1);
            bitmap2 = brush.GetBitmap();
            return bitmap1;
        }
    }
}
