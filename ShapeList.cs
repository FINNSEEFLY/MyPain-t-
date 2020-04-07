using System;
using System.Collections.Generic;
using System.Drawing;
using Shapes;

namespace ShapeMaintenance
{
    //
    // Класс списка фигур
    //
    [Serializable]
    public class ShapeList
    {
        private readonly List<AbstractShape> listOfShapes;
        public ShapeList()
        {
            listOfShapes = new List<Shapes.AbstractShape>();
        }
        public void Draw(Graphics graphics)
        {
            foreach (AbstractShape shape in listOfShapes)
            {
                shape.Draw(graphics);
            }
        }
        public void AddToList(AbstractShape shape)
        {
            listOfShapes.Add((AbstractShape)shape.Clone());
        }
        public void Clear()
        {
            listOfShapes.Clear();
        }
        public void DelLastShape()
        {
            if (listOfShapes.Count != 0)
            {
                listOfShapes.RemoveAt(listOfShapes.Count - 1);
            }
        }
        public static ShapeList operator +(ShapeList firstlist, ShapeList secondlist)
        {
            foreach(var item in secondlist.listOfShapes)
            {
                firstlist.AddToList(item);
            }
            return firstlist;
        }
    }
}
