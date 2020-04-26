using NUnit.Framework;
using System.Collections.Generic;
using WindowsFormsApp7;
using WindowsFormsApp7.Figure;
using System.Drawing;

namespace NUnitTestPaint
{
    public class Tests
    {
        public List<Point> IntArrayToPointList(int[] array)
        {
            List<Point> points = new List<Point>();

            for (int i = 0; i < array.Length; i += 2)
            {
                points.Add(new Point(array[i], array[i + 1]));
            }
            return points;
        }

        [TestCase(2, 2, 4, 4, new int[] { 2, 2, 4, 2, 4, 4, 2, 4 })]
        [TestCase(0, 0, 4, 4, new int[] { 0, 0, 4, 0, 4, 4, 0, 4 })]
        [TestCase(2, 2, 0, 0, new int[] { 2, 2, 0, 2, 0, 0, 2, 0 })]
        [TestCase(2, 0, 4, 4, new int[] { 2, 0, 4, 0, 4, 2, 2, 2 })]

        public void TestSquare(int x1, int y1, int x2, int y2, int[] ExArray)
        {
            Square Actual = new Square();
            List<Point> ActualPoit = Actual.Drow(x1, y1, x2, y2, 0);
            List<Point> Expected = IntArrayToPointList(ExArray);
            CollectionAssert.AreEqual(Expected, ActualPoit);
        }

        [TestCase(2, 2, 4, 4, new int[] { 2, 2, 4, 2, 4, 4, 2, 4 })]
        [TestCase(3, 6, 0, 0, new int[] { 3, 6, 0, 6, 0, 0, 3, 0 })]
        [TestCase(0, 0, 3, 6, new int[] { 0, 0, 3, 0, 3, 6, 0, 6 })]
        [TestCase(3, 6, 18, 0, new int[] { 3, 6, 18, 6, 18, 0, 3, 0 })]
        [TestCase(3, 6, 18, 7, new int[] { 3, 6, 18, 6, 18, 7, 3, 7 })]


        public void TestRectangle(int x1, int y1, int x2, int y2, int[] ExArray)
        {
            Rectangl Actual = new Rectangl();
            List<Point> ActualPoit = Actual.Drow(x1, y1, x2, y2, 0);
            List<Point> Expected = IntArrayToPointList(ExArray);
            CollectionAssert.AreEqual(Expected, ActualPoit);
        }

        [TestCase(0, 0, 8, 8, new int[] { 0, 0, 8, 8, 0, 8 })]
        [TestCase(8, 0, 0, 16, new int[] { 8, 0, 0, 16, 8, 16 })]
        [TestCase(0, 16, 9, 0, new int[] { 0, 16, 9, 0, 0, 0 })]
        [TestCase(12, 8, 9, 26, new int[] { 12, 8, 9, 26, 12, 26 })]
        [TestCase(0, 0, 9, 18, new int[] { 0, 0, 9, 18, 0, 18 })]

        public void TestRightTriangle(int x1, int y1, int x2, int y2, int[] ExArray)
        {
            RightTriangle Actual = new RightTriangle();
            List<Point> ActualPoit = Actual.Drow(x1, y1, x2, y2, 0);
            List<Point> Expected = IntArrayToPointList(ExArray);
            CollectionAssert.AreEqual(Expected, ActualPoit);
        }


        [TestCase(8, 8, 4, 4, new int[] { 8, 8, 4, 4, 0, 8 })]
        [TestCase(8, 8, 4, 12, new int[] { 8, 8, 4, 12, 0, 8 })]
        [TestCase(8, 8, 12, 12, new int[] { 8, 8, 12, 12, 16, 8 })]
        [TestCase(8, 8, 12, 12, new int[] { 8, 8, 12, 12, 16, 8 })]
        public void TestIsoscelesTriangle(int x1, int y1, int x2, int y2, int[] ExArray)
        {
            IsoscelesTriangle Actual = new IsoscelesTriangle();
            List<Point> ActualPoit = Actual.Drow(x1, y1, x2, y2, 0);
            List<Point> Expected = IntArrayToPointList(ExArray);
            CollectionAssert.AreEqual(Expected, ActualPoit);
        }

        [TestCase(10, 10, 10, 0, 5, new int[] { 20, 10, 13, 20, 2, 16, 2, 4, 13, 0 })]
        [TestCase(40, 40, 26, 15, 5, new int[] { 69, 40, 49, 68, 17, 57, 17, 23, 49, 12 })]
        [TestCase(10, 10, 15, 15, 6, new int[] { 17, 10, 14, 16, 7, 16, 3, 10, 6, 4, 14, 4 })]
        [TestCase(50, 50, 50, 0, 6, new int[] { 100, 50, 75, 93, 25, 93, 0, 50, 25, 7, 75, 7 })]
        public void TestPoligon(int x1, int y1, int x2, int y2, int n, int[] ExArray)
        {
            Poligon Actual = new Poligon();
            List<Point> ActualPoit = Actual.Drow(x1, y1, x2, y2, n);
            List<Point> Expected = IntArrayToPointList(ExArray);
            CollectionAssert.AreEqual(Expected, ActualPoit);
        }
    }
}