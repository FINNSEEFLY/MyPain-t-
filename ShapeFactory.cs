using Shapes;

namespace ShapeListMaintenance
{
    //
    // Класс для создания экземпляров фигур
    // 
    public static class ShapeFactory
    {
        // Методы реализующие выбор и создание экземпляров фигур
        public static AbstractShape LineCreate()
        {
            return new Line();
        }
        public static AbstractShape RectangleCreate()
        {
            return new Shapes.Rectangle();
        }
        public static AbstractShape SquareCreate()
        {
            return new Square();
        }
        public static AbstractShape TriangleCreate()
        {
            return new Triangle();
        }
        public static AbstractShape EllipseCreate()
        {
            return new Ellipse();
        }
        public static AbstractShape CircleCreate()
        {
            return new Circle();
        }
    }
}
