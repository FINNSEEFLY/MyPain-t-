using System;
using System.Drawing;

namespace Shapes
{
    //
    // Класс прямоугольника
    //
    [Serializable]
    public class Rectangle : Quadrangle
    {
        // Реализация метода инициализации
        public override void Init(Color p, Color b, int X1, int Y1, int X2, int Y2)
        {
            HelpFunctions.SortCoord(ref X1, ref Y1, ref X2, ref Y2); ;
            penColor = p;
            brushColor = b;
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
        }
    }
}
