using System.Drawing;
using System;

namespace Shapes
{
    //
    // Класс ломаной линии
    //
    [Serializable]
    public class Polyline : AbstractShape
    {
        public Polyline()
        {
            pointArray = new Point[0];
            MaxNumberOfDots = 0;
        }
        public Polyline(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[0];
            MaxNumberOfDots = 0;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(new Pen(penColor), pointArray);
        }
        public override void Init(Point[] pointarray)
        {
            pointArray = (Point[])pointarray.Clone();
        }
        public override object Clone()
        {
            var tmp = new Polyline(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}
