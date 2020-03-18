using System;
using Shapes;
using System.Drawing;

namespace ShapeListMaintenance
{
    //
    // Класс краткого описания фигуры:
    // Name - Название фигуры
    // Create - Ссылка на метод для создания объекта
    [Serializable]
    public class ShapeFactoryDescription
    {
        public String Name { get; set; }
        public Func<Color,Color,AbstractShape> Create { get; set; }
    }
}