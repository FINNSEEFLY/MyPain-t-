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
        // Реализация метода отрисовки для Line
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(penColor), x1, y1, x2, y2);
        }
        // Реализация метода инициализации
        public override void Init(Color p, Color b, int X1, int Y1, int X2, int Y2)
        {
            penColor = p;
            brushColor = b;
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
        }
    }
}
