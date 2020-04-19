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
        private Bitmap tmp;
        private List<Bitmap> bitmap;
        Form1 form = new Form1();
        int n, end;
        int width, heigth;
        private BitmapST()
        { }
        public Bitmap getInstance()
        {
            if (instance == null)
            {
                instance = new Bitmap(form.pictureBox1.Image,form.pictureBox1.Size);
                bitmap = new List<Bitmap>();
                bitmap.Add(instance);
                n = 0;
            }
            return instance;
        }
        //public void SetSize(int width, int height)
        //{
        //    this.width = width;
        //    this.heigth = height;
            
        //}
        public void ChangeSize()
        {
            instance = new Bitmap(form.pictureBox1.Image, form.pictureBox1.Size);
            bitmap = new List<Bitmap>();
            bitmap.Add(instance);
            n = 0;
        }
        public void AddLayer(Image image)
        {
            tmp = new Bitmap(image);
            bitmap.Add(tmp);
            n++;
            end = n;
            instance = bitmap[n];
        }
        public void Undo()
        {
            if (n > 0)
            {
                n--;
                instance = bitmap[n];
            }
        }
        public void Redo()
        {
            n++;
            instance = bitmap[n];
        }
        
    }
}
