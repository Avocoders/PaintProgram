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
        public Bitmap bitmap2;
        public Bitmap tmp;

        
        public void Clone()
        {
            bitmap2 = new Bitmap(bitmap);

        }

        public void Clone2()
        {
            tmp = new Bitmap(bitmap);
        }

        public void Redo()
        {

            bitmap = bitmap2;
        }

        public void Undo()
        {
            bitmap = tmp;
        }
    }
}
