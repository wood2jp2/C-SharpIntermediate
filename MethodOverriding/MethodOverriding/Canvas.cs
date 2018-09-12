using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        // Each element passed in here is going to be either a shape, or a class that derives from Shape.
        public void DrawShapes(List<Shape> shapes)
        {
            // This is an example of polymorphism: The Draw method can have many forms depending on the Shape's
            // implementation of draw.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
