using System;
using System.Drawing;

namespace Shapes
{
    //
    // Абстрактный класс для всех фигур
    //
    [Serializable]
    public abstract class AbstractShape
    {
        // Цвет пера(границ фигуры)
        public Color penColor;
        // Цвет заливки фигуры
        public Color brushColor;
        // Координаты области фигуры
        // Point(x1,y1) - Левый верхний угол
        // Point(x2,y2) - Правый нижний угол
        public int x1, y1, x2, y2;

        // Абстрактный метод отрисовки
        public abstract void Draw(Graphics graphics);
        // Абстрактный метод инициализации
        public abstract void Init(Color p, Color b, int X1, int Y1, int X2, int Y2);
    }
}
