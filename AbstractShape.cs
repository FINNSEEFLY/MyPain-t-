using System;
using System.Drawing;

namespace Shapes
{
    //
    // Абстрактный класс для всех фигур
    //
    [Serializable]
    public abstract class AbstractShape : ICloneable
    {
        // penColor - Цвет пера(границ фигуры)
        // brushColor - Цвет заливки фигуры
        // pointArray Точки необходимые для отрисовки
        // maxNumberOfDots - Количество точек необходимое для отрисовки
        //                   Если количество точек не известно - инициализируется нулем
        public Color penColor;
        public Color brushColor;
        public Point[] pointArray;
        public int MaxNumberOfDots { get; set; }

        // Абстрактный метод отрисовки
        public abstract void Draw(Graphics graphics);
        // Абстрактный метод инициализации
        public abstract void Init(Point[] pointarray);
        // Абстрактный метод клонирования
        public abstract object Clone();
    }
}
