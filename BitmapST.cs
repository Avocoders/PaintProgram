using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class BitmapST
    {

        private static Bitmap instance;
        private static Bitmap tmp,tmp2;
        private static List<Bitmap> bitmap;
        static System.Drawing.Imaging.PixelFormat format;
        static RectangleF cloneRect;
        static Form1 form = new Form1();
        static int n, end;
        static int width, heigth;
        private BitmapST()
        { }
        public static Bitmap getInstance()
        {
            if (instance == null)
            {
                instance = new Bitmap(width, heigth);
                bitmap = new List<Bitmap>();
                bitmap.Add(instance);
                n = 0;
            }
            return instance;
        }
        public static void SetSize(int w, int h)
        {
            width = w;
            heigth = h;
        }
        public static void ChangeSize()
        {
            instance = new Bitmap(width, heigth);
            bitmap = new List<Bitmap>();
            bitmap.Add(instance);
            n = 0;
        }
        public static void AddLayer(Bitmap q)
        {
            tmp = new Bitmap( q);
            cloneRect = new RectangleF(0, 0,width, heigth);
            format = tmp.PixelFormat;
            tmp2 = tmp.Clone(cloneRect, format);
            n++;
            end = n;
            bitmap.Add(tmp2);
            
            instance = tmp2;
            
        }
        public static void DrawFigure()
        {
            tmp2 = tmp.Clone(cloneRect, format);
            instance = tmp2;
        }
        public static void Undo()
        {
            if (n > 0)
            {
                n--;
                instance = bitmap[n];
            }
        }
        public static void Redo()
        {
            if (n < end)
            {
                n++;
                instance = bitmap[n];
            }
        }
        
    }
}
