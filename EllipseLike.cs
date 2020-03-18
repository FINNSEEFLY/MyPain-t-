using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс эллипсообразных
    //
    [Serializable]
    public class EllipseLike : AbstractShape
    {
        // Реализация метода отрисовки для EllipseLike(используется в Ellipse и Circle)
        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(brushColor),
                       pointArray[0].X,
                       pointArray[0].Y,
                       pointArray[1].X - pointArray[0].X,
                       pointArray[1].Y - pointArray[0].Y);
            graphics.DrawEllipse(new Pen(penColor),
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
