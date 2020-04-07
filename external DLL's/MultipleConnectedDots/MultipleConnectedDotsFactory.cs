using Shapes;
using System;
using System.Drawing;

namespace ShapeMaintenance
{
    public class MultipleConnectedDotsFactory : AbstractShapeFactory
    {
        public MultipleConnectedDotsFactory()
        {
            ShapeName = "Множественно соедененные точки";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new MultipleConnectedDots(pencolor, brushcolor);
        }
    }
}