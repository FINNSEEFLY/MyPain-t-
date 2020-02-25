using System;
using Shapes;

namespace ShapeListMaintenance
{
    //
    // Класс краткого описания фигуры:
    // Name - Название фигуры
    // Create - Ссылка на метод для создания объекта
    [Serializable]
    public class ShapeDescription
    {
        public String Name { get; set; }
        public Func<AbstractShape> Create { get; set; }
    }
}
