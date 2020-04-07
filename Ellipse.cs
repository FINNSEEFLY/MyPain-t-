using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс эллипса
    //
    [Serializable]
    public class Ellipse : EllipseLike
    {
        public Ellipse()
        {
            pointArray = new Point[2];
            MaxNumberOfDots = 2;
        }
        public Ellipse(Color pencolor, Color brushcolor)
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
            var tmp = new Ellipse(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}
