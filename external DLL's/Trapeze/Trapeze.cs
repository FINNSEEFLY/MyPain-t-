using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс трапеции
    //
    [Serializable]
    public class Trapeze : AbstractShape
    {
        public Trapeze()
        {
            pointArray = new Point[4];
            MaxNumberOfDots = 2;
        }
        public Trapeze(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[4];
            MaxNumberOfDots = 2;
        }
        public override void Init(Point[] pointarray)
        {
            pointArray = (Point[])pointarray.Clone();
            HelpFunctions.SortCoord(ref pointArray);
            pointArray[3] = pointArray[1];
            pointArray[1].Y = pointArray[2].Y = pointArray[0].Y;
            pointArray[1].X = ((pointArray[3].X - pointArray[0].X) / 4) + pointArray[0].X;
            pointArray[2].X = ((pointArray[3].X - pointArray[0].X) / 4 * 3) + pointArray[0].X;
            pointArray[0].Y = pointArray[3].Y;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(new SolidBrush(brushColor), pointArray);
            graphics.DrawPolygon(new Pen(penColor), pointArray);
        }
        public override object Clone()
        {
            var tmp = new Trapeze(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}
