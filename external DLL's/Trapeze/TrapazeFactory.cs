using Shapes;
using System.Drawing;

namespace ShapeMaintenance
{
    class TrapazeFactory : AbstractShapeFactory
    {
        public TrapazeFactory()
        {
            ShapeName = "Трапеция";
        }
        public override AbstractShape Create(Color pencolor, Color brushcolor)
        {
            return new Trapeze(pencolor, brushcolor);
        }

    }
}
