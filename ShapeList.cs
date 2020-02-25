using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShapeListMaintenance
{
    //
    // Класс списка фигур
    //
    [Serializable]
    public class ShapeList
    {
        public List<Shapes.AbstractShape> ListOfShapes;
        public ShapeList()
        {
            ListOfShapes = new List<Shapes.AbstractShape>();
        }
        public void Draw(Graphics graphics)
        {
            foreach (Shapes.AbstractShape shape in ListOfShapes)
            {
                shape.Draw(graphics);
            }
        }
        public void AddToList(Shapes.AbstractShape shape)
        {
            ListOfShapes.Add(shape);
        }
        public void Clear()
        {
            ListOfShapes.Clear();
        }
    }
}
