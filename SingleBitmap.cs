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
        public Bitmap tmp2;
        public Bitmap tmp3;
        int n, end;

        public void CreateBitmapList()
        {
            first = new Bitmap(bitmap);
            bitmap2 = new List<Bitmap>();
            bitmap2.Add(bitmap);
            n = 0;            
        }

        public void Clone()
        {
            //tmp1 = new Bitmap(bitmap);
            tmp2 = new Bitmap(bitmap);
            n++;
            end = n;
            bitmap2.Add(tmp2);
            //bitmap = tmp2;
        }

        public void DrawFigure()
        {
            tmp3 = new Bitmap(tmp1);
            bitmap = tmp3;
            bitmap2[n] = bitmap;
        }

        public void Clone2()
        {
            for(int i = end; i > n; i--)
            {
                bitmap2.RemoveAt(i);                
            }
            //end = n;
            //tmp1 = new Bitmap(bitmap);                        
        }

        public void Undo()
        {
            //bitmap2.Add(bitmap);
            //n++;
            //end = n;
            if (n > 1)
            {
                n--;
                bitmap = bitmap2[n];
            }
            else if(n == 1)
            {
                n--;
                bitmap = first;
            }            
            
        }

        public void Redo()
        {
            //bitmap2.Add(bitmap);
            //n++;
            //end = n;
            if (n < end)
            {
                n++;
                bitmap = bitmap2[n];
            }
        }

    }
}
