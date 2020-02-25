using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс четырехугольника
    //
    [Serializable]
    public class Quadrangle : AbstractShape
    {
        // Реализация метода отрисовки для Quadrangle(используется в Rectangle и Square)
        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(brushColor), x1, y1, x2 - x1, y2 - y1);
            graphics.DrawRectangle(new Pen(penColor), x1, y1, x2 - x1, y2 - y1);
        }
        // Реализация метода инициализации
        public override void Init(Color p, Color b, int X1, int Y1, int X2, int Y2)
        {
            throw new NotImplementedException();
        }
    }
}
