using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс прямоугольника
    //
    [Serializable]
    public class Rectangle : Quadrangle
    {
        public Rectangle()
        {
            pointArray = new Point[2];
            MaxNumberOfDots = 2;
        }
        public Rectangle(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[2];
            MaxNumberOfDots = 2;
        }
        public override void Init(Point[] pointarray)
        {
            pointArray = (Point[])pointarray.Clone();
            HelpFunctions.SortCoord(ref pointArray);
        }
        public override object Clone()
        {
            var tmp = new Rectangle(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}
