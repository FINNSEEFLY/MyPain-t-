using System.Drawing;
using System;
using Shapes;

namespace Shapes
{
    //
    // Класс ломаной линии
    //
    [Serializable]
    class MultipleConnectedDots : AbstractShape
    {
        public MultipleConnectedDots()
        {
            pointArray = new Point[0];
            MaxNumberOfDots = 0;
        }
        public MultipleConnectedDots(Color pencolor, Color brushcolor)
        {
            penColor = pencolor;
            brushColor = brushcolor;
            pointArray = new Point[0];
            MaxNumberOfDots = 0;
        }
        public override void Draw(Graphics graphics)
        {
            using (var pen = new Pen(penColor))
            {
                for (int i = 0; i < pointArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < pointArray.Length; j++)
                    {
                        graphics.DrawLine(pen, pointArray[i], pointArray[j]);
                    }
                }
            }
        }
        public override void Init(Point[] pointarray)
        {
            pointArray = (Point[])pointarray.Clone();
        }
        public override object Clone()
        {
            var tmp = new MultipleConnectedDots(penColor, brushColor);
            tmp.Init(pointArray);
            return tmp;
        }
    }
}