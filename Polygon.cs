using System.Drawing;
using System.Collections.Generic;
using System;

namespace Shapes
{
    //
    // Класс многоугольника
    //
    [Serializable]
    public class Polygon : AbstractShape
    {
        public Polygon()
        {
            pointArray = new Point[0];
            maxNumberOfDots = 0;
        }
        public Polygon(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[0];
            maxNumberOfDots = 0;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(new SolidBrush(brushColor), pointArray);
            graphics.DrawPolygon(new Pen(penColor), pointArray);
        }
        public override void Init(Point[] pointarray)
        {
            pointArray = (Point[])pointarray.Clone();
        }
        public override object Clone()
        {
            var tmp = new Polygon(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}
