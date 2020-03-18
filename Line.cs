using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс Линии
    //
    [Serializable]
    public class Line : AbstractShape
    {
        public Line()
        {
            pointArray = new Point[2];
            maxNumberOfDots = 2;
        }
        public Line(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[2];
            maxNumberOfDots = 2;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(penColor),pointArray[0],pointArray[1]);
        }
        public override void Init(Point[] pa)
        {
            pointArray = (Point[])pa.Clone();
        }
        public override object Clone()
        {
            var tmp = new Line(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}
