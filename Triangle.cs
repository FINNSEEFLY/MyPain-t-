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
        // Реализация метода инициализации
        public override void Init(Color p, Color b, int X1, int Y1, int X2, int Y2)
        {
            HelpFunctions.SortCoord(ref X1, ref Y1, ref X2, ref Y2);
            penColor = p;
            brushColor = b;
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
        }
        // Реализация метода отрисовки
        public override void Draw(Graphics graphics)
        {
            PointF[] points = new PointF[3]
            {
                new PointF(x1, y2),
                new PointF(x2, y2),
                new PointF(x1+((x2-x1)/2), y1)
            };
            graphics.FillPolygon(new SolidBrush(brushColor), points);
            graphics.DrawPolygon(new Pen(penColor), points);
        }
    }
}
