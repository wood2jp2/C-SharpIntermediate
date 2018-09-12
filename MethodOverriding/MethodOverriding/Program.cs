using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            //shapes.Add(new Shape() { Width = 20, Height = 10, Type = ShapeType.Circle});
            //shapes.Add(new Shape() { Width = 99, Height = 88, Type = ShapeType.Rectangle });

            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
