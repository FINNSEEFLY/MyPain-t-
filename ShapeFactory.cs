using Shapes;
using System;
using System.Drawing;

namespace ShapeMaintenance
{
    //
    // Класс для создания экземпляров фигур
    // 
    public abstract class AbstractShapeFactory
    {
        public String ShapeName { get; set; }
        public abstract AbstractShape Create(Color pencolor, Color brushcolor);
    }
    public class LineFactory : AbstractShapeFactory
    {
        public LineFactory()
        {
            ShapeName = "Линия";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Line(pencolor,brushcolor);
        }
    }
    public class RectangleFactory : AbstractShapeFactory
    {
        public RectangleFactory()
        {
            ShapeName = "Прямоугольник";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Shapes.Rectangle(pencolor, brushcolor);
        }
    }
    public class SquareFactory : AbstractShapeFactory
    {
        public SquareFactory()
        {
            ShapeName = "Квадрат";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Square(pencolor, brushcolor);
        }
    }
    public class TriangleFactory : AbstractShapeFactory
    {
        public TriangleFactory()
        {
            ShapeName = "Треугольник";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Triangle(pencolor, brushcolor);
        }
    }
    public class EllipseFactory: AbstractShapeFactory
    {
        public EllipseFactory()
        {
            ShapeName = "Эллипс";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Ellipse(pencolor, brushcolor);
        }
    }
    public class CircleFactory : AbstractShapeFactory       
    {
        public CircleFactory()
        {
            ShapeName = "Круг";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Circle(pencolor, brushcolor);
        }
    }
    public class PolygonFactory : AbstractShapeFactory
    {
        public PolygonFactory()
        {
            ShapeName = "Многоугольник";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Polygon(pencolor, brushcolor);
        }
    }
    public class PolylineFactory : AbstractShapeFactory
    {
        public PolylineFactory()
        {
            ShapeName = "Ломаная";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Polyline(pencolor, brushcolor);
        }
    }
}
