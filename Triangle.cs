using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс треугольника
    //
    [Serializable]
    public class Triangle : AbstractShape
    {
        public Triangle()
        {
            pointArray = new Point[3];
            maxNumberOfDots = 3;
        }
        public Triangle(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[3];
            maxNumberOfDots = 3;
        }
        public override void Init(Point[] pointarray)
        {
            pointArray = (Point[])pointarray.Clone();
        }
        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(new SolidBrush(brushColor), pointArray);
            graphics.DrawPolygon(new Pen(penColor), pointArray);
        }
        public override object Clone()
        {
            var tmp = new Triangle(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}
