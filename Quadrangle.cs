using System;
using System.Drawing;
using System.Collections.Generic;

namespace Shapes
{
    //
    // Класс четырехугольника
    //
    [Serializable]
    public class Quadrangle : AbstractShape
    {
        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(brushColor),
                                   pointArray[0].X,
                                   pointArray[0].Y,
                                   pointArray[1].X - pointArray[0].X,
                                   pointArray[1].Y - pointArray[0].Y);
            graphics.DrawRectangle(new Pen(penColor),
                                   pointArray[0].X,
                                   pointArray[0].Y,
                                   pointArray[1].X - pointArray[0].X,
                                   pointArray[1].Y - pointArray[0].Y);
        }
        public override void Init(Point[] pointarray)
        {
            throw new NotImplementedException();
        }
        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
