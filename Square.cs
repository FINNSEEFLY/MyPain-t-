using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс квадрата
    //
    [Serializable]
    public class Square : Quadrangle
    {
        public Square()
        {
            pointArray = new Point[2];
            maxNumberOfDots = 2;
        }
        public Square(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[2];
            maxNumberOfDots = 2;
        }
        public override void Init(Point[] pointarray)
        {
            pointArray = (Point[])pointarray.Clone();
            HelpFunctions.SortCoord(ref pointArray);
            // x2 = Y2 - Y1 + X1 для уравнивания высоты и ширины;
            pointArray[1].X = pointArray[1].Y - pointArray[0].Y + pointArray[0].X;
        }
        public override object Clone()
        {
            var tmp = new Square(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}
