using System;
using System.Collections.Generic;
using System.Drawing;
using Shapes;

namespace ShapeListMaintenance
{
    //
    // Класс списка фигур
    //
    [Serializable]
    public class ShapeList
    {
        private List<AbstractShape> ListOfShapes;
        public ShapeList()
        {
            ListOfShapes = new List<Shapes.AbstractShape>();
        }
        public void Draw(Graphics graphics)
        {
            foreach (AbstractShape shape in ListOfShapes)
            {
                shape.Draw(graphics);
            }
        }
        public void AddToList(AbstractShape shape)
        {
            ListOfShapes.Add((AbstractShape)shape.Clone());
        }
        public void Clear()
        {
            ListOfShapes.Clear();
        }
    }
}
