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
            graphics.FillEllipse(new SolidBrush(brushColor), new RectangleF(x1, y1, x2 - x1, y2 - y1));
            graphics.DrawEllipse(new Pen(penColor), new RectangleF(x1, y1, x2 - x1, y2 - y1));
        }
        // Реализация метода инициализации
        public override void Init(Color p, Color b, int X1, int Y1, int X2, int Y2)
        {
            throw new NotImplementedException();
        }
    }
}
