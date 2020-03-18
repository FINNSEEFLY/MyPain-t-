using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс круга
    //
    [Serializable]
    public class Circle : EllipseLike
    {
        public Circle()
        {
            pointArray = new Point[2];
            maxNumberOfDots = 2;
        }
        public Circle(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[2];
            maxNumberOfDots = 2;
        }
        public override void Init(Point[] pointarray)
        {
            base.pointArray = (Point[])pointarray.Clone();
            HelpFunctions.SortCoord(ref base.pointArray);
            // x2 = Y2 - Y1 + X1  для уравнивания вертикального и горизонтального радиусов;
            base.pointArray[1].X = base.pointArray[1].Y - base.pointArray[0].Y + base.pointArray[0].X;
        }
        public override object Clone()
        {
            var tmp = new Circle(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}

