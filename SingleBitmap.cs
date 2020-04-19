using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    class SingleBitmap
    {
        private static SingleBitmap Bit;

        private SingleBitmap()
        {
        }

        public static SingleBitmap Create()
        {
            if (Bit == null)
            {
                Bit = new SingleBitmap();
            }
            return Bit;
        }

        public Bitmap bitmap;
        public List<Bitmap> bitmap2;
        public Bitmap tmp1;
        public Bitmap tmp2;
        int n, end;

        public void CreateBitmapList()
        {
            bitmap2 = new List<Bitmap>();
            //bitmap2.Add(bitmap);
            n = 0;           
        }       

        public void Clone()
        {
            tmp1 = new Bitmap(bitmap);
            tmp2 = new Bitmap(tmp1);
            n++;
            end = n;
            bitmap2.Add(tmp2);
            //bitmap = tmp2;
        }

        public void DrawFigure()
        {
            tmp2 = new Bitmap(tmp1);
            bitmap = tmp2;
            bitmap2[n] = bitmap;
        }

        //public void Clone2()
        //{
        //    tmp2 = new Bitmap(bitmap);
        //}

        public void Undo()
        {
            bitmap2.Add(bitmap);
            if (n > 0)
            {
                n--;
                bitmap = bitmap2[n];
            }
        }

        public void Redo()
        {
            
            if (n < end && n >= 0)
            {
                n++;
                bitmap = bitmap2[n];
            }
        }
    }
}
