using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
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
        public Bitmap first;
        public List<Bitmap> bitmap2;
        public Bitmap tmp1;
        int n, end;        

        public void CreateBitmapList()
        {

            first = new Bitmap(bitmap);
            bitmap2 = new List<Bitmap>();
            bitmap2.Insert(0, bitmap);
            n = 0;
            end = n;
        }

        public void Clone()
        {
            tmp1 = new Bitmap(bitmap);
            n++;
            end = n;
            bitmap2.Insert(n, tmp1);
            
        }

        public void DrawFigure()
        {
            bitmap = new Bitmap(tmp1);
        }

        public void Clone2()
        {
            if (n < end)
            {
                bitmap = new Bitmap(tmp1);
                for (int i = end; i > n; i--)
                {
                    bitmap2.RemoveAt(i);
                }
            }
            tmp1 = new Bitmap(bitmap);
        }

        public void Undo()
        {
            if (n > 1)
            {
                n--;
                tmp1 = bitmap2[n];
            }
            else if (n == 1)
            {
                n--;
                tmp1 = first;
            }
        }

        public void Redo()
        {
            if (n < end)
            {
                n++;
                tmp1 = bitmap2[n];
            }
        }
    }    
}
